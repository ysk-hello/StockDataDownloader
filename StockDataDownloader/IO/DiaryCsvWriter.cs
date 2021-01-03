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
    public class DiaryCsvWriter : IDiaryWriter
    {
        private const string DIARY_FILE_NAME_FORMAT = "{0}_diary.csv";

        private static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private string _fileName = string.Empty;

        public DiaryCsvWriter(Company company)
        {
            // コンストラクターで例外は投げない
            if (company == null) return;

            _fileName = Path.Combine(GetDirectoryName(company), string.Format(DIARY_FILE_NAME_FORMAT, company.Code));
        }

        public DiaryCsvWriter(string fileName)
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
        /// 日記データを削除する。
        /// </summary>
        /// <param name="diary"></param>
        /// <exception>指定したデータがない場合、例外発生</exception>
        public void DeleteDiaryData(DiaryData diary)
        {
            try
            {
                var reader = new DiaryCsvReader(_fileName);
                var diaries = reader.ReadAllDiaryData();

                var target = diaries.Single(d => d.Date == diary.Date);

                // 削除
                diaries.Remove(target);
                WriteAllDiaryData(diaries);
            }
            catch (Exception ex)
            {
                _logger.Error(ex.ToString());
                throw;
            }
        }

        /// <summary>
        /// 全日記データを書き込む。
        /// </summary>
        /// <param name="diaries"></param>
        /// <exception>書き込めない場合、例外発生</exception>
        public void WriteAllDiaryData(List<DiaryData> diaries)
        {
            try
            {
                var lines = new List<string>();
                lines.Add("#Date,Text");
                lines.AddRange(diaries.Select(d => string.Format("{0},{1}", d.Date, d.Text)));

                //Directory.CreateDirectory(Path.GetDirectoryName(_fileName));
                File.WriteAllLines(_fileName, lines);
            }
            catch (Exception ex)
            {
                _logger.Error(ex.ToString());
                throw;
            }
        }

        /// <summary>
        /// 日記データを書き込む。
        /// データが存在する場合、上書きする。
        /// </summary>
        /// <param name="diary"></param>
        /// <exception>書き込めない場合、例外発生</exception>
        public void WriteDiaryData(DiaryData diary)
        {
            try
            {
                var reader = new DiaryCsvReader(_fileName);
                var diaries = reader.ReadAllDiaryData() ?? new List<DiaryData>();

                var target = diaries?.SingleOrDefault(d => d.Date == diary.Date);

                if(target != null)
                {
                    // 上書き
                    target.Text = diary.Text;
                }
                else
                {
                    // 追加
                    diaries.Add(diary);
                }

                WriteAllDiaryData(diaries);
            }
            catch (Exception ex)
            {
                _logger.Error(ex.ToString());
                throw;
            }
        }
    }
}
