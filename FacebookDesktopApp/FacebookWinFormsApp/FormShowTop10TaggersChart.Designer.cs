﻿namespace BasicFacebookFeatures
{
    partial class FormShowTop10TaggersChart
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.TopTaggersChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.TopTaggersChart)).BeginInit();
            this.SuspendLayout();
            // 
            // TopTaggersChart
            // 
            chartArea1.Name = "ChartArea1";
            this.TopTaggersChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TopTaggersChart.Legends.Add(legend1);
            this.TopTaggersChart.Location = new System.Drawing.Point(12, 12);
            this.TopTaggersChart.Name = "TopTaggersChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Number of Tags";
            this.TopTaggersChart.Series.Add(series1);
            this.TopTaggersChart.Size = new System.Drawing.Size(976, 681);
            this.TopTaggersChart.TabIndex = 0;
            title1.Name = "Number Of Tags";
            title1.Text = "Number Of Tags";
            this.TopTaggersChart.Titles.Add(title1);
            // 
            // FormShowTop10TaggersChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 560);
            this.Controls.Add(this.TopTaggersChart);
            this.Name = "FormShowTop10TaggersChart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopTaggersChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart TopTaggersChart;
    }
}