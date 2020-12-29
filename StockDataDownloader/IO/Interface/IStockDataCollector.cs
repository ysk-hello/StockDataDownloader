using StockDataDownloader.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataDownloader.IO.Interface
{
    public interface IStockDataCollector
    {
        void DownloadHistoricalData(string code, DateTime start, DateTime end, Frequency freq);
    }
}
