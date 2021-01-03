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
    public class MovingAverageLineChartCreator : IChartCreator, IHairline, IXAxis
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

        public void PlotHairline(MSChart.Chart chart, DiaryData diary)
        {
            //chart.ChartAreas[0].CursorX.IsUserEnabled = true;
            // ↓CursorPositonChangedが発生するようになる
            //chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;

            //chart.ChartAreas[0].CursorX.Position = diary.Date.ToOADate();
            chart.ChartAreas[0].CursorX.SetCursorPosition(diary.Date.ToOADate());
            //chart.ChartAreas[0].CursorX.Interval = 1E-3;
        }

        public List<PlotData> GetHairlineData(MSChart.Chart chart)
        {
            var x = chart.ChartAreas[0].CursorX.Position;
            var date = DateTime.FromOADate(x);

            var list = new List<PlotData>();
            for (int i = 0; i < chart.Series.Count(); i++)
            {
                var points = chart.Series[i].Points;
                if (points.Count() != 0)
                {
                    var y = points.FindByValue(x, "X")?.YValues[0] ?? double.NaN;
                    list.Add(new PlotData(date, chart.Series[i].Name, y));
                }
                else
                {
                    list.Add(new PlotData(date, chart.Series[i].Name, double.NaN));
                }
            }

            return list;
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

            if (!File.Exists(fileName)) return list;

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

        public void ChangeXAxisMinMax(MSChart.Chart chart, int day)
        {
            var minDate = DateTime.FromOADate(chart.ChartAreas[0].AxisX.Minimum);
            var maxDate = DateTime.FromOADate(chart.ChartAreas[0].AxisX.Maximum);

            chart.ChartAreas[0].AxisX.Minimum = minDate.AddDays(day).ToOADate();
            chart.ChartAreas[0].AxisX.Maximum = maxDate.AddDays(day).ToOADate();
        }

        public void ChangeXAxisMin(MSChart.Chart chart, int month)
        {
            var max = chart.ChartAreas[0].AxisX.Maximum;
            if (double.IsNaN(max)) return;

            var maxDate = DateTime.FromOADate(max);

            chart.ChartAreas[0].AxisX.Minimum = maxDate.AddMonths(-month).ToOADate();
        }
    }
}
