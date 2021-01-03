namespace StockDataDownloader.UI.Chart
{
    partial class TimeSeriesControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timeSeriesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.rangeComboBox = new System.Windows.Forms.ComboBox();
            this.rangeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeSeriesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // timeSeriesChart
            // 
            this.timeSeriesChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.timeSeriesChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.timeSeriesChart.Legends.Add(legend2);
            this.timeSeriesChart.Location = new System.Drawing.Point(0, 38);
            this.timeSeriesChart.Name = "timeSeriesChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.timeSeriesChart.Series.Add(series2);
            this.timeSeriesChart.Size = new System.Drawing.Size(489, 388);
            this.timeSeriesChart.TabIndex = 0;
            this.timeSeriesChart.Text = "chart1";
            // 
            // prevButton
            // 
            this.prevButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prevButton.Location = new System.Drawing.Point(120, 432);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 1;
            this.prevButton.Text = "<<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.Location = new System.Drawing.Point(299, 432);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = ">>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // rangeComboBox
            // 
            this.rangeComboBox.FormattingEnabled = true;
            this.rangeComboBox.Location = new System.Drawing.Point(63, 10);
            this.rangeComboBox.Name = "rangeComboBox";
            this.rangeComboBox.Size = new System.Drawing.Size(121, 20);
            this.rangeComboBox.TabIndex = 3;
            this.rangeComboBox.SelectedIndexChanged += new System.EventHandler(this.rangeComboBox_SelectedIndexChanged);
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Location = new System.Drawing.Point(18, 13);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(33, 12);
            this.rangeLabel.TabIndex = 4;
            this.rangeLabel.Text = "レンジ";
            // 
            // TimeSeriesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rangeLabel);
            this.Controls.Add(this.rangeComboBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.timeSeriesChart);
            this.Name = "TimeSeriesControl";
            this.Size = new System.Drawing.Size(489, 466);
            ((System.ComponentModel.ISupportInitialize)(this.timeSeriesChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart timeSeriesChart;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.ComboBox rangeComboBox;
        private System.Windows.Forms.Label rangeLabel;
    }
}
