using StockDataDownloader.IO.Interface;
using StockDataDownloader.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StockDataDownloader.IO
{
    public class UsaStockDataCollector : IStockDataCollector
    {
        public void DownloadHistoricalData(string code, DateTime start, DateTime end, Frequency freq)
        {
            var starUnixTime = GetUnixTime(start);
            var endUnixTime = GetUnixTime(end);

            var url = string.Format(@"https://query1.finance.yahoo.com/v7/finance/download/{0}?period1={1}&period2={2}&interval={3}&events=history",
                code, starUnixTime, endUnixTime, GetFreqString(freq));

            try
            {
                var fileName = string.Format(@"Usa\{0}.csv", code);
                Directory.CreateDirectory(Path.GetDirectoryName(fileName));

                using (var web = new WebClient())
                {
                    // csvのダウンロード
                    web.DownloadFile(url, fileName);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static long GetUnixTime(DateTime targetTime)
        {
            //targetTime = targetTime.ToUniversalTime();

            var elapsedTime = targetTime - new DateTime(1970, 1, 1);

            return (long)elapsedTime.TotalSeconds;
        }

        private static string GetFreqString(Frequency freq)
        {
            var freqDic = new Dictionary<Frequency, string>();
            freqDic.Add(Frequency.Daily, "1d");
            freqDic.Add(Frequency.Weeklly, "1wk");
            freqDic.Add(Frequency.Monthly, "1mo");

            return freqDic[freq];
        }
    }
}
