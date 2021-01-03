using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSChart = System.Windows.Forms.DataVisualization.Charting;

namespace StockDataDownloader.UI.Chart
{
    public class TestChart : MSChart.Chart
    {
        public TestChart()
        {
            OnCursorChanged(EventArgs.Empty);
        }
    }
}
