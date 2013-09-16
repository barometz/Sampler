using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampler
{
    // Seems like this might be more properly done with change notifiers
    public class SampleChangedEventArgs : EventArgs
    {
        public enum ChangeType { SampleRate, Length, BitDepth, Values }
        public ChangeType Type { get; private set; }
        public SampleChangedEventArgs(ChangeType type)
        {
            Type = type;
        }
    }

    public class Sample
    {
        /// <summary>
        /// Gets or sets the number of samples per second in Hz.
        /// </summary>
        public uint SampleRate 
        { 
            get 
            { 
                return samplerate; 
            }
            set
            {
                samplerate = value;
            }
        }
        /// <summary>
        /// Gets the time per sample in seconds.
        /// </summary>
        public double Resolution
        {
            get
            {
                return 1 / Convert.ToDouble(samplerate);
            }
        }
        /// <summary>
        /// Gets or sets the number of bits per sample (typically 8 or 16).
        /// </summary>
        public uint BitDepth 
        {
            get
            {
                return bitdepth;
            }
            set
            {
                if (value != bitdepth)
                {
                    bitdepth = value;
                    RaiseSampleChanged(SampleChangedEventArgs.ChangeType.BitDepth);
                }
                
            }
        }
        // TODO: Explain exactly how the rounding in Length happens and what the maxvalues are based on the backing types.
        /// <summary>
        /// Gets or sets the length of the sample in seconds.  Must be greater than zero.  
        /// 
        /// Setting this will change the sample count while keeping the sample rate constant.  Because those are
        /// integers, some rounding may occur.
        /// </summary>
        public double Length
        {
            get
            {
                return Convert.ToDouble(samplecount) / Convert.ToDouble(samplerate);
            }
            set
            {
                if (double.IsNaN(value) || double.IsInfinity(value))
                {
                    throw new ArgumentOutOfRangeException("Length", "Sample length has to be a real value, not NaN or Infinity.");
                }
                else if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Length", "Sample length must be greater than zero.");
                }
                else
                {
                    uint _samplecount = Convert.ToUInt32(value * samplerate);
                    if (_samplecount != samplecount)
                    {
                        samplecount = _samplecount;
                        RaiseSampleChanged(SampleChangedEventArgs.ChangeType.Length);
                    }
                }
            }
        }
        /// <summary>
        /// Gets or sets the number of samples in the entire sample.  When changed, <see cref="Sample.Length"/> changes 
        /// based on <see cref="Sample.SampleRate"/>.
        /// </summary>
        public uint SampleCount {
            get
            {
                return samplecount;
            }
            set
            {
                if (value != samplecount)
                {
                    samplecount = value;
                    RaiseSampleChanged(SampleChangedEventArgs.ChangeType.Length);
                }
            }
        }
        /// <summary>
        /// Gets or sets the function used to create the actual waveform.  Should take a time in milliseconds as its 
        /// argument. The results will be normalized to fit between <see cref="Sample.Minvalue"/> and 
        /// <see cref="Sample.UpperBound"/> inclusive.
        /// </summary>
        public Func<double, double> WaveFunction
        {
            get
            {
                return wavefunction;
            }
            set
            {
                if (value != wavefunction)
                {
                    wavefunction = value;
                    RaiseSampleChanged(SampleChangedEventArgs.ChangeType.Values);
                }
            }
        }

        /// <summary>
        /// Gets the highest possible value with the current BitsPerSample.
        /// </summary>
        public int UpperBound
        {
            get
            {
                return Convert.ToInt32(Math.Pow(2, BitDepth-1)) - 1;
            }
        }

        /// <summary>
        /// Gets the lowest possible value with the current BitsPerSample.
        /// </summary>
        public int LowerBound
        {
            get
            {
                // TODO: The +1 shouldn't be necessary, but for now fixes overflow issues at 16 bit
                return Convert.ToInt32(Math.Pow(2, BitDepth-1)) * -1 + 1;
            }
        }

        public event EventHandler<SampleChangedEventArgs> SampleChanged;

        private uint samplerate;
        private uint samplecount;
        private uint bitdepth;
        private double normalizingfactor;
        private Func<double, double> wavefunction;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="samplerate"></param>
        /// <param name="samplecount"></param>
        /// <param name="bitdepth"></param>
        /// <param name="waveform">The waveform function.  Defaults to a sine wave at 440 Hz.</param>
        public Sample(uint samplerate = 8363, uint samplecount = 64, uint bitdepth = 8, Func<double, double> waveform = null)
        {
            this.samplerate = samplerate;
            this.samplecount = samplecount;
            this.bitdepth = bitdepth;
            this.WaveFunction = waveform ?? (t => Math.Sin(t * 440 * 2 * Math.PI));
            SampleChanged += Sample_SampleChanged;
        }

        // TODO: This *will* break if the function is either positive or negative across the t-domain
        void Sample_SampleChanged(object sender, SampleChangedEventArgs e)
        {
            double bottomoverflow = LowerBound - MinValue();
            double topoverflow = MaxValue() - UpperBound;

            if (bottomoverflow > topoverflow)
            {
                normalizingfactor = Math.Abs(LowerBound / (LowerBound - bottomoverflow));
            }
            else
            {
                normalizingfactor = UpperBound / (UpperBound + topoverflow);
            }
        }

        private void RaiseSampleChanged(SampleChangedEventArgs.ChangeType type)
        {
            var handler = SampleChanged;
            if (handler != null)
            {
                handler(this, new SampleChangedEventArgs(type));
            }
        }

        /// <summary>
        /// Returns the lowest non-normalized value in WaveFunction(t) for 0 &lt;= t &lt;= <see cref="Sample.Length"/>.
        /// </summary>
        /// <returns></returns>
        private double MinValue()
        {
            double minvalue = UpperBound;
            for (uint i = 0; i < SampleCount; i++)
            {
                if (WaveFunction(i * Resolution) < minvalue)
                {
                    minvalue = WaveFunction(i * Resolution);
                }
            }
            return minvalue;
        }

        /// <summary>
        /// Returns the highest non-normalized value in WaveFunction(t) for 0 &lt;= t &lt;= <see cref="Sample.Length"/>.
        /// </summary>
        /// <returns></returns>
        private double MaxValue()
        {
            double maxvalue = LowerBound;
            for (uint i = 0; i < SampleCount; i++)
            {
                if (WaveFunction(i * Resolution) > maxvalue)
                {
                    maxvalue = WaveFunction(i * Resolution);
                }
            }
            return maxvalue;
        }

        /// <summary>
        /// Get the value at a given time.
        /// </summary>
        /// <param name="t">A time between 0 and <see cref="Sample.Length"/> in seconds.</param>
        /// <returns>The value at <paramref name="t"/>, guaranteed to be between <see cref="Sample.Minvalue"/> and 
        /// <see cref="Sample.UpperBound"/> inclusive.</returns>
        public double ValueAt(double t)
        {
            return WaveFunction(t) * normalizingfactor;
        }
    }
}
