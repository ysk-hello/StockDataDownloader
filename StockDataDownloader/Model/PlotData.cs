using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataDownloader.Model
{
    public class PlotData
    {
        public PlotData(DateTime date, string name, double value)
        {
            Date = date;
            Name = name;
            Value = value;
        }

        public DateTime Date { get; private set; }

        public string Name { get; private set; }

        public double Value { get; private set; }
    }
}
