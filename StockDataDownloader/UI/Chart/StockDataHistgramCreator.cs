using MathNet.Numerics.Statistics;
using StockDataDownloader.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSChart = System.Windows.Forms.DataVisualization.Charting;

namespace StockDataDownloader.UI.Chart
{
    public class StockDataHistgramCreator : IChartCreator
    {
        public StockDataHistgramCreator(Company company)
        {
            Company = company;
        }

        public Company Company { get; set; }

        public void CreateChart(MSChart.Chart chart)
        {
            try
            {
                chart.Series.Clear();
                chart.ChartAreas.Clear();
                chart.Titles.Clear();

                var area = new MSChart.ChartArea();
                area.AxisX.Title = "Date";
                area.AxisY.Title = "Frequency";

                var series = new MSChart.Series();
                series.ChartType = MSChart.SeriesChartType.Column;

                var list = ReadData();

                int nBuckets = 10;
                var hist = new Histogram(list, nBuckets, list.Min(), list.Max());

                for (int i = 0; i < nBuckets; i++)
                {
                    var mid = (hist[i].LowerBound + hist[i].UpperBound) / 2.0;
                    series.Points.Add(new MSChart.DataPoint(mid, hist[i].Count));
                }

                chart.ChartAreas.Add(area);
                chart.Series.Add(series);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private List<double> ReadData()
        {
            var list = new List<double>();

            var fileName = string.Empty;
            switch (Company.Country)
            {
                case Country.JAPAN:
                    fileName = string.Format(@"Japan\{0}.csv", Company.Code);
                    break;
                case Country.USA:
                    fileName = string.Format(@"Usa\{0}.csv", Company.Code);
                    break;
                default:
                    throw new NotSupportedException();
            }

            var lines = File.ReadAllLines(fileName).Skip(1);
            foreach (var line in lines)
            {
                var array = line.Split(',');
                var adjClose = double.Parse(array[5]);
                list.Add(adjClose);
            }

            return list;
        }
    }
}
