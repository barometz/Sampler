using System;
using ExpressionEval.ExpressionEvaluation;
using ExpressionEval.MethodState;

namespace Sampler
{
    // Seems like this might be more properly done with change notifiers
    public class SampleChangedEventArgs : EventArgs
    {
        public enum ChangeType
        {
            SampleRate,
            Length,
            BitDepth,
            Values
        }

        public SampleChangedEventArgs(ChangeType type)
        {
            Type = type;
        }

        public ChangeType Type { get; private set; }
    }

    public class Sample
    {
        private uint _bitdepth;
        private double _normalizingfactor;
        private uint _samplecount;
        private uint _samplerate;
        private string _wavefunction;
        private Func<double, double> _compiledfunction;

        /// <summary>
        /// </summary>
        /// <param name="samplerate"></param>
        /// <param name="samplecount"></param>
        /// <param name="bitdepth"></param>
        /// <param name="waveform">The waveform function.  Defaults to a sine wave at C5.</param>
        public Sample(uint samplerate = 8363, uint samplecount = 16, uint bitdepth = 8,
            string waveform = "sin(t, C)")
        {
            _samplerate = samplerate;
            _samplecount = samplecount;
            _bitdepth = bitdepth;
            WaveFunction = waveform;
        }

        /// <summary>
        ///     Gets or sets the number of samples per second in Hz, while keeping the length in seconds constant and adjusting the
        ///     sample count.
        /// </summary>
        public uint SampleRate
        {
            get { return _samplerate; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Sample rate cannot be 0.");
                }
                if (value != _samplerate)
                {
                    double ratio = Convert.ToDouble(value)/_samplerate;
                    _samplerate = value;
                    RaiseSampleChanged(SampleChangedEventArgs.ChangeType.SampleRate);
                    // Adjust the sample count so the Length in seconds remains the same
                    SampleCount = Convert.ToUInt32(SampleCount*ratio);
                }
            }
        }

        /// <summary>
        ///     Gets the time per sample in seconds.
        /// </summary>
        public double Resolution
        {
            get { return 1/Convert.ToDouble(_samplerate); }
        }

