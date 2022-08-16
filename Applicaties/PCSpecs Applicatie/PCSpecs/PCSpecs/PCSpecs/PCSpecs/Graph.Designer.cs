namespace PCSpecs
{
    partial class Graph
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graph));
            this.usageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tempChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempChart)).BeginInit();
            this.SuspendLayout();
            // 
            // usageChart
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.usageChart.ChartAreas.Add(chartArea1);
            this.usageChart.Location = new System.Drawing.Point(6, 69);
            this.usageChart.Name = "usageChart";
            this.usageChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.RoyalBlue;
            series1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsXValueIndexed = true;
            series1.LabelBackColor = System.Drawing.Color.DarkGray;
            series1.LabelBorderColor = System.Drawing.Color.Black;
            series1.Name = "usage";
            series1.YValueMembers = "0";
            this.usageChart.Series.Add(series1);
            this.usageChart.Size = new System.Drawing.Size(628, 315);
            this.usageChart.TabIndex = 0;
            this.usageChart.Text = ".";
            title1.BackColor = System.Drawing.Color.Silver;
            title1.Font = new System.Drawing.Font("Arial", 10F);
            title1.Name = "usageTitle";
            title1.Text = "Usage (%)";
            this.usageChart.Titles.Add(title1);
            // 
            // tempChart
            // 
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.LineWidth = 0;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.MinorGrid.Enabled = true;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.Name = "ChartArea1";
            this.tempChart.ChartAreas.Add(chartArea2);
            this.tempChart.Location = new System.Drawing.Point(6, 390);
            this.tempChart.Name = "tempChart";
            this.tempChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.BackSecondaryColor = System.Drawing.Color.Transparent;
            series2.BorderColor = System.Drawing.Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.RoyalBlue;
            series2.IsXValueIndexed = true;
            series2.LabelBackColor = System.Drawing.SystemColors.ActiveBorder;
            series2.LabelBorderColor = System.Drawing.Color.Black;
            series2.Name = "temp";
            series2.YValuesPerPoint = 2;
            this.tempChart.Series.Add(series2);
            this.tempChart.Size = new System.Drawing.Size(628, 335);
            this.tempChart.TabIndex = 1;
            this.tempChart.Text = "chart2";
            title2.BackColor = System.Drawing.Color.Silver;
            title2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "tempTitle";
            title2.Text = "Temperature (°C)";
            this.tempChart.Titles.Add(title2);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 733);
            this.Controls.Add(this.tempChart);
            this.Controls.Add(this.usageChart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Graph";
            this.Text = "Graph";
            ((System.ComponentModel.ISupportInitialize)(this.usageChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart usageChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart tempChart;
        private System.Windows.Forms.Timer timer;
    }
}