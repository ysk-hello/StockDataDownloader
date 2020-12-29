using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataDownloader.Model
{
    public class HistoricalData
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public double Open { get; set; }

        public double High { get; set; }

        public double Low { get; set; }

        public double Close { get; set; }

        public double AdjClose { get; set; }

        public double Volume { get; set; }

        public string ToHeader()
        {
            var array = new string[] { "Date", "Open", 
                "High", "Low",
                "Close", "AdjClose", "Volume" };

            return string.Join(",", array);
        }

        public override string ToString()
        {
            var array = new string[] { Date.ToString(), Open.ToString(),
                High.ToString(), Low.ToString(),
                Close.ToString(), AdjClose.ToString(), Volume.ToString() };

            return string.Join(",", array);
        }
    }

}
