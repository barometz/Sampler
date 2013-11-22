using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Sampler.Properties;

namespace Sampler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Resources.Culture = new CultureInfo("nl-NL");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SamplerForm());
        }
    }
}
