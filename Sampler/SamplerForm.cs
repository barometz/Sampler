using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EricOulashin;
using System.Media;
using ExpressionEval.ExpressionEvaluation;

namespace Sampler
{
    public partial class SamplerForm : Form
    {
        Sample sample;
        SoundPlayer player;
        string tempfilename;

        public SamplerForm()
        {
            InitializeComponent();
            sample = new Sample();
            sample.SampleChanged += sample_SampleChanged;
            Time.Minimum = Convert.ToDecimal(sample.Resolution * 1000);
            sample.SampleCount = 16;
            ParseToSample(FormulaBox.Text);

            rate8000.Tag = 8000;
            rate8363.Tag = 8363;
            rate11k.Tag = 11025;
            rate22k.Tag = 22050;
            rate44k.Tag = 44100;

            tempfilename = Path.GetTempFileName();
        }

        private Func<double, double> GetMethod(EvalContext context, EvalExpression<double, EvalContext> expr)
        {
            Func<double, double> ret = delegate(double t)
            {
                context.t = t;
                return expr(context);
            };
            return ret;
        }

        /// <summary>
        /// Turn a function string ("sin(t, C)") into a Func&lt;double, double&gt; and pass that to the sample.
        /// </summary>
        /// <param name="text"></param>
        private void ParseToSample(string text)
        {
            IExpressionEvaluator eval = new ExpressionEvaluator(ExpressionEval.MethodState.ExpressionLanguage.CSharp);
            EvalContext context = new EvalContext();
            context.S = sample;
            EvalExpression<double, EvalContext> expression = eval.GetDelegate<double, EvalContext>(text);
            sample.WaveFunction = GetMethod(context, expression);
        }

        /// <summary>
        /// Store the provided sample at the specified location.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="sample"></param>
        private void storeWAV(string filename, Sample sample)
        {
            var wav = new WAVFile();
            // TODO: Clamp Sample.BitDepth to 8/16 (or not?)
            wav.Create(filename, false, (int)sample.SampleRate, (short)sample.BitDepth, true);
            if (sample.BitDepth == 8)
            {
                for (int i = 0; i < sample.SampleCount; i++)
                {
                    // Need to add 128 because AddSample_8bit takes unsigned bytes.
                    wav.AddSample_8bit((byte)(sample.ValueAt(i * sample.Resolution) + 128));
                }
            }
            else // Assume 16-bit for now.
            {
                for (int i = 0; i < sample.SampleCount; i++)
                {
                    wav.AddSample_16bit((short)sample.ValueAt(i * sample.Resolution));
                }
            }
            wav.Close();
        }

        void sample_SampleChanged(object sender, SampleChangedEventArgs e)
        {
            sample = sender as Sample;
            if (sample == null)
            {
                return;
            }

            switch (e.Type)
            {
                case SampleChangedEventArgs.ChangeType.BitDepth:
                    if (sample.BitDepth == 8)
                    {
                        BitDepth8.Checked = true;
                    }
                    else if (sample.BitDepth == 16)
                    {
                        BitDepth16.Checked = true;
                    }
                    break;
                case SampleChangedEventArgs.ChangeType.Length:
                    Time.Minimum = Convert.ToDecimal(sample.Resolution * 1000);
                    Time.Value = Convert.ToDecimal(sample.Length * 1000);
                    SampleCount.Value = sample.SampleCount;
                    logTime.Value = Convert.ToInt32(Math.Log10(sample.Length) * 10);
                    break;
                case SampleChangedEventArgs.ChangeType.SampleRate:
                    SampleCount.Value = sample.SampleCount;
                    break;
            }

            SampleChart.ChartAreas[0].AxisX.Maximum = sample.Length * 1000;
            SampleChart.ChartAreas[0].AxisY.Minimum = sample.LowerBound - 1;
            SampleChart.ChartAreas[0].AxisY.Maximum = sample.UpperBound;
            // Getting the gridlines right on a Chart is a bit of a pain 
            SampleChart.ChartAreas[0].AxisY.Interval = (sample.LowerBound - 2) / -2;

            SampleChart.Series[0].Points.Clear();
            for (int i = 0; i < sample.SampleCount; i++)
            {
                SampleChart.Series[0].Points.AddXY(i * 1000 * sample.Resolution, sample.ValueAt(i * sample.Resolution));
            }
            // Get at most ten tickmarks on the X-axis. 
            SampleChart.ChartAreas[0].AxisX.Interval = Math.Pow(10, Math.Floor(Math.Log10(sample.Length * 1000)));
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
                sample.BitDepth = 8;
            }
            else if (sender as RadioButton == BitDepth16)
            {
                sample.BitDepth = 16;
            }
        }

        private void SampleCount_ValueChanged(object sender, EventArgs e)
        {
            if (sender as NumericUpDown != null) 
            {
                sample.SampleCount = Convert.ToUInt32((sender as NumericUpDown).Value);
            }
        }

        private void Time_ValueChanged(object sender, EventArgs e)
        {
            if (sender as NumericUpDown != null)
            {
                sample.Length = Convert.ToDouble((sender as NumericUpDown).Value / 1000);
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            storeWAV(tempfilename, sample);
            player = new SoundPlayer(tempfilename);
            if (Loop.Checked)
            {
                player.PlayLooping();
            }
            else
            {
                player.Play();
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                player.Stop();
            }
        }

        private void logTime_Scroll(object sender, EventArgs e)
        {
            // trackbar is logarithmical: value = log10(t) * 10; t = 10**(value/10)
            // Extra equality check here to avoid rounding screwups
            if (Convert.ToInt32(Math.Log10(sample.Length) * 10) != logTime.Value)
            {
                sample.Length = Math.Pow(10, Convert.ToDouble(logTime.Value) / 10);
            }
        }

        private void rate_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = sender as RadioButton;
            if (button == null || button.Checked == false)
            {
                return;
            }
            // See if the custom rate option is selected, otherwise get the samplerate from the RadioButton's Tag.
            if (button == rateCustom)
            {
                CustomRate.Enabled = true;
                sample.SampleRate = Convert.ToUInt32(CustomRate.Value);
            }
            else
            {
                CustomRate.Enabled = false;
                sample.SampleRate = Convert.ToUInt32(button.Tag);
            }
        }

        private void CustomRate_ValueChanged(object sender, EventArgs e)
        {
            sample.SampleRate = Convert.ToUInt32(CustomRate.Value);
        }

        private void SamplerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (player != null)
            {
                player.Stop();
            }

            try
            {
                File.Delete(tempfilename);
            }
            catch (Exception ex)
            {
                // meh
            }
        }
    }
}
