using System;

namespace Sampler
{
    /// <summary>
    /// Evaluation context for the method extracted by the ExpressionEvaluator.  Contains a reference to the Sample 
    /// instance so functions can use e.g. Sample.Resolution as well as the time for which to calculate things.
    /// 
    /// Contains a number of methods that can be used to construct waveforms and are available in the function text.
    /// All of them should have -1..1 inclusive as their range and take a time parameter.  The periodic ones also take
    /// a frequency parameter.
    /// 
    /// As a bonus it contains the frequencies of C5 to B5 as C, Cs, D, Ds etcetera.
    /// </summary>
    public class EvalContext
    {
        public Sample S { get; set; }
        public double t { get; set; }

        public const double C = 523.251;
        public const double Cs = 554.365;
        public const double D = 587.330;
        public const double Ds = 622.254;
        public const double E = 659.255;
        public const double F = 698.456;
        public const double Fs = 739.989;
        public const double G = 783.991;
        public const double Gs = 830.609;
        public const double A = 880.000;
        public const double As = 932.328;
        public const double B = 987.767;

        /// <summary>
        /// Calculate a value on a sine wave.
        /// </summary>
        /// <param name="t">The time in seconds.</param>
        /// <param name="frequency">The frequency of the wave.</param>
        /// <returns></returns>
        public double sin(double t, double frequency)
        {
            return Math.Sin(t * frequency * 2 * Math.PI);
        }

        /// <summary>
        /// Calculate a value on a triangle wave.
        /// </summary>
        /// <param name="t">The time in seconds.</param>
        /// <param name="frequency">The frequency of the wave.</param>
        /// <returns></returns>
        public double triangle(double t, double frequency)
        {
            double period = 1 / frequency;
            // TODO: Make this less of a horror
            return (Math.Abs((t + 0.75 * period) % period - (period / 2)) - period / 4) / (period / 4);
        }

        /// <summary>
        /// Calculate a value on a sawtooth wave.
        /// </summary>
        /// <param name="t">The time in seconds.</param>
        /// <param name="frequency">The frequency of the wave.</param>
        /// <returns></returns>
        public double sawtooth(double t, double frequency)
        {
            double period = 1 / frequency;
            return 2 * (t / period - Math.Floor(0.5 + t / period));
        }

        /// <summary>
        /// Calculate a value on a square wave.
        /// </summary>
        /// <param name="t">The time in seconds.</param>
        /// <param name="frequency">The frequency of the wave.</param>
        /// <returns></returns>
        public double square(double t, double frequency)
        {
            double period = 1 / frequency;
            if (t % period > period / 2)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Generate noise.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public double noise(double t)
        {
            // http://libnoise.sourceforge.net/noisegen/index.html
            int val = Convert.ToInt32(1000 * t);
            val = (val >> 13) ^ val;
            int nn = (val * (val * val * 60493 + 19990303) + 1376312589) & 0x7FFFFFFF;
            return 1 - ((double)nn / 1073741823);
        }
    }
}
