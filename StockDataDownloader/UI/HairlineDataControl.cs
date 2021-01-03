using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockDataDownloader.Model;

namespace StockDataDownloader.UI
{
    public partial class HairlineDataControl : UserControl
    {
        public HairlineDataControl()
        {
            InitializeComponent();
        }

        public void SetHairlineData(List<PlotData> data)
        {
            dataGridView1.DataSource = data; ;
            dataGridView1.Columns[nameof(PlotData.Value)].DefaultCellStyle.Format = "#,0.0";
        }
    }
}
