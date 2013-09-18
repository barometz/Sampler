using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Windows.Forms;
using EricOulashin;
using ExpressionEval.ExpressionEvaluation;
using ExpressionEval.MethodState;

namespace Sampler
{
    public partial class SamplerForm : Form
    {
        private readonly Dictionary<uint, RadioButton> _defaultRates;
        private readonly string _tempfilename;
        private SoundPlayer _player;
        private Sample _sample;
        private bool _unsavedChanges = false;

        public SamplerForm()
        {
            InitializeComponent();
            _defaultRates = new Dictionary<uint, RadioButton>
            {
                {8000, rate8000},
                {8363, rate8363},
                {11025, rate11k},
                {22050, rate22k},
                {44100, rate44k}
            };

            foreach (var defaultRate in _defaultRates)
            {
                defaultRate.Value.Tag = defaultRate.Key;
            }

            MakeNewSample();

            _tempfilename = Path.GetTempFileName();
        }

        private void MakeNewSample()
        {
            _sample = new Sample {SampleCount = 16};
            UpdateTimeUI(_sample);
            UpdateBitdepthUI(_sample);
            UpdateSampleRateUI(_sample);
            _sample.SampleChanged += sample_SampleChanged;
            FormulaBox.Text = "sin(t, C)";
            ParseToSample(FormulaBox.Text, _sample);
            _unsavedChanges = false;
        }

        private static Func<double, double> GetMethod(EvalContext context, EvalExpression<double, EvalContext> expr)
        {
            Func<double, double> ret = delegate(double t)
            {
                context.t = t;
                return expr(context);
            };
            return ret;
        }

        /// <summary>
        ///     Turn a function string ("sin(t, C)") into a Func&lt;double, double&gt; and connect it with the sample.
        /// </summary>
        /// <param name="text">A string that represents a function that can be used to generate a waveform.</param>
        /// <param name="sample">
        ///     The sample will be used in the method's evaluation context and receives the generated Func&lt;
        ///     double, double&gt;.
        /// </param>
        private static void ParseToSample(string text, Sample sample)
        {
            IExpressionEvaluator eval = new ExpressionEvaluator(ExpressionLanguage.CSharp);
            var context = new EvalContext {S = sample};
            EvalExpression<double, EvalContext> expression = eval.GetDelegate<double, EvalContext>(text);
            sample.WaveFunction = GetMethod(context, expression);
        }

        /// <summary>
        ///     Store the provided sample at the specified location.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="sample"></param>
        private static void StoreWAV(string filename, Sample sample)
        {
            var wav = new WAVFile();
            // TODO: Clamp Sample.BitDepth to 8/16 (or not?)
            wav.Create(filename, false, (int) sample.SampleRate, (short) sample.BitDepth, true);
            if (sample.BitDepth == 8)
            {
                for (int i = 0; i < sample.SampleCount; i++)
                {
                    // Need to add 128 because AddSample_8bit takes unsigned bytes.
                    wav.AddSample_8bit((byte) (sample.ValueAt(i*sample.Resolution) + 128));
                }
            }
            else // Assume 16-bit for now.
            {
                for (int i = 0; i < sample.SampleCount; i++)
                {
                    wav.AddSample_16bit((short) sample.ValueAt(i*sample.Resolution));
                }
            }
            wav.Close();
        }

        private void sample_SampleChanged(object sender, SampleChangedEventArgs e)
        {
            var sample = sender as Sample;
            if (sample == null)
            {
                return;
            }

            switch (e.Type)
            {
                case SampleChangedEventArgs.ChangeType.BitDepth:
                    UpdateBitdepthUI(sample);
                    break;
                case SampleChangedEventArgs.ChangeType.Length:
                    UpdateTimeUI(sample);
                    break;
                case SampleChangedEventArgs.ChangeType.SampleRate:
                    UpdateTimeUI(sample);
                    UpdateSampleRateUI(sample);
                    break;
            }

            SampleChart.ChartAreas[0].AxisX.Maximum = sample.Length*1000;
            SampleChart.ChartAreas[0].AxisY.Minimum = sample.LowerBound - 1;
            SampleChart.ChartAreas[0].AxisY.Maximum = sample.UpperBound;
            // Getting the gridlines right on a Chart is a bit of a pain 
            SampleChart.ChartAreas[0].AxisY.Interval = (sample.LowerBound - 2)/-2.0;

            SampleChart.Series[0].Points.Clear();
            for (int i = 0; i < sample.SampleCount; i++)
            {
                SampleChart.Series[0].Points.AddXY(i*1000*sample.Resolution, sample.ValueAt(i*sample.Resolution));
            }
            // Get at most ten tickmarks on the X-axis. 
            SampleChart.ChartAreas[0].AxisX.Interval = Math.Pow(10, Math.Floor(Math.Log10(sample.Length*1000)));

            _unsavedChanges = true;
        }

