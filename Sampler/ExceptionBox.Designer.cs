namespace Sampler
{
    partial class ExceptionBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Message = new System.Windows.Forms.Label();
            this.Details = new System.Windows.Forms.TextBox();
            this.DetailsToggle = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.Dock = System.Windows.Forms.DockStyle.Top;
            this.Message.Location = new System.Drawing.Point(0, 0);
            this.Message.Name = "Message";
            this.Message.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.Message.Size = new System.Drawing.Size(524, 91);
            this.Message.TabIndex = 0;
            this.Message.Text = "An error has occurred.";
            this.Message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Details
            // 
            this.Details.Location = new System.Drawing.Point(12, 127);
            this.Details.Multiline = true;
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Details.Size = new System.Drawing.Size(500, 334);
            this.Details.TabIndex = 1;
            this.Details.TabStop = false;
            // 
            // DetailsToggle
            // 
            this.DetailsToggle.AutoSize = true;
            this.DetailsToggle.Location = new System.Drawing.Point(12, 94);
            this.DetailsToggle.Name = "DetailsToggle";
            this.DetailsToggle.Size = new System.Drawing.Size(109, 27);
            this.DetailsToggle.TabIndex = 3;
            this.DetailsToggle.Text = "Show &details...";
            this.DetailsToggle.UseVisualStyleBackColor = true;
            this.DetailsToggle.Click += new System.EventHandler(this.DetailsToggle_Click);
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.AutoSize = true;
            this.OK.Location = new System.Drawing.Point(437, 94);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 27);
            this.OK.TabIndex = 2;
            this.OK.Text = "&OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ExceptionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(524, 473);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.DetailsToggle);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.Message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ExceptionBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Sampler: Error";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.TextBox Details;
        private System.Windows.Forms.Button DetailsToggle;
        private System.Windows.Forms.Button OK;
    }
}