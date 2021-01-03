using StockDataDownloader.IO.Interface;
using StockDataDownloader.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataDownloader.IO
{
    public class DiaryCsvReader : IDiaryReader
    {
        private const string DIARY_FILE_NAME_FORMAT = "{0}_diary.csv";

        private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private string _fileName = string.Empty;

        public DiaryCsvReader(Company company)
        {
            // コンストラクターで例外は投げない
            if (company == null) return;

            _fileName = Path.Combine(GetDirectoryName(company), string.Format(DIARY_FILE_NAME_FORMAT, company.Code));
        }

        public DiaryCsvReader(string fileName)
        {
            _fileName = fileName;
        }

        private static string GetDirectoryName(Company company)
        {
            switch (company.Country)
            {
                case Country.JAPAN:
                    return @"Japan\Diary";
                case Country.USA:
                    return @"Usa\Diary";
                default:
                    throw new NotSupportedException();
            }
        }

        /// <summary>
        /// 日記データを取得する。
        /// </summary>
        /// <returns>例外の場合、nullを返す。
        /// ファイルがない場合、nullを返す。</returns>
        public List<DiaryData> ReadAllDiaryData()
        {
            //if (!File.Exists(_fileName)) return null;

            var diaries = new List<DiaryData>();

            try
            {
                var lines = File.ReadLines(_fileName).Skip(1);
                foreach (var line in lines)
                {
                    var array = line.Split(',');
                    diaries.Add(new DiaryData{ 
                        Date = DateTime.Parse(array[0]),
                        Text = array[1]
                    });
                }

                return diaries;
            }
            catch (Exception ex)
            {
                _logger.Error(ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// 日記データを取得する。
        /// </summary>
        /// <param name="date"></param>
        /// <returns>例外の場合、nullを返す。
        /// 指定した日付のデータがない場合、nullを返す。
        /// ファイルがない場合、nullを返す。</returns>
        public DiaryData ReadDiaryData(DateTime date)
        {
            try
            {
                var diaries = ReadAllDiaryData();
                return diaries.SingleOrDefault(d => d.Date == date);
            }
            catch (Exception ex)
            {
                _logger.Error(ex.ToString());
                return null;
            }
        }
    }
}
