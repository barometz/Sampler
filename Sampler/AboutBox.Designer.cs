namespace Sampler
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.weblink = new System.Windows.Forms.LinkLabel();
            this.thirdPartySoftware = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tagWAVFile = new System.Windows.Forms.Label();
            this.linkWAVFile = new System.Windows.Forms.LinkLabel();
            this.tagExpressionEval = new System.Windows.Forms.Label();
            this.linkExpressionEval = new System.Windows.Forms.LinkLabel();
            this.LicenseText = new System.Windows.Forms.TextBox();
            this.toggleLicenseText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.thirdPartySoftware.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 11);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LicenseText);
            this.splitContainer1.Size = new System.Drawing.Size(1180, 326);
            this.splitContainer1.SplitterDistance = 555;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.weblink, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.thirdPartySoftware, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.toggleLicenseText, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(555, 326);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::Sampler.Properties.Resources.Banner;
            this.logoPictureBox.Location = new System.Drawing.Point(4, 4);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 7);
            this.logoPictureBox.Size = new System.Drawing.Size(173, 318);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // labelProductName
            // 
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.Location = new System.Drawing.Point(189, 0);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 21);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(362, 21);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Location = new System.Drawing.Point(189, 28);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 21);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(362, 21);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCopyright.Location = new System.Drawing.Point(189, 56);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 21);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(362, 21);
            this.labelCopyright.TabIndex = 21;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(451, 295);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 27);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // weblink
            // 
            this.weblink.AutoSize = true;
            this.weblink.Location = new System.Drawing.Point(189, 84);
            this.weblink.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.weblink.Name = "weblink";
            this.weblink.Size = new System.Drawing.Size(128, 17);
            this.weblink.TabIndex = 25;
            this.weblink.TabStop = true;
            this.weblink.Text = "Sampler on GitHub";
            this.weblink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // thirdPartySoftware
            // 
            this.thirdPartySoftware.Controls.Add(this.tableLayoutPanel1);
            this.thirdPartySoftware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirdPartySoftware.Location = new System.Drawing.Point(184, 115);
            this.thirdPartySoftware.Name = "thirdPartySoftware";
            this.thirdPartySoftware.Size = new System.Drawing.Size(368, 136);
            this.thirdPartySoftware.TabIndex = 26;
            this.thirdPartySoftware.TabStop = false;
            this.thirdPartySoftware.Text = "Third-party software";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.42382F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.57618F));
            this.tableLayoutPanel1.Controls.Add(this.tagWAVFile, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkWAVFile, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tagExpressionEval, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkExpressionEval, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 115);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tagWAVFile
            // 
            this.tagWAVFile.AutoSize = true;
            this.tagWAVFile.Location = new System.Drawing.Point(3, 49);
            this.tagWAVFile.Name = "tagWAVFile";
            this.tagWAVFile.Size = new System.Drawing.Size(88, 17);
            this.tagWAVFile.TabIndex = 2;
            this.tagWAVFile.Text = "Audio output";
            // 
            // linkWAVFile
            // 
            this.linkWAVFile.AutoSize = true;
            this.linkWAVFile.LinkArea = new System.Windows.Forms.LinkArea(82, 103);
            this.linkWAVFile.Location = new System.Drawing.Point(102, 49);
            this.linkWAVFile.Name = "linkWAVFile";
            this.linkWAVFile.Size = new System.Drawing.Size(257, 49);
            this.linkWAVFile.TabIndex = 3;
            this.linkWAVFile.TabStop = true;
            this.linkWAVFile.Text = "\"C# WAV file class, audio mixing, and some light audio manipulation\" by Nightfox\r" +
    "\nSource on CodeProject";
            this.linkWAVFile.UseCompatibleTextRendering = true;
            this.linkWAVFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // tagExpressionEval
            // 
            this.tagExpressionEval.AutoSize = true;
            this.tagExpressionEval.Location = new System.Drawing.Point(3, 0);
            this.tagExpressionEval.Name = "tagExpressionEval";
            this.tagExpressionEval.Size = new System.Drawing.Size(81, 34);
            this.tagExpressionEval.TabIndex = 0;
            this.tagExpressionEval.Text = "Expression evaluation";
            // 
            // linkExpressionEval
            // 
            this.linkExpressionEval.AutoSize = true;
            this.linkExpressionEval.LinkArea = new System.Windows.Forms.LinkArea(63, 85);
            this.linkExpressionEval.Location = new System.Drawing.Point(102, 0);
            this.linkExpressionEval.Name = "linkExpressionEval";
            this.linkExpressionEval.Size = new System.Drawing.Size(210, 49);
            this.linkExpressionEval.TabIndex = 1;
            this.linkExpressionEval.TabStop = true;
            this.linkExpressionEval.Text = "\".Net Expression Evaluator using DynamicMethod\" by Drew Wilson\r\nSource on CodePro" +
    "ject";
            this.linkExpressionEval.UseCompatibleTextRendering = true;
            this.linkExpressionEval.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // LicenseText
            // 
            this.LicenseText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LicenseText.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseText.Location = new System.Drawing.Point(0, 0);
            this.LicenseText.Multiline = true;
            this.LicenseText.Name = "LicenseText";
            this.LicenseText.ReadOnly = true;
            this.LicenseText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LicenseText.Size = new System.Drawing.Size(621, 326);
            this.LicenseText.TabIndex = 28;
            // 
            // toggleLicenseText
            // 
            this.toggleLicenseText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleLicenseText.AutoSize = true;
            this.toggleLicenseText.Location = new System.Drawing.Point(386, 258);
            this.toggleLicenseText.Margin = new System.Windows.Forms.Padding(4);
            this.toggleLicenseText.Name = "toggleLicenseText";
            this.toggleLicenseText.Size = new System.Drawing.Size(165, 27);
            this.toggleLicenseText.TabIndex = 27;
            this.toggleLicenseText.Text = "Show license details >>";
            this.toggleLicenseText.UseVisualStyleBackColor = true;
            this.toggleLicenseText.Click += new System.EventHandler(this.toggleLicenseText_Click);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 348);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.thirdPartySoftware.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.LinkLabel weblink;
        private System.Windows.Forms.GroupBox thirdPartySoftware;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label tagWAVFile;
        private System.Windows.Forms.LinkLabel linkWAVFile;
        private System.Windows.Forms.Label tagExpressionEval;
        private System.Windows.Forms.LinkLabel linkExpressionEval;
        private System.Windows.Forms.TextBox LicenseText;
        private System.Windows.Forms.Button toggleLicenseText;

    }
}
