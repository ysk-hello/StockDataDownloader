using StockDataDownloader.Model;
using StockDataDownloader.UI.Chart;
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
    public partial class DiaryChartForm : Form
    {
        public DiaryChartForm(Company company)
        {
            InitializeComponent();

            this.Text = string.Format("{0}({1})", company.Name, company.Code);

            diaryControl1.Init(company);
            diaryControl1.DiaryDataSelected += DiaryControl1_DiaryDataSelected;

            timeSeriesControl1.Init(company);
        }

        private void DiaryControl1_DiaryDataSelected(object sender, Model.DiaryDataEventArgs e)
        {
            timeSeriesControl1.PlotHairline(e.DiaryData);

            hairlineDataControl1.SetHairlineData(timeSeriesControl1.GetHairlineData());
        }
    }
}
