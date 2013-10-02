using System;
using System.Windows.Forms;

namespace Sampler
{
    /// <summary>
    /// Shows the user an error message together with some details about the exception that caused it.  This way you don't get the "UNHANDLED EXCEPTION ZOMG" but still get some information to pass on in a bugreport.
    /// </summary>
    public partial class ExceptionBox : Form
    {
        private bool _details = true;

        public ExceptionBox(string message, Exception ex)
        {
            InitializeComponent();
            Message.Text = message;
            Details.Text = ex.Message;
            if (ex.InnerException != null)
            {
                Details.Text += "\n\n";
                Details.Text += ex.InnerException.Message;
            }
            ToggleDetails();
        }

        private void ToggleDetails()
        {
            _details = !_details;
            if (_details)
            {
                Details.Visible = true;
                DetailsToggle.Text = "Hide &details...";
            }
            else
            {
                Details.Visible = false;
                DetailsToggle.Text = "Show &details...";
            }
        }

        private void DetailsToggle_Click(object sender, EventArgs e)
        {
            ToggleDetails();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
