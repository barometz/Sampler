using System;
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

        public SamplerForm()
        {
            InitializeComponent();
            sample = new Sample();
            sample.SampleChanged += sample_SampleChanged;
            Length.Minimum = Convert.ToDecimal(sample.Resolution * 1000);
            sample.SampleCount = 16;
            ParseToSample(FormulaBox.Text);
        }

        Func<double, double> GetMethod(EvalContext context, EvalExpression<double, EvalContext> expr)
        {
            Func<double, double> ret = delegate(double t)
            {
                context.t = t;
                return expr(context);
            };
            return ret;
        }

        void ParseToSample(string text)
        {
            IExpressionEvaluator eval = new ExpressionEvaluator(ExpressionEval.MethodState.ExpressionLanguage.CSharp);
            EvalContext context = new EvalContext();
            context.S = sample;
            EvalExpression<double, EvalContext> expression = eval.GetDelegate<double, EvalContext>(text);
            sample.WaveFunction = GetMethod(context, expression);
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
                    Length.Value = Convert.ToDecimal(sample.Length * 1000);
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

        private void Visualize_Click(object sender, EventArgs e)
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

        private void Length_ValueChanged(object sender, EventArgs e)
        {
            if (sender as NumericUpDown != null)
            {
                sample.Length = Convert.ToDouble((sender as NumericUpDown).Value / 1000);
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            var wav = new EricOulashin.WAVFile();
            // TODO: Sample.BitDepth op 8/16 clampen
            wav.Create("temp.wav", false, (int)sample.SampleRate, (short)sample.BitDepth, true);
            if (sample.BitDepth == 8)
            {
                for (int i = 0; i < sample.SampleCount; i++)
                {
                    wav.AddSample_8bit((byte)(sample.ValueAt(i * sample.Resolution) + 128));
                }
                wav.Close();
            }
            else
            {
                for (int i = 0; i < sample.SampleCount; i++)
                {
                    wav.AddSample_16bit((short)sample.ValueAt(i * sample.Resolution));
                }
                wav.Close();
            }
            player = new SoundPlayer("temp.wav");
            player.PlayLooping();

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (player != null) player.Stop();
        }
    }
}
