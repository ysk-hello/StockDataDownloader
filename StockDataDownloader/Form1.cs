using StockDataDownloader.IO;
using StockDataDownloader.Model;
using StockDataDownloader.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockDataDownloader
{
    public partial class Form1 : Form
    {
        private const string COMPANY_FILE_NAME = "company.csv";

        private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private List<Company> _companies;

        public Form1()
        {
            InitializeComponent();
        }

        private Country GetCheckedCountry()
        {
            if (日本株ToolStripMenuItem.Checked)
            {
                return Country.JAPAN;
            }
            else
            {
                return Country.USA;
            }
        }

        private void StartBackgroundWorker(Frequency freq)
        {
            try
            {
                toolStripProgressBar1.Value = 0;

                ダウンロードToolStripMenuItem.Enabled = false;
                contextMenuStrip1.Enabled = false;

                backgroundWorker1.RunWorkerAsync(freq);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _logger.Info("start");

                var reader = new CompanyReader(COMPANY_FILE_NAME);
                _companies = reader.GetCompanies();

                dataGridView1.DataSource = _companies.Where(c => c.Country == GetCheckedCountry()).ToList();
            }
            catch (Exception ex)
            {
                _companies = null;
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        private void 日別ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartBackgroundWorker(Frequency.Daily);
        }

        private void 週別ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartBackgroundWorker(Frequency.Weeklly);
        }

        private void 月別ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartBackgroundWorker(Frequency.Monthly);
        }

        private void ダウンロード期間ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new PeriodForm())
            {
                dialog.ShowDialog();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var start = Properties.Settings.Default.DownloadStartDate;
                var end = Properties.Settings.Default.DownloadEndDate;
                var freq = (Frequency)e.Argument;

                var selected = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as Company);

                int count = 0;
                foreach (var company in selected)
                {
                    count++;

                    var collector = StockDataCollectorFactory.CreateStockDataCollector(company.Country);
                    collector.DownloadHistoricalData(company.Code, start, end, freq);
                    backgroundWorker1.ReportProgress((int)((double)count / selected.Count() * 100));
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var percentage = Math.Max(e.ProgressPercentage, 0);
            percentage = Math.Min(percentage, 100);

            toolStripProgressBar1.Value = percentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ダウンロードToolStripMenuItem.Enabled = true;
            contextMenuStrip1.Enabled = true;

            MessageBox.Show("completed");
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new VersionForm())
            {
                dialog.ShowDialog();
            }
        }

        private void 言語ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var groups = new ToolStripMenuItem[]
            {
                日本株ToolStripMenuItem,
                米国株ToolStripMenuItem
            };

            foreach (var g in groups)
            {
                if (object.ReferenceEquals(g, sender))
                {
                    g.CheckState = CheckState.Checked;
                }
                else
                {
                    g.CheckState = CheckState.Unchecked;
                }
            }

            dataGridView1.DataSource = _companies.Where(c => c.Country == GetCheckedCountry()).ToList();
        }

        private void 日別ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StartBackgroundWorker(Frequency.Daily);
        }

        private void 週別ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StartBackgroundWorker(Frequency.Weeklly);
        }

        private void 月別ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StartBackgroundWorker(Frequency.Monthly);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                e.Cancel = true;
                MessageBox.Show("backgroundworker is busy");
            }
        }
    }
}
