namespace StockDataDownloader.UI
{
    partial class PeriodForm
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
            this.button1D = new System.Windows.Forms.Button();
            this.button5D = new System.Windows.Forms.Button();
            this.button3M = new System.Windows.Forms.Button();
            this.button6M = new System.Windows.Forms.Button();
            this.buttonYTD = new System.Windows.Forms.Button();
            this.button1Y = new System.Windows.Forms.Button();
            this.button5Y = new System.Windows.Forms.Button();
            this.button10Y = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1D
            // 
            this.button1D.Location = new System.Drawing.Point(12, 12);
            this.button1D.Name = "button1D";
            this.button1D.Size = new System.Drawing.Size(75, 23);
            this.button1D.TabIndex = 0;
            this.button1D.Text = "1D";
            this.button1D.UseVisualStyleBackColor = true;
            this.button1D.Click += new System.EventHandler(this.button1D_Click);
            // 
            // button5D
            // 
            this.button5D.Location = new System.Drawing.Point(103, 11);
            this.button5D.Name = "button5D";
            this.button5D.Size = new System.Drawing.Size(75, 23);
            this.button5D.TabIndex = 1;
            this.button5D.Text = "5D";
            this.button5D.UseVisualStyleBackColor = true;
            this.button5D.Click += new System.EventHandler(this.button5D_Click);
            // 
            // button3M
            // 
            this.button3M.Location = new System.Drawing.Point(193, 11);
            this.button3M.Name = "button3M";
            this.button3M.Size = new System.Drawing.Size(75, 23);
            this.button3M.TabIndex = 2;
            this.button3M.Text = "3M";
            this.button3M.UseVisualStyleBackColor = true;
            this.button3M.Click += new System.EventHandler(this.button3M_Click);
            // 
            // button6M
            // 
            this.button6M.Location = new System.Drawing.Point(284, 11);
            this.button6M.Name = "button6M";
            this.button6M.Size = new System.Drawing.Size(75, 23);
            this.button6M.TabIndex = 3;
            this.button6M.Text = "6M";
            this.button6M.UseVisualStyleBackColor = true;
            this.button6M.Click += new System.EventHandler(this.button6M_Click);
            // 
            // buttonYTD
            // 
            this.buttonYTD.Location = new System.Drawing.Point(12, 51);
            this.buttonYTD.Name = "buttonYTD";
            this.buttonYTD.Size = new System.Drawing.Size(75, 23);
            this.buttonYTD.TabIndex = 4;
            this.buttonYTD.Text = "YTD";
            this.buttonYTD.UseVisualStyleBackColor = true;
            this.buttonYTD.Click += new System.EventHandler(this.buttonYTD_Click);
            // 
            // button1Y
            // 
            this.button1Y.Location = new System.Drawing.Point(103, 51);
            this.button1Y.Name = "button1Y";
            this.button1Y.Size = new System.Drawing.Size(75, 23);
            this.button1Y.TabIndex = 5;
            this.button1Y.Text = "1Y";
            this.button1Y.UseVisualStyleBackColor = true;
            this.button1Y.Click += new System.EventHandler(this.button1Y_Click);
            // 
            // button5Y
            // 
            this.button5Y.Location = new System.Drawing.Point(193, 51);
            this.button5Y.Name = "button5Y";
            this.button5Y.Size = new System.Drawing.Size(75, 23);
            this.button5Y.TabIndex = 6;
            this.button5Y.Text = "5Y";
            this.button5Y.UseVisualStyleBackColor = true;
            this.button5Y.Click += new System.EventHandler(this.button5Y_Click);
            // 
            // button10Y
            // 
            this.button10Y.Location = new System.Drawing.Point(284, 51);
            this.button10Y.Name = "button10Y";
            this.button10Y.Size = new System.Drawing.Size(75, 23);
            this.button10Y.TabIndex = 7;
            this.button10Y.Text = "10Y";
            this.button10Y.UseVisualStyleBackColor = true;
            this.button10Y.Click += new System.EventHandler(this.button10Y_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(193, 168);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(284, 168);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker_Validating);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(103, 129);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "End Date";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PeriodForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(377, 206);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.button10Y);
            this.Controls.Add(this.button5Y);
            this.Controls.Add(this.button1Y);
            this.Controls.Add(this.buttonYTD);
            this.Controls.Add(this.button6M);
            this.Controls.Add(this.button3M);
            this.Controls.Add(this.button5D);
            this.Controls.Add(this.button1D);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PeriodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PeriodForm";
            this.Load += new System.EventHandler(this.PeriodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1D;
        private System.Windows.Forms.Button button5D;
        private System.Windows.Forms.Button button3M;
        private System.Windows.Forms.Button button6M;
        private System.Windows.Forms.Button buttonYTD;
        private System.Windows.Forms.Button button1Y;
        private System.Windows.Forms.Button button5Y;
        private System.Windows.Forms.Button button10Y;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}