        private void UpdateBitdepthUI(Sample sample)
        {
            if (sample.BitDepth == 8)
            {
                BitDepth8.Checked = true;
            }
            else if (sample.BitDepth == 16)
            {
                BitDepth16.Checked = true;
            }
        }

        private void UpdateSampleRateUI(Sample sample)
        {
            if (CustomRate.Value == sample.SampleRate)
            {
                rateCustom.Checked = true;
            }
            else if (_defaultRates.ContainsKey(sample.SampleRate))
            {
                _defaultRates[sample.SampleRate].Checked = true;
            }
            else
            {
                rateCustom.Checked = true;
                CustomRate.Value = sample.SampleRate;
            }
        }

        /// <summary>
        ///     Sets the limits of the time controls according to the resolution of the <paramref name="sample" /> and
        ///     their values according to its length.
        /// </summary>
        /// <param name="sample"></param>
        private void UpdateTimeUI(Sample sample)
        {
            Time.Minimum = Convert.ToDecimal(sample.Resolution*1000);
            Time.Increment = Convert.ToDecimal(sample.Resolution*1000);
            logTime.Minimum = Convert.ToInt32(Math.Log10(sample.Resolution)*10);

            Time.Value = Convert.ToDecimal(sample.Length*1000);
            SampleCount.Value = sample.SampleCount;
            logTime.Value = Convert.ToInt32(Math.Log10(sample.Length)*10);
        }

        private void ApplyFunction_Click(object sender, EventArgs e)
        {
            try
            {
                ParseToSample(FormulaBox.Text, _sample);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BitDepth_CheckedChanged(object sender, EventArgs e)
        {
            if (sender as RadioButton == BitDepth8)
            {
                _sample.BitDepth = 8;
            }
            else if (sender as RadioButton == BitDepth16)
            {
                _sample.BitDepth = 16;
            }
        }

        private void SampleCount_ValueChanged(object sender, EventArgs e)
        {
            if (sender as NumericUpDown != null)
            {
                _sample.SampleCount = Convert.ToUInt32((sender as NumericUpDown).Value);
            }
        }

        private void Time_ValueChanged(object sender, EventArgs e)
        {
            if (sender as NumericUpDown != null)
            {
                _sample.Length = Convert.ToDouble((sender as NumericUpDown).Value/1000);
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            StoreWAV(_tempfilename, _sample);
            _player = new SoundPlayer(_tempfilename);
            if (Loop.Checked)
            {
                _player.PlayLooping();
            }
            else
            {
                _player.Play();
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (_player != null)
            {
                _player.Stop();
            }
        }

        private void logTime_Scroll(object sender, EventArgs e)
        {
            // trackbar is logarithmical: value = log10(t) * 10; t = 10**(value/10)
            // Extra equality check here to avoid rounding screwups
            if (Convert.ToInt32(Math.Log10(_sample.Length)*10) != logTime.Value)
            {
                _sample.Length = Math.Pow(10, Convert.ToDouble(logTime.Value)/10);
            }
        }

        private void rate_CheckedChanged(object sender, EventArgs e)
        {
            var button = sender as RadioButton;
            if (button == null || button.Checked == false)
            {
                return;
            }
            // See if the custom rate option is selected, otherwise get the samplerate from the RadioButton's Tag.
            if (button == rateCustom)
            {
                CustomRate.Enabled = true;
                _sample.SampleRate = Convert.ToUInt32(CustomRate.Value);
            }
            else
            {
                CustomRate.Enabled = false;
                _sample.SampleRate = Convert.ToUInt32(button.Tag);
            }
        }

        private void CustomRate_ValueChanged(object sender, EventArgs e)
        {
            _sample.SampleRate = Convert.ToUInt32(CustomRate.Value);
        }

        private void SamplerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_player != null)
            {
                _player.Stop();
            }

            try
            {
                File.Delete(_tempfilename);
            }
            catch (IOException)
            {
              // IOException and UnauthoriedAccessException shouldn't happen, but may occur when someone's reading the 
            } // tempfile for whatever reason.
            catch (UnauthorizedAccessException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error while deleting temporary files");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_player != null)
            {
                _player.Stop();
            }
            _sample.SampleChanged -= sample_SampleChanged;
            MakeNewSample();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exportAudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (audioSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StoreWAV(audioSaveFileDialog.FileName, _sample);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SamplerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: Change this to save the waveform rather than audio once that works
            if (!_unsavedChanges) return;

            switch (MessageBox.Show("Do you want to save your changes?", "Sampler",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Yes:
                    if (audioSaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        StoreWAV(audioSaveFileDialog.FileName, _sample);
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                    break;
            }
        }
    }
}
