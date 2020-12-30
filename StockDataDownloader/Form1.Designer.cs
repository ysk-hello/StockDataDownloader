namespace StockDataDownloader
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ダウンロードToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日別ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.週別ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.月別ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ダウンロード期間ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日本株ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.米国株ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.チャートToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.株価の分布ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日当たりの変化量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.日別ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.週別ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.月別ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.移動平均ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.前日比の分布ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ダウンロードToolStripMenuItem,
            this.表示ToolStripMenuItem,
            this.チャートToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ダウンロードToolStripMenuItem
            // 
            this.ダウンロードToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.日別ToolStripMenuItem,
            this.週別ToolStripMenuItem,
            this.月別ToolStripMenuItem,
            this.toolStripSeparator1,
            this.ダウンロード期間ToolStripMenuItem});
            this.ダウンロードToolStripMenuItem.Name = "ダウンロードToolStripMenuItem";
            this.ダウンロードToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ダウンロードToolStripMenuItem.Text = "ダウンロード";
            // 
            // 日別ToolStripMenuItem
            // 
            this.日別ToolStripMenuItem.Name = "日別ToolStripMenuItem";
            this.日別ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.日別ToolStripMenuItem.Text = "日別";
            this.日別ToolStripMenuItem.Click += new System.EventHandler(this.日別ToolStripMenuItem_Click);
            // 
            // 週別ToolStripMenuItem
            // 
            this.週別ToolStripMenuItem.Name = "週別ToolStripMenuItem";
            this.週別ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.週別ToolStripMenuItem.Text = "週別";
            this.週別ToolStripMenuItem.Click += new System.EventHandler(this.週別ToolStripMenuItem_Click);
            // 
            // 月別ToolStripMenuItem
            // 
            this.月別ToolStripMenuItem.Name = "月別ToolStripMenuItem";
            this.月別ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.月別ToolStripMenuItem.Text = "月別";
            this.月別ToolStripMenuItem.Click += new System.EventHandler(this.月別ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // ダウンロード期間ToolStripMenuItem
            // 
            this.ダウンロード期間ToolStripMenuItem.Name = "ダウンロード期間ToolStripMenuItem";
            this.ダウンロード期間ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ダウンロード期間ToolStripMenuItem.Text = "ダウンロード期間";
            this.ダウンロード期間ToolStripMenuItem.Click += new System.EventHandler(this.ダウンロード期間ToolStripMenuItem_Click);
            // 
            // 表示ToolStripMenuItem
            // 
            this.表示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.日本株ToolStripMenuItem,
            this.米国株ToolStripMenuItem});
            this.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem";
            this.表示ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.表示ToolStripMenuItem.Text = "表示";
            // 
            // 日本株ToolStripMenuItem
            // 
            this.日本株ToolStripMenuItem.Checked = true;
            this.日本株ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.日本株ToolStripMenuItem.Name = "日本株ToolStripMenuItem";
            this.日本株ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.日本株ToolStripMenuItem.Text = "日本株";
            this.日本株ToolStripMenuItem.Click += new System.EventHandler(this.言語ToolStripMenuItem_Click);
            // 
            // 米国株ToolStripMenuItem
            // 
            this.米国株ToolStripMenuItem.Name = "米国株ToolStripMenuItem";
            this.米国株ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.米国株ToolStripMenuItem.Text = "米国株";
            this.米国株ToolStripMenuItem.Click += new System.EventHandler(this.言語ToolStripMenuItem_Click);
            // 
            // チャートToolStripMenuItem
            // 
            this.チャートToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.移動平均ToolStripMenuItem,
            this.株価の分布ToolStripMenuItem,
            this.前日比の分布ToolStripMenuItem,
            this.日当たりの変化量ToolStripMenuItem});
            this.チャートToolStripMenuItem.Name = "チャートToolStripMenuItem";
            this.チャートToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.チャートToolStripMenuItem.Text = "チャート";
            // 
            // 株価の分布ToolStripMenuItem
            // 
            this.株価の分布ToolStripMenuItem.Name = "株価の分布ToolStripMenuItem";
            this.株価の分布ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.株価の分布ToolStripMenuItem.Text = "株価の分布";
            this.株価の分布ToolStripMenuItem.Click += new System.EventHandler(this.株価の分布ToolStripMenuItem_Click);
            // 
            // 日当たりの変化量ToolStripMenuItem
            // 
            this.日当たりの変化量ToolStripMenuItem.Name = "日当たりの変化量ToolStripMenuItem";
            this.日当たりの変化量ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.日当たりの変化量ToolStripMenuItem.Text = "1日の変化量";
            this.日当たりの変化量ToolStripMenuItem.Click += new System.EventHandler(this.日の変化量ToolStripMenuItem_Click);
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報ToolStripMenuItem});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // バージョン情報ToolStripMenuItem
            // 
            this.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            this.バージョン情報ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.バージョン情報ToolStripMenuItem.Text = "バージョン情報";
            this.バージョン情報ToolStripMenuItem.Click += new System.EventHandler(this.バージョン情報ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 325);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(531, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(531, 301);
            this.dataGridView1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.日別ToolStripMenuItem1,
            this.週別ToolStripMenuItem1,
            this.月別ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 70);
            // 
            // 日別ToolStripMenuItem1
            // 
            this.日別ToolStripMenuItem1.Name = "日別ToolStripMenuItem1";
            this.日別ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.日別ToolStripMenuItem1.Text = "日別";
            this.日別ToolStripMenuItem1.Click += new System.EventHandler(this.日別ToolStripMenuItem1_Click);
            // 
            // 週別ToolStripMenuItem1
            // 
            this.週別ToolStripMenuItem1.Name = "週別ToolStripMenuItem1";
            this.週別ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.週別ToolStripMenuItem1.Text = "週別";
            this.週別ToolStripMenuItem1.Click += new System.EventHandler(this.週別ToolStripMenuItem1_Click);
            // 
            // 月別ToolStripMenuItem1
            // 
            this.月別ToolStripMenuItem1.Name = "月別ToolStripMenuItem1";
            this.月別ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.月別ToolStripMenuItem1.Text = "月別";
            this.月別ToolStripMenuItem1.Click += new System.EventHandler(this.月別ToolStripMenuItem1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // 移動平均ToolStripMenuItem
            // 
            this.移動平均ToolStripMenuItem.Name = "移動平均ToolStripMenuItem";
            this.移動平均ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.移動平均ToolStripMenuItem.Text = "移動平均";
            this.移動平均ToolStripMenuItem.Click += new System.EventHandler(this.移動平均ToolStripMenuItem_Click);
            // 
            // 前日比の分布ToolStripMenuItem
            // 
            this.前日比の分布ToolStripMenuItem.Name = "前日比の分布ToolStripMenuItem";
            this.前日比の分布ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.前日比の分布ToolStripMenuItem.Text = "前日比の分布";
            this.前日比の分布ToolStripMenuItem.Click += new System.EventHandler(this.前日比の分布ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 347);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ダウンロードToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日別ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 週別ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 月別ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日本株ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 米国株ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ダウンロード期間ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 日別ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 週別ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 月別ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem チャートToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日当たりの変化量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 株価の分布ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移動平均ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 前日比の分布ToolStripMenuItem;
    }
}

