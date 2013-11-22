namespace Sampler
{
    partial class SamplerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SamplerForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 50D);
            this.bigSplitContainer = new System.Windows.Forms.SplitContainer();
            this.upperSplitContainer = new System.Windows.Forms.SplitContainer();
            this.SampleChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Loop = new System.Windows.Forms.CheckBox();
            this.Play = new System.Windows.Forms.Button();
            this.BitDepth = new System.Windows.Forms.GroupBox();
            this.BitDepth16 = new System.Windows.Forms.RadioButton();
            this.BitDepth8 = new System.Windows.Forms.RadioButton();
            this.SampleRate = new System.Windows.Forms.GroupBox();
            this.CustomRate = new System.Windows.Forms.NumericUpDown();
            this.rateCustom = new System.Windows.Forms.RadioButton();
            this.rate44k = new System.Windows.Forms.RadioButton();
            this.rate22k = new System.Windows.Forms.RadioButton();
            this.rate11k = new System.Windows.Forms.RadioButton();
            this.rate8363 = new System.Windows.Forms.RadioButton();
            this.rate8000 = new System.Windows.Forms.RadioButton();
            this.Stop = new System.Windows.Forms.Button();
            this.Length = new System.Windows.Forms.GroupBox();
            this.logTime = new System.Windows.Forms.TrackBar();
            this.tagSampleCount = new System.Windows.Forms.Label();
            this.tagTime = new System.Windows.Forms.Label();
            this.SampleCount = new System.Windows.Forms.NumericUpDown();
            this.Time = new System.Windows.Forms.NumericUpDown();
            this.lowerSplitContainer = new System.Windows.Forms.SplitContainer();
            this.FormulaBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ApplyFunction = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.chartSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.sampleSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openSampleDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bigSplitContainer)).BeginInit();
            this.bigSplitContainer.Panel1.SuspendLayout();
            this.bigSplitContainer.Panel2.SuspendLayout();
            this.bigSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperSplitContainer)).BeginInit();
            this.upperSplitContainer.Panel1.SuspendLayout();
            this.upperSplitContainer.Panel2.SuspendLayout();
            this.upperSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampleChart)).BeginInit();
            this.BitDepth.SuspendLayout();
            this.SampleRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomRate)).BeginInit();
            this.Length.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SampleCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerSplitContainer)).BeginInit();
            this.lowerSplitContainer.Panel1.SuspendLayout();
            this.lowerSplitContainer.Panel2.SuspendLayout();
            this.lowerSplitContainer.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigSplitContainer
            // 
            resources.ApplyResources(this.bigSplitContainer, "bigSplitContainer");
            this.bigSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.bigSplitContainer.Name = "bigSplitContainer";
            // 
            // bigSplitContainer.Panel1
            // 
            resources.ApplyResources(this.bigSplitContainer.Panel1, "bigSplitContainer.Panel1");
            this.bigSplitContainer.Panel1.Controls.Add(this.upperSplitContainer);
            // 
            // bigSplitContainer.Panel2
            // 
            resources.ApplyResources(this.bigSplitContainer.Panel2, "bigSplitContainer.Panel2");
            this.bigSplitContainer.Panel2.Controls.Add(this.lowerSplitContainer);
            // 
            // upperSplitContainer
            // 
            resources.ApplyResources(this.upperSplitContainer, "upperSplitContainer");
            this.upperSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.upperSplitContainer.Name = "upperSplitContainer";
            // 
            // upperSplitContainer.Panel1
            // 
            resources.ApplyResources(this.upperSplitContainer.Panel1, "upperSplitContainer.Panel1");
            this.upperSplitContainer.Panel1.Controls.Add(this.SampleChart);
            // 
            // upperSplitContainer.Panel2
            // 
            resources.ApplyResources(this.upperSplitContainer.Panel2, "upperSplitContainer.Panel2");
            this.upperSplitContainer.Panel2.Controls.Add(this.Loop);
            this.upperSplitContainer.Panel2.Controls.Add(this.Play);
            this.upperSplitContainer.Panel2.Controls.Add(this.BitDepth);
            this.upperSplitContainer.Panel2.Controls.Add(this.SampleRate);
            this.upperSplitContainer.Panel2.Controls.Add(this.Stop);
            this.upperSplitContainer.Panel2.Controls.Add(this.Length);
            // 
            // SampleChart
            // 
            resources.ApplyResources(this.SampleChart, "SampleChart");
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.Crossing = 0D;
            chartArea2.AxisY.Interval = 128D;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY.Maximum = 255D;
            chartArea2.AxisY.Minimum = -255D;
            chartArea2.Name = "ChartArea1";
            this.SampleChart.ChartAreas.Add(chartArea2);
            this.SampleChart.Name = "SampleChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Name = "Series1";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            this.SampleChart.Series.Add(series2);
            // 
            // Loop
            // 
            resources.ApplyResources(this.Loop, "Loop");
            this.Loop.Checked = true;
            this.Loop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Loop.Name = "Loop";
            this.Loop.UseVisualStyleBackColor = true;
            // 
            // Play
            // 
            resources.ApplyResources(this.Play, "Play");
            this.Play.Name = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // BitDepth
            // 
            resources.ApplyResources(this.BitDepth, "BitDepth");
            this.BitDepth.Controls.Add(this.BitDepth16);
            this.BitDepth.Controls.Add(this.BitDepth8);
            this.BitDepth.Name = "BitDepth";
            this.BitDepth.TabStop = false;
            // 
            // BitDepth16
            // 
            resources.ApplyResources(this.BitDepth16, "BitDepth16");
            this.BitDepth16.Name = "BitDepth16";
            this.BitDepth16.UseVisualStyleBackColor = true;
            this.BitDepth16.CheckedChanged += new System.EventHandler(this.BitDepth_CheckedChanged);
            // 
            // BitDepth8
            // 
            resources.ApplyResources(this.BitDepth8, "BitDepth8");
            this.BitDepth8.Checked = true;
            this.BitDepth8.Name = "BitDepth8";
            this.BitDepth8.TabStop = true;
            this.BitDepth8.UseVisualStyleBackColor = true;
            this.BitDepth8.CheckedChanged += new System.EventHandler(this.BitDepth_CheckedChanged);
            // 
            // SampleRate
            // 
            resources.ApplyResources(this.SampleRate, "SampleRate");
            this.SampleRate.Controls.Add(this.CustomRate);
            this.SampleRate.Controls.Add(this.rateCustom);
            this.SampleRate.Controls.Add(this.rate44k);
            this.SampleRate.Controls.Add(this.rate22k);
            this.SampleRate.Controls.Add(this.rate11k);
            this.SampleRate.Controls.Add(this.rate8363);
            this.SampleRate.Controls.Add(this.rate8000);
            this.SampleRate.Name = "SampleRate";
            this.SampleRate.TabStop = false;
            // 
            // CustomRate
            // 
            resources.ApplyResources(this.CustomRate, "CustomRate");
            this.CustomRate.Maximum = new decimal(new int[] {
            96000,
            0,
            0,
            0});
            this.CustomRate.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.CustomRate.Name = "CustomRate";
            this.CustomRate.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.CustomRate.ValueChanged += new System.EventHandler(this.CustomRate_ValueChanged);
            // 
            // rateCustom
            // 
            resources.ApplyResources(this.rateCustom, "rateCustom");
            this.rateCustom.Name = "rateCustom";
            this.rateCustom.UseVisualStyleBackColor = true;
            this.rateCustom.CheckedChanged += new System.EventHandler(this.rate_CheckedChanged);
            // 
            // rate44k
            // 
            resources.ApplyResources(this.rate44k, "rate44k");
            this.rate44k.Name = "rate44k";
            this.rate44k.UseVisualStyleBackColor = true;
            this.rate44k.CheckedChanged += new System.EventHandler(this.rate_CheckedChanged);
            // 
            // rate22k
            // 
            resources.ApplyResources(this.rate22k, "rate22k");
            this.rate22k.Name = "rate22k";
            this.rate22k.UseVisualStyleBackColor = true;
            this.rate22k.CheckedChanged += new System.EventHandler(this.rate_CheckedChanged);
            // 
            // rate11k
            // 
            resources.ApplyResources(this.rate11k, "rate11k");
            this.rate11k.Name = "rate11k";
            this.rate11k.UseVisualStyleBackColor = true;
            this.rate11k.CheckedChanged += new System.EventHandler(this.rate_CheckedChanged);
            // 
            // rate8363
            // 
            resources.ApplyResources(this.rate8363, "rate8363");
            this.rate8363.Checked = true;
            this.rate8363.Name = "rate8363";
            this.rate8363.TabStop = true;
            this.rate8363.UseVisualStyleBackColor = true;
            this.rate8363.CheckedChanged += new System.EventHandler(this.rate_CheckedChanged);
            // 
            // rate8000
            // 
            resources.ApplyResources(this.rate8000, "rate8000");
            this.rate8000.Name = "rate8000";
            this.rate8000.Tag = "8000";
            this.rate8000.UseVisualStyleBackColor = true;
            this.rate8000.CheckedChanged += new System.EventHandler(this.rate_CheckedChanged);
            // 
            // Stop
            // 
            resources.ApplyResources(this.Stop, "Stop");
            this.Stop.Name = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Length
            // 
            resources.ApplyResources(this.Length, "Length");
            this.Length.Controls.Add(this.logTime);
            this.Length.Controls.Add(this.tagSampleCount);
            this.Length.Controls.Add(this.tagTime);
            this.Length.Controls.Add(this.SampleCount);
            this.Length.Controls.Add(this.Time);
            this.Length.Name = "Length";
            this.Length.TabStop = false;
            // 
            // logTime
            // 
            resources.ApplyResources(this.logTime, "logTime");
            this.logTime.LargeChange = 10;
            this.logTime.Minimum = -30;
            this.logTime.Name = "logTime";
            this.logTime.ValueChanged += new System.EventHandler(this.logTime_Scroll);
            // 
            // tagSampleCount
            // 
            resources.ApplyResources(this.tagSampleCount, "tagSampleCount");
            this.tagSampleCount.Name = "tagSampleCount";
            // 
            // tagTime
            // 
            resources.ApplyResources(this.tagTime, "tagTime");
            this.tagTime.Name = "tagTime";
            // 
            // SampleCount
            // 
            resources.ApplyResources(this.SampleCount, "SampleCount");
            this.SampleCount.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.SampleCount.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.SampleCount.Name = "SampleCount";
            this.SampleCount.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.SampleCount.ValueChanged += new System.EventHandler(this.SampleCount_ValueChanged);
            // 
            // Time
            // 
            resources.ApplyResources(this.Time, "Time");
            this.Time.DecimalPlaces = 2;
            this.Time.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Time.Maximum = new decimal(new int[] {
            10001,
            0,
            0,
            0});
            this.Time.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.Time.Name = "Time";
            this.Time.Value = new decimal(new int[] {
            191,
            0,
            0,
            131072});
            this.Time.ValueChanged += new System.EventHandler(this.Time_ValueChanged);
            // 
            // lowerSplitContainer
            // 
            resources.ApplyResources(this.lowerSplitContainer, "lowerSplitContainer");
            this.lowerSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.lowerSplitContainer.Name = "lowerSplitContainer";
            // 
            // lowerSplitContainer.Panel1
            // 
            resources.ApplyResources(this.lowerSplitContainer.Panel1, "lowerSplitContainer.Panel1");
            this.lowerSplitContainer.Panel1.Controls.Add(this.FormulaBox);
            // 
            // lowerSplitContainer.Panel2
            // 
            resources.ApplyResources(this.lowerSplitContainer.Panel2, "lowerSplitContainer.Panel2");
            this.lowerSplitContainer.Panel2.Controls.Add(this.label2);
            this.lowerSplitContainer.Panel2.Controls.Add(this.label1);
            this.lowerSplitContainer.Panel2.Controls.Add(this.ApplyFunction);
            // 
            // FormulaBox
            // 
            this.FormulaBox.AcceptsReturn = true;
            this.FormulaBox.AcceptsTab = true;
            resources.ApplyResources(this.FormulaBox, "FormulaBox");
            this.FormulaBox.Name = "FormulaBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ApplyFunction
            // 
            resources.ApplyResources(this.ApplyFunction, "ApplyFunction");
            this.ApplyFunction.Name = "ApplyFunction";
            this.ApplyFunction.UseVisualStyleBackColor = true;
            this.ApplyFunction.Click += new System.EventHandler(this.ApplyFunction_Click);
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exportAudioToolStripMenuItem,
            this.exportGraphToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // newToolStripMenuItem
            // 
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exportAudioToolStripMenuItem
            // 
            resources.ApplyResources(this.exportAudioToolStripMenuItem, "exportAudioToolStripMenuItem");
            this.exportAudioToolStripMenuItem.Name = "exportAudioToolStripMenuItem";
            this.exportAudioToolStripMenuItem.Click += new System.EventHandler(this.exportAudioToolStripMenuItem_Click);
            // 
            // exportGraphToolStripMenuItem
            // 
            resources.ApplyResources(this.exportGraphToolStripMenuItem, "exportGraphToolStripMenuItem");
            this.exportGraphToolStripMenuItem.Name = "exportGraphToolStripMenuItem";
            this.exportGraphToolStripMenuItem.Click += new System.EventHandler(this.exportGraphToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // quitToolStripMenuItem
            // 
            resources.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // viewHelpToolStripMenuItem
            // 
            resources.ApplyResources(this.viewHelpToolStripMenuItem, "viewHelpToolStripMenuItem");
            this.viewHelpToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // audioSaveFileDialog
            // 
            this.audioSaveFileDialog.DefaultExt = "wav";
            this.audioSaveFileDialog.FileName = "waveform.wav";
            resources.ApplyResources(this.audioSaveFileDialog, "audioSaveFileDialog");
            // 
            // chartSaveFileDialog
            // 
            this.chartSaveFileDialog.DefaultExt = "png";
            this.chartSaveFileDialog.FileName = "chart.png";
            resources.ApplyResources(this.chartSaveFileDialog, "chartSaveFileDialog");
            // 
            // sampleSaveFileDialog
            // 
            this.sampleSaveFileDialog.FileName = "waveform.sample";
            resources.ApplyResources(this.sampleSaveFileDialog, "sampleSaveFileDialog");
            // 
            // openSampleDialog
            // 
            this.openSampleDialog.FileName = "waveform.sample";
            resources.ApplyResources(this.openSampleDialog, "openSampleDialog");
            // 
            // SamplerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bigSplitContainer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "SamplerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SamplerForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SamplerForm_FormClosed);
            this.bigSplitContainer.Panel1.ResumeLayout(false);
            this.bigSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bigSplitContainer)).EndInit();
            this.bigSplitContainer.ResumeLayout(false);
            this.upperSplitContainer.Panel1.ResumeLayout(false);
            this.upperSplitContainer.Panel2.ResumeLayout(false);
            this.upperSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperSplitContainer)).EndInit();
            this.upperSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SampleChart)).EndInit();
            this.BitDepth.ResumeLayout(false);
            this.BitDepth.PerformLayout();
            this.SampleRate.ResumeLayout(false);
            this.SampleRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomRate)).EndInit();
            this.Length.ResumeLayout(false);
            this.Length.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SampleCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time)).EndInit();
            this.lowerSplitContainer.Panel1.ResumeLayout(false);
            this.lowerSplitContainer.Panel1.PerformLayout();
            this.lowerSplitContainer.Panel2.ResumeLayout(false);
            this.lowerSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowerSplitContainer)).EndInit();
            this.lowerSplitContainer.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer bigSplitContainer;
        private System.Windows.Forms.SplitContainer upperSplitContainer;
        private System.Windows.Forms.DataVisualization.Charting.Chart SampleChart;
        private System.Windows.Forms.CheckBox Loop;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.GroupBox BitDepth;
        private System.Windows.Forms.RadioButton BitDepth16;
        private System.Windows.Forms.RadioButton BitDepth8;
        private System.Windows.Forms.GroupBox SampleRate;
        private System.Windows.Forms.NumericUpDown CustomRate;
        private System.Windows.Forms.RadioButton rateCustom;
        private System.Windows.Forms.RadioButton rate44k;
        private System.Windows.Forms.RadioButton rate22k;
        private System.Windows.Forms.RadioButton rate11k;
        private System.Windows.Forms.RadioButton rate8363;
        private System.Windows.Forms.RadioButton rate8000;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.GroupBox Length;
        private System.Windows.Forms.TrackBar logTime;
        private System.Windows.Forms.Label tagSampleCount;
        private System.Windows.Forms.Label tagTime;
        private System.Windows.Forms.NumericUpDown SampleCount;
        private System.Windows.Forms.NumericUpDown Time;
        private System.Windows.Forms.Button ApplyFunction;
        private System.Windows.Forms.TextBox FormulaBox;
        private System.Windows.Forms.SplitContainer lowerSplitContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog audioSaveFileDialog;
        private System.Windows.Forms.SaveFileDialog chartSaveFileDialog;
        private System.Windows.Forms.SaveFileDialog sampleSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog openSampleDialog;


    }
}

