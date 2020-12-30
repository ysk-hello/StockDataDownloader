using StockDataDownloader.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSChart = System.Windows.Forms.DataVisualization.Charting;

namespace StockDataDownloader.UI.Chart
{
    public interface IChartCreator
    {
        Company Company { get; set; }
        void CreateChart(MSChart.Chart chart);
    }
}
