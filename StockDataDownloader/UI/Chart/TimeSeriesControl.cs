using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSChart = System.Windows.Forms.DataVisualization.Charting;
using StockDataDownloader.Model;

namespace StockDataDownloader.UI.Chart
{
    public partial class TimeSeriesControl : UserControl
    {
        private MovingAverageLineChartCreator _creator;

        public TimeSeriesControl()
        {
            InitializeComponent();

            var ranges = new List<XRange>();
            ranges.Add(new XRange(1, RangeUnit.Month));
            ranges.Add(new XRange(3, RangeUnit.Month));
            ranges.Add(new XRange(5, RangeUnit.Month));
            ranges.Add(new XRange(1, RangeUnit.Year));

            rangeComboBox.DisplayMember = nameof(XRange.DisplayName);
            rangeComboBox.ValueMember = nameof(XRange.Months);
            rangeComboBox.DataSource = ranges;
        }

        public void Init(Company company)
        {
            _creator = new MovingAverageLineChartCreator(company);
            _creator.CreateChart(timeSeriesChart);
        }

        public void PlotHairline(DiaryData diary)
        {
            if (_creator == null) return;

            _creator.PlotHairline(timeSeriesChart, diary);
        }

        public List<PlotData> GetHairlineData()
        {
            if (_creator == null) return new List<PlotData>();

            return _creator.GetHairlineData(timeSeriesChart);
        }

        private void rangeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_creator == null) return;

            var selectedMonth = (int)rangeComboBox.SelectedValue;

            _creator.ChangeXAxisMin(timeSeriesChart, selectedMonth);
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            _creator.ChangeXAxisMinMax(timeSeriesChart, -1);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            _creator.ChangeXAxisMinMax(timeSeriesChart, 1);
        }
    }
}
