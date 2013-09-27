using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Sampler
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            Text = String.Format("About {0}", AssemblyTitle);
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            labelCopyright.Text = AssemblyCopyright;
            weblink.Links[0].LinkData = "https://github.com/barometz/Sampler";
            linkExpressionEval.Links[0].LinkData =
                "http://www.codeproject.com/Articles/18004/Net-Expression-Evaluator-using-DynamicMethod";
            linkWAVFile.Links[0].LinkData =
                "http://www.codeproject.com/Articles/35725/C-WAV-file-class-audio-mixing-and-some-light-audio";
            splitContainer1.Panel2Collapsed = true;
            Width = Width - LicenseText.Width;

            try
            {
                string execlocation = Assembly.GetExecutingAssembly().Location;
                string basepath = Path.GetDirectoryName(execlocation);
                LicenseText.Text = File.ReadAllText(Path.Combine(basepath, "LICENSE.md"));
            }
            catch (Exception ex)
            {
                LicenseText.Text = "Could not open LICENSE.md: \n" + ex.Message;
            }
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    var titleAttribute = (AssemblyTitleAttribute) attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version.ToString(); }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute) attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute) attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute) attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes =
                    Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute) attributes[0]).Company;
            }
        }

        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var target = e.Link.LinkData as string;
            if (target != null)
            {
                Process.Start(target);
            }
        }

        private void toggleLicenseText_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed)
            {
                Width = Width + LicenseText.Width + 4;
                splitContainer1.Panel2Collapsed = false;
                toggleLicenseText.Text = "Hide license details <<";
            }
            else
            {
                splitContainer1.Panel2Collapsed = true;
                Width = Width - LicenseText.Width - 4;
                toggleLicenseText.Text = "Show license details >>";
            }
        }
    }
}