namespace StockDataDownloader.UI
{
    partial class DiaryChartForm
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
            this.diaryControl1 = new StockDataDownloader.UI.DiaryControl();
            this.hairlineDataControl1 = new StockDataDownloader.UI.HairlineDataControl();
            this.timeSeriesControl1 = new StockDataDownloader.UI.Chart.TimeSeriesControl();
            this.SuspendLayout();
            // 
            // diaryControl1
            // 
            this.diaryControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diaryControl1.Location = new System.Drawing.Point(441, 1);
            this.diaryControl1.Name = "diaryControl1";
            this.diaryControl1.Size = new System.Drawing.Size(359, 515);
            this.diaryControl1.TabIndex = 3;
            // 
            // hairlineDataControl1
            // 
            this.hairlineDataControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hairlineDataControl1.Location = new System.Drawing.Point(2, 397);
            this.hairlineDataControl1.Name = "hairlineDataControl1";
            this.hairlineDataControl1.Size = new System.Drawing.Size(433, 119);
            this.hairlineDataControl1.TabIndex = 2;
            // 
            // timeSeriesControl1
            // 
            this.timeSeriesControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeSeriesControl1.Location = new System.Drawing.Point(2, 1);
            this.timeSeriesControl1.Name = "timeSeriesControl1";
            this.timeSeriesControl1.Size = new System.Drawing.Size(433, 390);
            this.timeSeriesControl1.TabIndex = 0;
            // 
            // DiaryChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.diaryControl1);
            this.Controls.Add(this.hairlineDataControl1);
            this.Controls.Add(this.timeSeriesControl1);
            this.Name = "DiaryChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DiaryChartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Chart.TimeSeriesControl timeSeriesControl1;
        private HairlineDataControl hairlineDataControl1;
        private DiaryControl diaryControl1;
    }
}