        /// <summary>
        ///     Gets or sets the number of bits per sample (typically 8 or 16).
        /// </summary>
        public uint BitDepth
        {
            get { return _bitdepth; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Bit depth cannot be 0.");
                }
                if (value != _bitdepth)
                {
                    _bitdepth = value;
                    SetNormalizingFactor();
                    RaiseSampleChanged(SampleChangedEventArgs.ChangeType.BitDepth);
                }
            }
        }

        // TODO: Explain exactly how the rounding in Length happens and what the maxvalues are based on the backing types.
        /// <summary>
        ///     Gets or sets the length of the sample in seconds.  Must be greater than zero.
        ///     Setting this will change the sample count while keeping the sample rate constant.  Because those are
        ///     integers, some rounding may occur.
        /// </summary>
        public double Length
        {
            get { return Convert.ToDouble(_samplecount)/Convert.ToDouble(_samplerate); }
            set
            {
                if (double.IsNaN(value) || double.IsInfinity(value))
                {
                    throw new ArgumentOutOfRangeException("value",
                        "Sample length has to be a real value, not NaN or Infinity.");
                }

                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Sample length must be greater than zero.");
                }

                uint samplecount = Convert.ToUInt32(value*_samplerate);
                if (samplecount != _samplecount)
                {
                    _samplecount = samplecount;
                    SetNormalizingFactor();
                    RaiseSampleChanged(SampleChangedEventArgs.ChangeType.Length);
                }
            }
        }

        /// <summary>
        ///     Gets or sets the number of samples in the entire sample.  When changed, <see cref="Sample.Length" /> changes
        ///     based on <see cref="Sample.SampleRate" />.
        /// </summary>
        public uint SampleCount
        {
            get { return _samplecount; }
            set
            {
                if (value != _samplecount)
                {
                    _samplecount = value;
                    SetNormalizingFactor();
                    RaiseSampleChanged(SampleChangedEventArgs.ChangeType.Length);
                }
            }
        }

        /// <summary>
        ///     Gets or sets the function used to create the actual waveform.  Should take a time in milliseconds as its
        ///     argument. The results will be normalized to fit between <see cref="Sample.MinValue" /> and
        ///     <see cref="Sample.UpperBound" /> inclusive.
        /// </summary>
        public string WaveFunction
        {
            get { return _wavefunction; }
            set
            {
                if (value != _wavefunction)
                {
                    try
                    {
                        CompileFunction(value);
                        _wavefunction = value;
                        SetNormalizingFactor();
                        RaiseSampleChanged(SampleChangedEventArgs.ChangeType.Values);
                    }
                    catch (ApplicationException ex)
                    {
                        throw new ArgumentException("Could not compile the provided function.", ex);
                    }
                }
            }
        }

        /// <summary>
        ///     Gets the highest possible value with the current BitsPerSample.
        /// </summary>
        public int UpperBound
        {
            get { return Convert.ToInt32(Math.Pow(2, BitDepth - 1)) - 1; }
        }

        /// <summary>
        ///     Gets the lowest possible value with the current BitsPerSample.
        /// </summary>
        public int LowerBound
        {
            get
            {
                // TODO: The +1 shouldn't be necessary, but for now fixes overflow issues at 16 bit
                return Convert.ToInt32(Math.Pow(2, BitDepth - 1))*-1 + 1;
            }
        }

        /// <summary>
        ///     Occurs when the sample has changed in some way.  <see cref="SampleChangedEventArgs.ChangeType" /> indicates what
        ///     has changed.
        /// </summary>
        public event EventHandler<SampleChangedEventArgs> SampleChanged;

        // TODO: This *will* break if the function is either positive or negative across the t-domain
        private void SetNormalizingFactor()
        {
            double bottomoverflow = LowerBound - MinValue();
            double topoverflow = MaxValue() - UpperBound;

            if (bottomoverflow > topoverflow)
            {
                _normalizingfactor = Math.Abs(LowerBound/(LowerBound - bottomoverflow));
            }
            else
            {
                _normalizingfactor = UpperBound/(UpperBound + topoverflow);
            }
        }

        private void RaiseSampleChanged(SampleChangedEventArgs.ChangeType type)
        {
            EventHandler<SampleChangedEventArgs> handler = SampleChanged;
            if (handler != null)
            {
                handler(this, new SampleChangedEventArgs(type));
            }
        }

        /// <summary>
        ///     Returns the lowest non-normalized value in WaveFunction(t) for 0 &lt;= t &lt;= <see cref="Sample.Length" />.
        /// </summary>
        /// <returns></returns>
        private double MinValue()
        {
            double minvalue = UpperBound;
            for (uint i = 0; i < SampleCount; i++)
            {
                if (_compiledfunction(i*Resolution) < minvalue)
                {
                    minvalue = _compiledfunction(i*Resolution);
                }
            }
            return minvalue;
        }

        /// <summary>
        ///     Returns the highest non-normalized value in WaveFunction(t) for 0 &lt;= t &lt;= <see cref="Sample.Length" />.
        /// </summary>
        /// <returns></returns>
        private double MaxValue()
        {
            double maxvalue = LowerBound;
            for (uint i = 0; i < SampleCount; i++)
            {
                if (_compiledfunction(i*Resolution) > maxvalue)
                {
                    maxvalue = _compiledfunction(i*Resolution);
                }
            }
            return maxvalue;
        }

        /// <summary>
        ///     Get the value at a given time.
        /// </summary>
        /// <param name="t">A time between 0 and <see cref="Sample.Length" /> in seconds.</param>
        /// <returns>
        ///     The value at <paramref name="t" />, guaranteed to be between <see cref="Sample.MinValue" /> and
        ///     <see cref="Sample.UpperBound" /> inclusive.
        /// </returns>
        public double ValueAt(double t)
        {
            return _compiledfunction(t)*_normalizingfactor;
        }

        /// <summary>
        ///     Since an EvalExpression can't take any parameters but takes all its information from its evaluation context object
        ///     we'll need a wrapper to create a convenient Func&lt;double, double&gt; to use for the calculations.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="expr"></param>
        /// <returns></returns>
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
        ///     Compile a function string ("sin(t, C)") into a Func&lt;double, double&gt;, connect it with the sample and store it.
        /// </summary>
        /// <param name="text">A string that represents a function that can be used to generate a waveform.</param>
        private void CompileFunction(string text)
        {
            IExpressionEvaluator eval = new ExpressionEvaluator(ExpressionLanguage.CSharp);
            var context = new EvalContext { S = this };
            EvalExpression<double, EvalContext> expression = eval.GetDelegate<double, EvalContext>(text);
            _compiledfunction = GetMethod(context, expression);
        }

    }
}