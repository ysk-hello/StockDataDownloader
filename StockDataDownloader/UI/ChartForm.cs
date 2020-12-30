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
    public partial class ChartForm : Form
    {
        private IChartCreator _creator;

        public ChartForm()
        {
            InitializeComponent();
        }

        public ChartForm(IChartCreator creator) : this()
        {
            _creator = creator;
            this.Text = string.Format("{0}({1})", creator.Company.Name, creator.Company.Code);
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            _creator.CreateChart(chart1);
        }
    }
}
