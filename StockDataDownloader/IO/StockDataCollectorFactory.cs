using StockDataDownloader.IO.Interface;
using StockDataDownloader.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataDownloader.IO
{
    public static class StockDataCollectorFactory
    {
        public static IStockDataCollector CreateStockDataCollector(Country country)
        {
            switch (country)
            {
                case Country.JAPAN:
                    return new JpnStockDataCollector();
                case Country.USA:
                    return new UsaStockDataCollector();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
