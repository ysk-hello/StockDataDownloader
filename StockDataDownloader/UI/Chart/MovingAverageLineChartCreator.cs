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
    public class MovingAverageLineChartCreator : IChartCreator
    {
        public MovingAverageLineChartCreator(Company company)
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
                area.AxisY.Title = "Price";

                var series = new MSChart.Series("raw");
                series.ChartType = MSChart.SeriesChartType.Line;
                series.XValueType = MSChart.ChartValueType.Date;

                var list = ReadData();

                foreach (var data in list)
                {
                    series.Points.AddXY(data.Date.ToOADate(), data.AdjClose);
                }

                chart.ChartAreas.Add(area);

                chart.Series.Add(series);
                chart.Series.Add(CreateSeriesMA(5));
                chart.Series.Add(CreateSeriesMA(25));
                chart.Series.Add(CreateSeriesMA(75));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private MSChart.Series CreateSeriesMA(int n)
        {
            var seriesMA = new MSChart.Series(string.Format("MA({0})", n));
            seriesMA.ChartType = MSChart.SeriesChartType.Line;
            seriesMA.XValueType = MSChart.ChartValueType.Date;

            var maList = CalcMovingAverage(n);

            foreach (var ma in maList)
            {
                seriesMA.Points.AddXY(ma.Date.ToOADate(), ma.AdjClose);
            }

            return seriesMA;
        }

        private List<HistoricalData> CalcMovingAverage(int n)
        {
            var data = ReadData();

            var list = new List<HistoricalData>();

            for (int i = 0; i <= data.Count() - n; i++)
            {
                list.Add(new HistoricalData {
                    Code = data[i].Code,
                    Name = data[i].Name,
                    Date = data[i + n - 1].Date,
                    AdjClose = data.Skip(i).Take(n).Select(d => d.AdjClose).Average()
                });
            }

            return list;
        }

        private List<HistoricalData> ReadData()
        {
            var list = new List<HistoricalData>();

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
                list.Add(new HistoricalData
                {
                    Code = Company.Code,
                    Name = Company.Name,
                    Date = DateTime.Parse(array[0]),
                    Open = double.Parse(array[1]),
                    High = double.Parse(array[2]),
                    Low = double.Parse(array[3]),
                    Close = double.Parse(array[4]),
                    AdjClose = double.Parse(array[5]),
                    Volume = double.Parse(array[6]),
                });
            }

            return list;
        }
    }
}
