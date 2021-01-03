using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSChart = System.Windows.Forms.DataVisualization.Charting;

namespace StockDataDownloader.UI.Chart
{
    public interface IXAxis
    {
        void ChangeXAxisMinMax(MSChart.Chart chart, int day);

        void ChangeXAxisMin(MSChart.Chart chart, int month);
    }
}
