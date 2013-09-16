namespace Sampler
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 50D);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SampleChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Visualize = new System.Windows.Forms.Button();
            this.FormulaBox = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.BitDepth = new System.Windows.Forms.GroupBox();
            this.BitDepth16 = new System.Windows.Forms.RadioButton();
            this.BitDepth8 = new System.Windows.Forms.RadioButton();
            this.Length = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tagSampleCount = new System.Windows.Forms.Label();
            this.SampleCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampleChart)).BeginInit();
            this.BitDepth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SampleCount)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Stop);
            this.splitContainer1.Panel2.Controls.Add(this.Play);
            this.splitContainer1.Panel2.Controls.Add(this.BitDepth);
            this.splitContainer1.Panel2.Controls.Add(this.Length);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.tagSampleCount);
            this.splitContainer1.Panel2.Controls.Add(this.SampleCount);
            this.splitContainer1.Size = new System.Drawing.Size(1230, 689);
            this.splitContainer1.SplitterDistance = 956;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.SampleChart);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Visualize);
            this.splitContainer2.Panel2.Controls.Add(this.FormulaBox);
            this.splitContainer2.Size = new System.Drawing.Size(956, 689);
            this.splitContainer2.SplitterDistance = 444;
            this.splitContainer2.TabIndex = 0;
            // 
            // SampleChart
            // 
            this.SampleChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisY.Crossing = 0D;
            chartArea3.AxisY.Interval = 128D;
            chartArea3.AxisY.LabelStyle.Enabled = false;
            chartArea3.AxisY.Maximum = 255D;
            chartArea3.AxisY.Minimum = -255D;
            chartArea3.Name = "ChartArea1";
            this.SampleChart.ChartAreas.Add(chartArea3);
            this.SampleChart.Location = new System.Drawing.Point(0, 0);
            this.SampleChart.Name = "SampleChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series1";
            series3.Points.Add(dataPoint5);
            series3.Points.Add(dataPoint6);
            this.SampleChart.Series.Add(series3);
            this.SampleChart.Size = new System.Drawing.Size(956, 443);
            this.SampleChart.TabIndex = 0;
            this.SampleChart.Text = "chart1";
            // 
            // Visualize
            // 
            this.Visualize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Visualize.AutoSize = true;
            this.Visualize.Location = new System.Drawing.Point(878, 6);
            this.Visualize.Name = "Visualize";
            this.Visualize.Size = new System.Drawing.Size(75, 27);
            this.Visualize.TabIndex = 1;
            this.Visualize.Text = "Parse";
            this.Visualize.UseVisualStyleBackColor = true;
            this.Visualize.Click += new System.EventHandler(this.Visualize_Click);
            // 
            // FormulaBox
            // 
            this.FormulaBox.AcceptsReturn = true;
            this.FormulaBox.AcceptsTab = true;
            this.FormulaBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormulaBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormulaBox.Location = new System.Drawing.Point(3, 3);
            this.FormulaBox.Multiline = true;
            this.FormulaBox.Name = "FormulaBox";
            this.FormulaBox.Size = new System.Drawing.Size(869, 235);
            this.FormulaBox.TabIndex = 0;
            this.FormulaBox.Text = "sin(t, C)";
            // 
            // Stop
            // 
            this.Stop.AutoSize = true;
            this.Stop.Location = new System.Drawing.Point(165, 146);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 27);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Play
            // 
            this.Play.AutoSize = true;
            this.Play.Location = new System.Drawing.Point(165, 113);
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
            this.BitDepth.Location = new System.Drawing.Point(23, 113);
            this.BitDepth.Name = "BitDepth";
            this.BitDepth.Size = new System.Drawing.Size(100, 77);
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
            // Length
            // 
            this.Length.DecimalPlaces = 2;
            this.Length.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Length.Location = new System.Drawing.Point(120, 70);
            this.Length.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Length.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(120, 22);
            this.Length.TabIndex = 3;
            this.Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Length.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Length.ValueChanged += new System.EventHandler(this.Length_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Length (ms)";
            // 
            // tagSampleCount
            // 
            this.tagSampleCount.AutoSize = true;
            this.tagSampleCount.Location = new System.Drawing.Point(20, 43);
            this.tagSampleCount.Name = "tagSampleCount";
            this.tagSampleCount.Size = new System.Drawing.Size(94, 17);
            this.tagSampleCount.TabIndex = 1;
            this.tagSampleCount.Text = "Sample count";
            // 
            // SampleCount
            // 
            this.SampleCount.Location = new System.Drawing.Point(120, 41);
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
            this.SampleCount.Size = new System.Drawing.Size(120, 22);
            this.SampleCount.TabIndex = 0;
            this.SampleCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SampleCount.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.SampleCount.ValueChanged += new System.EventHandler(this.SampleCount_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 689);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SampleChart)).EndInit();
            this.BitDepth.ResumeLayout(false);
            this.BitDepth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SampleCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart SampleChart;
        private System.Windows.Forms.TextBox FormulaBox;
        private System.Windows.Forms.Button Visualize;
        private System.Windows.Forms.GroupBox BitDepth;
        private System.Windows.Forms.RadioButton BitDepth16;
        private System.Windows.Forms.RadioButton BitDepth8;
        private System.Windows.Forms.NumericUpDown Length;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tagSampleCount;
        private System.Windows.Forms.NumericUpDown SampleCount;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Stop;
    }
}

