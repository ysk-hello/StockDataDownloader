using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockDataDownloader.UI
{
    public partial class PeriodForm : Form
    {
        public PeriodForm()
        {
            InitializeComponent();
        }

        private void PeriodForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Properties.Settings.Default.IsUpgrade)
                {
                    Properties.Settings.Default.Upgrade();
                    Properties.Settings.Default.IsUpgrade = true;
                }

                dateTimePicker1.Value = Properties.Settings.Default.DownloadStartDate;
                dateTimePicker2.Value = Properties.Settings.Default.DownloadEndDate;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                dateTimePicker2.Value = DateTime.Today;
                dateTimePicker1.Value = dateTimePicker2.Value.AddYears(-1);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.DownloadStartDate = dateTimePicker1.Value;
                Properties.Settings.Default.DownloadEndDate = dateTimePicker2.Value;

                Properties.Settings.Default.Save();

                this.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void button1D_Click(object sender, EventArgs e)
        {

            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker1.Value = dateTimePicker2.Value.AddDays(-1);
        }

        private void button5D_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker1.Value = dateTimePicker2.Value.AddDays(-5);
        }

        private void button3M_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker1.Value = dateTimePicker2.Value.AddMonths(-3);
        }

        private void button6M_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker1.Value = dateTimePicker2.Value.AddMonths(-6);
        }

        private void buttonYTD_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker1.Value = new DateTime(DateTime.Today.Year, 1, 1);
        }

        private void button1Y_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker1.Value = dateTimePicker2.Value.AddYears(-1);
        }

        private void button5Y_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker1.Value = dateTimePicker2.Value.AddYears(-5);
        }

        private void button10Y_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker1.Value = dateTimePicker2.Value.AddYears(-10);
        }

        private void dateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if(dateTimePicker1.Value <= dateTimePicker2.Value)
            {
                errorProvider1.SetError((DateTimePicker)sender, "");
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError((DateTimePicker)sender, "Start Date < End Date");
            }
        }
    }
}
