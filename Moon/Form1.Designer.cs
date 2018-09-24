namespace Moon
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(39448D, 6D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(39454D, 12D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(39462D, 23D);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker2);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(960, 546);
            this.splitContainer1.SplitterDistance = 56;
            this.splitContainer1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Weeks;
            chartArea2.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30 | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.MajorGrid.Interval = 1D;
            chartArea2.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea2.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Weeks;
            chartArea2.AxisX.MajorGrid.LineWidth = 2;
            chartArea2.AxisX.MajorTickMark.Interval = 1D;
            chartArea2.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Weeks;
            chartArea2.AxisX.MajorTickMark.LineWidth = 2;
            chartArea2.AxisX.MajorTickMark.Size = 0F;
            chartArea2.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea2.AxisX.MinorGrid.Enabled = true;
            chartArea2.AxisX.MinorGrid.Interval = 1D;
            chartArea2.AxisX.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.MinorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea2.AxisX.MinorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.MinorTickMark.Size = 100F;
            chartArea2.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea2.AxisY.Interval = 3D;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.MajorGrid.Interval = 3D;
            chartArea2.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.MajorGrid.LineWidth = 2;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.MajorTickMark.LineWidth = 2;
            chartArea2.AxisY.MajorTickMark.Size = 100F;
            chartArea2.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea2.AxisY.MinorGrid.Enabled = true;
            chartArea2.AxisY.MinorGrid.Interval = 1D;
            chartArea2.AxisY.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.MinorTickMark.Size = 100F;
            chartArea2.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.AutoFitMinFontSize = 12;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Points.Add(dataPoint4);
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(960, 486);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(255, 27);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "to";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 546);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "MoonChart";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}

