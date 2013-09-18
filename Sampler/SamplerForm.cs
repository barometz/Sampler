using System;
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
        private readonly string _tempfilename;
        private SoundPlayer _player;
        private Sample _sample;

        public SamplerForm()
        {
            InitializeComponent();
            _sample = new Sample();
            _sample.SampleChanged += sample_SampleChanged;
            Time.Minimum = Convert.ToDecimal(_sample.Resolution*1000);
            _sample.SampleCount = 16;
            ParseToSample(FormulaBox.Text);

            rate8000.Tag = 8000;
            rate8363.Tag = 8363;
            rate11k.Tag = 11025;
            rate22k.Tag = 22050;
            rate44k.Tag = 44100;

            _tempfilename = Path.GetTempFileName();
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
        ///     Turn a function string ("sin(t, C)") into a Func&lt;double, double&gt; and pass that to the sample.
        /// </summary>
        /// <param name="text"></param>
        private void ParseToSample(string text)
        {
            IExpressionEvaluator eval = new ExpressionEvaluator(ExpressionLanguage.CSharp);
            var context = new EvalContext {S = _sample};
            EvalExpression<double, EvalContext> expression = eval.GetDelegate<double, EvalContext>(text);
            _sample.WaveFunction = GetMethod(context, expression);
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
            _sample = sender as Sample;
            if (_sample == null)
            {
                return;
            }

            switch (e.Type)
            {
                case SampleChangedEventArgs.ChangeType.BitDepth:
                    if (_sample.BitDepth == 8)
                    {
                        BitDepth8.Checked = true;
                    }
                    else if (_sample.BitDepth == 16)
                    {
                        BitDepth16.Checked = true;
                    }
                    break;
                case SampleChangedEventArgs.ChangeType.Length:
                    Time.Minimum = Convert.ToDecimal(_sample.Resolution*1000);
                    Time.Value = Convert.ToDecimal(_sample.Length*1000);
                    SampleCount.Value = _sample.SampleCount;
                    logTime.Value = Convert.ToInt32(Math.Log10(_sample.Length)*10);
                    break;
                case SampleChangedEventArgs.ChangeType.SampleRate:
                    SampleCount.Value = _sample.SampleCount;
                    break;
            }

            SampleChart.ChartAreas[0].AxisX.Maximum = _sample.Length*1000;
            SampleChart.ChartAreas[0].AxisY.Minimum = _sample.LowerBound - 1;
            SampleChart.ChartAreas[0].AxisY.Maximum = _sample.UpperBound;
            // Getting the gridlines right on a Chart is a bit of a pain 
            SampleChart.ChartAreas[0].AxisY.Interval = (_sample.LowerBound - 2)/-2.0;

            SampleChart.Series[0].Points.Clear();
            for (int i = 0; i < _sample.SampleCount; i++)
            {
                SampleChart.Series[0].Points.AddXY(i*1000*_sample.Resolution, _sample.ValueAt(i*_sample.Resolution));
            }
            // Get at most ten tickmarks on the X-axis. 
            SampleChart.ChartAreas[0].AxisX.Interval = Math.Pow(10, Math.Floor(Math.Log10(_sample.Length*1000)));
        }

        private void ApplyFunction_Click(object sender, EventArgs e)
        {
            try
            {
                ParseToSample(FormulaBox.Text);
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
            {  // IOException and UnauthoriedAccessException shouldn't happen, but may occur when someone's reading the 
            }  // tempfile for whatever reason.
            catch (UnauthorizedAccessException)
            {
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error while deleting temporary files");
            }
        }
    }
}