using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataDownloader.Model
{
    public class DiaryDataEventArgs : EventArgs
    {
        public DiaryDataEventArgs(DateTime date, string text)
        {
            DiaryData = new DiaryData { Date = date, Text = text };
        }

        public DiaryData DiaryData { get; private set; }
    }
}
