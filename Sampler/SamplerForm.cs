using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using EricOulashin;
using Sampler.Properties;

namespace Sampler
{
    public partial class SamplerForm : Form
    {
        private readonly Dictionary<uint, RadioButton> _defaultRates;
        private readonly string _tempfilename;
        private SoundPlayer _player;
        private Sample _sample;
        private bool _unsavedChanges;

        public SamplerForm()
        {
            // TODO: Figure out what's slowing down form loading (probably drawing the chart) and move it to a background worker
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

            LoadSample(new Sample());

            _tempfilename = Path.GetTempFileName();
        }

        /// <summary>
        ///     Set the provided sample as current and update the UI to match it.
        /// </summary>
        private void LoadSample(Sample sample)
        {
            _sample = sample;
            UpdateTimeUI();
            UpdateBitdepthUI();
            UpdateSampleRateUI();
            UpdateChart();
            FormulaBox.Text = _sample.WaveFunction;
            _sample.SampleChanged += sample_SampleChanged;
            _unsavedChanges = false;
        }

        /// <summary>
        /// Pulls up an ExceptionBox with the specified message.
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="format">To be passed to String.Format.</param>
        /// <param name="args">The arguments for the format string (if any).</param>
        private static void FormatAndShowException(Exception ex, String format, params object[] args)
        {
            var message = String.Format(format, args);
            new ExceptionBox(message, ex).ShowDialog();
        }

        /// <summary>
        ///     Pop up a save dialog and try to save the current _sample.
        /// </summary>
        /// <returns>The result of the save dialog, or <see cref="DialogResult.Cancel" /> when an exception occurred.</returns>
        /// <remarks>
        ///     Handling the exception here rather than passing it on the the caller doesn't seem quite right, but limits code
        ///     duplication.
        /// </remarks>
        private DialogResult SaveSample()
        {
            DialogResult result = sampleSaveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    // TODO: More detailed information in sample saving error message
                    SampleStorage.Save(sampleSaveFileDialog.FileName, _sample);
                }
                catch (Exception ex)
                {
                    FormatAndShowException(ex, Resources.Could_not_save_sample_to, sampleSaveFileDialog.FileName);
                    return DialogResult.Cancel;
                }
            }
            return result;
        }

        private void DiscardCurrentSample()
        {
            if (_player != null)
            {
                _player.Stop();
            }
            _sample.SampleChanged -= sample_SampleChanged;
        }

        /// <summary>
        ///     Store a wavfile generated from the provided sample at the specified location.
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
                    UpdateBitdepthUI();
                    break;
                case SampleChangedEventArgs.ChangeType.Length:
                    UpdateTimeUI();
                    break;
                case SampleChangedEventArgs.ChangeType.SampleRate:
                    UpdateTimeUI();
                    UpdateSampleRateUI();
                    break;
            }

            UpdateChart();

            _unsavedChanges = true;
        }

        private void UpdateChart()
        {
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

        private void UpdateBitdepthUI()
        {
            if (_sample.BitDepth == 8)
            {
                BitDepth8.Checked = true;
            }
            else if (_sample.BitDepth == 16)
            {
                BitDepth16.Checked = true;
            }
        }

        /// <summary>
        ///     Update the radiobuttons and/or custom value for the sample rate.
        /// </summary>
        private void UpdateSampleRateUI()
        {
            if (CustomRate.Value == _sample.SampleRate)
            {
                rateCustom.Checked = true;
            }
            else if (_defaultRates.ContainsKey(_sample.SampleRate))
            {
                _defaultRates[_sample.SampleRate].Checked = true;
            }
            else
            {
                rateCustom.Checked = true;
                CustomRate.Value = _sample.SampleRate;
            }
        }

        /// <summary>
        ///     Sets the limits of the time controls according to the resolution of the sample and
        ///     their values according to its length.
        /// </summary>
        private void UpdateTimeUI()
        {
            Time.Minimum = Convert.ToDecimal(_sample.Resolution*1000);
            Time.Increment = Convert.ToDecimal(_sample.Resolution*1000);
            logTime.Minimum = Convert.ToInt32(Math.Log10(_sample.Resolution)*10);

            Time.Value = Convert.ToDecimal(_sample.Length*1000);
            SampleCount.Value = _sample.SampleCount;
            logTime.Value = Convert.ToInt32(Math.Log10(_sample.Length)*10);
        }

        #region UI event handlers

        private void ApplyFunction_Click(object sender, EventArgs e)
        {
            try
            {
                _sample.WaveFunction = FormulaBox.Text;
            }
            catch (ArgumentException ex)
            {
                FormatAndShowException(ex, Resources.This_does_not_appear_to_be_a_valid_function, FormulaBox.Text);
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
            // IOException and UnauthoriedAccessException shouldn't happen, but may occur when someone's reading the 
            // tempfile for whatever reason.  No need to worry about those.
            catch (IOException)
            {
            } 
            catch (UnauthorizedAccessException)
            {
            }
            catch (Exception ex)
            {
                FormatAndShowException(ex, Resources.Error_while_deleting_temporary_audio_file_at, _tempfilename);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiscardCurrentSample();
            LoadSample(new Sample());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openSampleDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // TODO: May want to separately handle a failure in LoadSample, although there's not much that could go wrong
                    Sample sample = SampleStorage.Load(openSampleDialog.FileName);
                    DiscardCurrentSample();
                    LoadSample(sample);
                }
                catch (Exception ex)
                {
                    FormatAndShowException(ex, Resources.Could_not_open_sample_file_at, openSampleDialog.FileName);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveSample();
        }

        private void exportAudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (audioSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // TODO: More detailed information in audio export error message
                    // TODO: Add option to open audio after saving?  No idea how.
                    StoreWAV(audioSaveFileDialog.FileName, _sample);
                }
                catch (Exception ex)
                {
                    FormatAndShowException(ex, Resources.Could_not_export_audio_to, audioSaveFileDialog.FileName);
                }
            }
        }

        private void exportGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: More detailed information in image save error message
            // TODO: Add option to open image after saving?  No idea how.
            if (chartSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    switch (chartSaveFileDialog.FilterIndex)
                    {
                        case 1:
                            SampleChart.SaveImage(chartSaveFileDialog.FileName, ChartImageFormat.Png);
                            break;
                        case 2:
                            SampleChart.SaveImage(chartSaveFileDialog.FileName, ChartImageFormat.Bmp);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    FormatAndShowException(ex, Resources.Could_not_export_chart_image_to, chartSaveFileDialog.FileName);
                }
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SamplerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_unsavedChanges) return;

            switch (MessageBox.Show(Resources.Do_you_want_to_save_your_changes_, Application.ProductName,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Yes:
                    if (SaveSample() != DialogResult.OK)
                    {
                        e.Cancel = true;
                    }
                    break;
            }
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string execlocation = Assembly.GetExecutingAssembly().Location;
                string basepath = Path.GetDirectoryName(execlocation);
                Process.Start(Path.Combine(basepath, "Help/index.html"));
            }
            catch (FileNotFoundException ex)
            {
                FormatAndShowException(ex, Resources.Help_files_not_available);
            }
            catch (ArgumentNullException ex)
            {
                FormatAndShowException(ex, Resources.Error_while_retrieving_the_programs_base_path);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        #endregion
    }
}