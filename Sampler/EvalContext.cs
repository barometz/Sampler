using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampler
{
    public class EvalContext
    {
        public Sample S { get; set; }
        public double t { get; set; }

        public EvalContext()
        {

        }

        public double Sine(double t, double frequency)
        {
            return Math.Sin(t * frequency * 2 * Math.PI);
        }

        public double Triangle(double t, double frequency)
        {
            double period = 1 / frequency;
            // TODO: Make this less of a horror
            return (Math.Abs((t + 0.75 * period) % period - (period / 2)) - period / 4) / (period / 4);
        }

        public double Sawtooth(double t, double frequency)
        {
            double period = 1 / frequency;
            return 2 * (t / period - Math.Floor(0.5 + t / period));
        }

        public double Square(double t, double frequency)
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

        public double Noise(double t)
        {
            // http://libnoise.sourceforge.net/noisegen/index.html
            int val = Convert.ToInt32(1000 * t);
            val = (val >> 13) ^ val;
            int nn = (val * (val * val * 60493 + 19990303) + 1376312589) & 0x7FFFFFFF;
            return 1 - ((double)nn / 1073741823);
        }
    }
}
