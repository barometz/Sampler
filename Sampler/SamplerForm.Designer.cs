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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 50D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SamplerForm));
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigSplitContainer
            // 
            this.bigSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bigSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.bigSplitContainer.IsSplitterFixed = true;
            this.bigSplitContainer.Location = new System.Drawing.Point(0, 28);
            this.bigSplitContainer.Name = "bigSplitContainer";
            this.bigSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // bigSplitContainer.Panel1
            // 
            this.bigSplitContainer.Panel1.Controls.Add(this.upperSplitContainer);
            // 
            // bigSplitContainer.Panel2
            // 
            this.bigSplitContainer.Panel2.Controls.Add(this.lowerSplitContainer);
            this.bigSplitContainer.Size = new System.Drawing.Size(924, 586);
            this.bigSplitContainer.SplitterDistance = 403;
            this.bigSplitContainer.TabIndex = 1;
            // 
            // upperSplitContainer
            // 
            this.upperSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.upperSplitContainer.IsSplitterFixed = true;
            this.upperSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.upperSplitContainer.MinimumSize = new System.Drawing.Size(0, 400);
            this.upperSplitContainer.Name = "upperSplitContainer";
            // 
            // upperSplitContainer.Panel1
            // 
            this.upperSplitContainer.Panel1.Controls.Add(this.SampleChart);
            // 
            // upperSplitContainer.Panel2
            // 
            this.upperSplitContainer.Panel2.Controls.Add(this.Loop);
            this.upperSplitContainer.Panel2.Controls.Add(this.Play);
            this.upperSplitContainer.Panel2.Controls.Add(this.BitDepth);
            this.upperSplitContainer.Panel2.Controls.Add(this.SampleRate);
            this.upperSplitContainer.Panel2.Controls.Add(this.Stop);
            this.upperSplitContainer.Panel2.Controls.Add(this.Length);
            this.upperSplitContainer.Size = new System.Drawing.Size(924, 403);
            this.upperSplitContainer.SplitterDistance = 663;
            this.upperSplitContainer.TabIndex = 0;
            // 
            // SampleChart
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.Interval = 128D;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.Maximum = 255D;
            chartArea1.AxisY.Minimum = -255D;
            chartArea1.Name = "ChartArea1";
            this.SampleChart.ChartAreas.Add(chartArea1);
            this.SampleChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SampleChart.Location = new System.Drawing.Point(0, 0);
            this.SampleChart.Name = "SampleChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.SampleChart.Series.Add(series1);
            this.SampleChart.Size = new System.Drawing.Size(663, 403);
            this.SampleChart.TabIndex = 0;
            this.SampleChart.Text = "chart1";
            // 
            // Loop
            // 
            this.Loop.AutoSize = true;
            this.Loop.Checked = true;
            this.Loop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Loop.Location = new System.Drawing.Point(180, 369);
            this.Loop.Name = "Loop";
            this.Loop.Size = new System.Drawing.Size(62, 21);
            this.Loop.TabIndex = 9;
            this.Loop.Text = "Loop";
            this.Loop.UseVisualStyleBackColor = true;
            // 
            // Play
            // 
            this.Play.AutoSize = true;
            this.Play.Location = new System.Drawing.Point(8, 365);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 27);
            this.Play.TabIndex = 5;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // BitDepth
            // 
            this.BitDepth.Controls.Add(this.BitDepth16);
            this.BitDepth.Controls.Add(this.BitDepth8);
            this.BitDepth.Location = new System.Drawing.Point(3, 157);
            this.BitDepth.Name = "BitDepth";
            this.BitDepth.Size = new System.Drawing.Size(242, 77);
            this.BitDepth.TabIndex = 4;
            this.BitDepth.TabStop = false;
            this.BitDepth.Text = "Bit depth";
            // 
            // BitDepth16
            // 
            this.BitDepth16.AutoSize = true;
            this.BitDepth16.Location = new System.Drawing.Point(5, 48);
            this.BitDepth16.Name = "BitDepth16";
            this.BitDepth16.Size = new System.Drawing.Size(65, 21);
            this.BitDepth16.TabIndex = 1;
            this.BitDepth16.Text = "16-bit";
            this.BitDepth16.UseVisualStyleBackColor = true;
            this.BitDepth16.CheckedChanged += new System.EventHandler(this.BitDepth_CheckedChanged);
            // 
            // BitDepth8
            // 
            this.BitDepth8.AutoSize = true;
            this.BitDepth8.Checked = true;
            this.BitDepth8.Location = new System.Drawing.Point(6, 21);
            this.BitDepth8.Name = "BitDepth8";
            this.BitDepth8.Size = new System.Drawing.Size(57, 21);
            this.BitDepth8.TabIndex = 0;
            this.BitDepth8.TabStop = true;
            this.BitDepth8.Text = "8-bit";
            this.BitDepth8.UseVisualStyleBackColor = true;
            this.BitDepth8.CheckedChanged += new System.EventHandler(this.BitDepth_CheckedChanged);
            // 
            // SampleRate
            // 
            this.SampleRate.Controls.Add(this.CustomRate);
            this.SampleRate.Controls.Add(this.rateCustom);
            this.SampleRate.Controls.Add(this.rate44k);
            this.SampleRate.Controls.Add(this.rate22k);
            this.SampleRate.Controls.Add(this.rate11k);
            this.SampleRate.Controls.Add(this.rate8363);
            this.SampleRate.Controls.Add(this.rate8000);
            this.SampleRate.Location = new System.Drawing.Point(3, 240);
            this.SampleRate.Name = "SampleRate";
            this.SampleRate.Size = new System.Drawing.Size(242, 115);
            this.SampleRate.TabIndex = 8;
            this.SampleRate.TabStop = false;
            this.SampleRate.Text = "Sample rate";
            // 
            // CustomRate
            // 
            this.CustomRate.Enabled = false;
            this.CustomRate.Location = new System.Drawing.Point(134, 76);
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
            this.CustomRate.Size = new System.Drawing.Size(83, 22);
            this.CustomRate.TabIndex = 6;
            this.CustomRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CustomRate.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.CustomRate.ValueChanged += new System.EventHandler(this.CustomRate_ValueChanged);
            // 
            // rateCustom
            // 
            this.rateCustom.AutoSize = true;
            this.rateCustom.Location = new System.Drawing.Point(112, 78);
            this.rateCustom.Name = "rateCustom";
            this.rateCustom.Size = new System.Drawing.Size(17, 16);
            this.rateCustom.TabIndex = 5;
            this.rateCustom.UseVisualStyleBackColor = true;
            this.rateCustom.CheckedChanged += new System.EventHandler(this.rate_CheckedChanged);
            // 
            // rate44k
            // 
            this.rate44k.AutoSize = true;
            this.rate44k.Location = new System.Drawing.Point(112, 49);
            this.rate44k.Name = "rate44k";
            this.rate44k.Size = new System.Drawing.Size(94, 21);
            this.rate44k.TabIndex = 4;
            this.rate44k.Text = "44,100 Hz";
            this.rate44k.UseVisualStyleBackColor = true;
            this.rate44k.CheckedChanged += new System.EventHandler(this.rate_CheckedChanged);
            // 
            // rate22k
            // 
            this.rate22k.AutoSize = true;
            this.rate22k.Location = new System.Drawing.Point(112, 22);
            this.rate22k.Name = "rate22k";
            this.rate22k.Size = new System.Drawing.Size(94, 21);
            this.rate22k.TabIndex = 3;
            this.rate22k.Text = "22,050 Hz";
            this.rate22k.UseVisualStyleBackColor = true;
            this.rate22k.CheckedChanged += new System.EventHandler(this.rate_CheckedChanged);
            // 
            // rate11k
            // 
            this.rate11k.AutoSize = true;
            this.rate11k.Location = new System.Drawing.Point(7, 76);
            this.rate11k.Name = "rate11k";
            this.rate11k.Size = new System.Drawing.Size(94, 21);
            this.rate11k.TabIndex = 2;
            this.rate11k.Text = "11,025 Hz";
            this.rate11k.UseVisualStyleBackColor = true;
            this.rate11k.CheckedChanged += new System.EventHandler(this.rate_CheckedChanged);
            // 
            // rate8363
            // 
            this.rate8363.AutoSize = true;
            this.rate8363.Checked = true;
            this.rate8363.Location = new System.Drawing.Point(7, 49);
            this.rate8363.Name = "rate8363";
            this.rate8363.Size = new System.Drawing.Size(82, 21);
            this.rate8363.TabIndex = 1;
            this.rate8363.TabStop = true;
            this.rate8363.Text = "8363 Hz";
            this.rate8363.UseVisualStyleBackColor = true;
            this.rate8363.CheckedChanged += new System.EventHandler(this.rate_CheckedChanged);
            // 
            // rate8000
            // 
            this.rate8000.AutoSize = true;
            this.rate8000.Location = new System.Drawing.Point(7, 22);
            this.rate8000.Name = "rate8000";
            this.rate8000.Size = new System.Drawing.Size(82, 21);
            this.rate8000.TabIndex = 0;
            this.rate8000.Tag = "8000";
            this.rate8000.Text = "8000 Hz";
            this.rate8000.UseVisualStyleBackColor = true;
            this.rate8000.CheckedChanged += new System.EventHandler(this.rate_CheckedChanged);
            // 
            // Stop
            // 
            this.Stop.AutoSize = true;
            this.Stop.Location = new System.Drawing.Point(90, 365);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 27);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Length
            // 
            this.Length.Controls.Add(this.logTime);
            this.Length.Controls.Add(this.tagSampleCount);
            this.Length.Controls.Add(this.tagTime);
            this.Length.Controls.Add(this.SampleCount);
            this.Length.Controls.Add(this.Time);
            this.Length.Location = new System.Drawing.Point(3, 12);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(242, 142);
            this.Length.TabIndex = 7;
            this.Length.TabStop = false;
            this.Length.Text = "Length";
            // 
            // logTime
            // 
            this.logTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logTime.LargeChange = 10;
            this.logTime.Location = new System.Drawing.Point(3, 83);
            this.logTime.Minimum = -30;
            this.logTime.Name = "logTime";
            this.logTime.Size = new System.Drawing.Size(236, 56);
            this.logTime.TabIndex = 4;
            this.logTime.ValueChanged += new System.EventHandler(this.logTime_Scroll);
            // 
            // tagSampleCount
            // 
            this.tagSampleCount.AutoSize = true;
            this.tagSampleCount.Location = new System.Drawing.Point(6, 23);
            this.tagSampleCount.Name = "tagSampleCount";
            this.tagSampleCount.Size = new System.Drawing.Size(94, 17);
            this.tagSampleCount.TabIndex = 1;
            this.tagSampleCount.Text = "Sample count";
            // 
            // tagTime
            // 
            this.tagTime.AutoSize = true;
            this.tagTime.Location = new System.Drawing.Point(29, 51);
            this.tagTime.Name = "tagTime";
            this.tagTime.Size = new System.Drawing.Size(71, 17);
            this.tagTime.TabIndex = 2;
            this.tagTime.Text = "Time (ms)";
            // 
            // SampleCount
            // 
            this.SampleCount.Location = new System.Drawing.Point(115, 21);
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
            this.SampleCount.Size = new System.Drawing.Size(102, 22);
            this.SampleCount.TabIndex = 0;
            this.SampleCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SampleCount.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.SampleCount.ValueChanged += new System.EventHandler(this.SampleCount_ValueChanged);
            // 
            // Time
            // 
            this.Time.DecimalPlaces = 2;
            this.Time.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Time.Location = new System.Drawing.Point(115, 49);
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
            this.Time.Size = new System.Drawing.Size(102, 22);
            this.Time.TabIndex = 3;
            this.Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Time.Value = new decimal(new int[] {
            191,
            0,
            0,
            131072});
            this.Time.ValueChanged += new System.EventHandler(this.Time_ValueChanged);
            // 
            // lowerSplitContainer
            // 
            this.lowerSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.lowerSplitContainer.IsSplitterFixed = true;
            this.lowerSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.lowerSplitContainer.Name = "lowerSplitContainer";
            // 
            // lowerSplitContainer.Panel1
            // 
            this.lowerSplitContainer.Panel1.Controls.Add(this.FormulaBox);
            // 
            // lowerSplitContainer.Panel2
            // 
            this.lowerSplitContainer.Panel2.Controls.Add(this.label2);
            this.lowerSplitContainer.Panel2.Controls.Add(this.label1);
            this.lowerSplitContainer.Panel2.Controls.Add(this.ApplyFunction);
            this.lowerSplitContainer.Size = new System.Drawing.Size(924, 179);
            this.lowerSplitContainer.SplitterDistance = 663;
            this.lowerSplitContainer.TabIndex = 0;
            // 
            // FormulaBox
            // 
            this.FormulaBox.AcceptsReturn = true;
            this.FormulaBox.AcceptsTab = true;
            this.FormulaBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormulaBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormulaBox.Location = new System.Drawing.Point(0, 0);
            this.FormulaBox.Multiline = true;
            this.FormulaBox.Name = "FormulaBox";
            this.FormulaBox.Size = new System.Drawing.Size(663, 179);
            this.FormulaBox.TabIndex = 0;
            this.FormulaBox.Text = "sin(t, C)";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 129);
            this.label2.TabIndex = 3;
            this.label2.Text = "sin(t, frequency)\r\nsquare(t, frequency)\r\nsawtooth(t, frequency)\r\ntriangle(t, freq" +
    "uency)\r\nnoise(t)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Functions:";
            // 
            // ApplyFunction
            // 
            this.ApplyFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyFunction.AutoSize = true;
            this.ApplyFunction.Location = new System.Drawing.Point(9, 3);
            this.ApplyFunction.Name = "ApplyFunction";
            this.ApplyFunction.Size = new System.Drawing.Size(125, 27);
            this.ApplyFunction.TabIndex = 1;
            this.ApplyFunction.Text = "Apply function";
            this.ApplyFunction.UseVisualStyleBackColor = true;
            this.ApplyFunction.Click += new System.EventHandler(this.ApplyFunction_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exportAudioToolStripMenuItem,
            this.exportGraphToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exportAudioToolStripMenuItem
            // 
            this.exportAudioToolStripMenuItem.Name = "exportAudioToolStripMenuItem";
            this.exportAudioToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.exportAudioToolStripMenuItem.Text = "Export audio";
            // 
            // exportGraphToolStripMenuItem
            // 
            this.exportGraphToolStripMenuItem.Name = "exportGraphToolStripMenuItem";
            this.exportGraphToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.exportGraphToolStripMenuItem.Text = "Export graph";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(164, 24);
            this.quitToolStripMenuItem1.Text = "Quit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.viewHelpToolStripMenuItem.Text = "View help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // SamplerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 614);
            this.Controls.Add(this.bigSplitContainer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(740, 661);
            this.Name = "SamplerForm";
            this.Text = "Sampler";
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;


    }
}

