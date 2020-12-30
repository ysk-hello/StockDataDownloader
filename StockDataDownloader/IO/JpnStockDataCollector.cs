using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using StockDataDownloader.IO.Interface;
using StockDataDownloader.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StockDataDownloader.IO
{
    public class JpnStockDataCollector : IStockDataCollector
    {
        public void DownloadHistoricalData(string code, DateTime start, DateTime end, Frequency freq)
        {
            IHtmlDocument doc;
            int page = 1;

            var list = new List<HistoricalData>();

            while (true)
            {
                // URL
                var url = string.Format("https://info.finance.yahoo.co.jp/history/" +
                    "?code={0}" +
                    "&sy={1}&sm={2}&sd={3}" +
                    "&ey={4}&em={5}&ed={6}" +
                    "&tm={7}" +
                    "&p={8}",
                    code,
                    start.Year, start.Month, start.Day,
                    end.Year, end.Month, end.Day,
                    GetFreqString(freq),
                    page++);

                try
                {
                    using (var client = new HttpClient())
                    using (var stream = client.GetStreamAsync(url).Result)
                    {
                        var parser = new HtmlParser();
                        doc = parser.ParseDocumentAsync(stream).Result;
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.ToString());
                    throw;
                }

                try
                {
                    // 行
                    var trs = doc.QuerySelectorAll(@"#main > div.padT12.marB10.clearFix > table > tbody > tr");

                    // データがなくなったらbreak
                    // ヘッダーだけ
                    if (trs.Length == 1) break;

                    // ヘッダーをスキップ
                    foreach (var tr in trs.Skip(1))
                    {
                        // 列
                        var tds = tr.QuerySelectorAll(@"td");

                        if (tds.Length != 7)
                        {
                            System.Diagnostics.Debug.WriteLine("count: " + tds.Length);
                            continue;
                        }

                        list.Add(new HistoricalData
                        {
                            Code = code,
                            Date = DateTime.Parse(tds[0].TextContent),
                            Open = double.Parse(tds[1].TextContent),
                            High = double.Parse(tds[2].TextContent),
                            Low = double.Parse(tds[3].TextContent),
                            Close = double.Parse(tds[4].TextContent),
                            AdjClose = double.Parse(tds[5].TextContent),
                            Volume = double.Parse(tds[6].TextContent)
                        });
                    }

                    System.Threading.Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    // 株式分割
                    System.Diagnostics.Debug.WriteLine(code);
                    System.Diagnostics.Debug.WriteLine(start.Date);
                    System.Diagnostics.Debug.WriteLine(end.Date);
                    System.Diagnostics.Debug.WriteLine(page);
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
            }

            WriteToCsv(list);
        }

        private static string GetFreqString(Frequency freq)
        {
            var freqDic = new Dictionary<Frequency, string>();
            freqDic.Add(Frequency.Daily, "d");
            freqDic.Add(Frequency.Weeklly, "w");
            freqDic.Add(Frequency.Monthly, "m");

            return freqDic[freq];
        }

        private static void WriteToCsv(List<HistoricalData> list)
        {
            try
            {
                var code = list.First().Code;
                var header = list.First().ToHeader();

                var fileName = @"Japan\{0}.csv";
                Directory.CreateDirectory(Path.GetDirectoryName(fileName));

                // csv出力
                using (var sw = new StreamWriter(string.Format(fileName, code)))
                {
                    // ヘッダー
                    sw.WriteLine(header);

                    foreach (var d in list.OrderBy(d => d.Date))
                    {
                        sw.WriteLine(d.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}
