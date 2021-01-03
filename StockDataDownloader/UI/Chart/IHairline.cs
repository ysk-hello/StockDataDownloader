using StockDataDownloader.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSChart = System.Windows.Forms.DataVisualization.Charting;

namespace StockDataDownloader.UI.Chart
{
    public interface IHairline
    {
        void PlotHairline(MSChart.Chart chart, DiaryData diary);

        List<PlotData> GetHairlineData(MSChart.Chart chart);
    }
}
