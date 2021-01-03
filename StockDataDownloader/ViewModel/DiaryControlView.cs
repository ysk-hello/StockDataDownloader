using StockDataDownloader.IO;
using StockDataDownloader.IO.Interface;
using StockDataDownloader.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataDownloader.ViewModel
{
    public class DiaryControlView : ViewModelBase
    {
        private IDiaryWriter _writer;

        /// <summary>
        /// テスト要コンストラクター
        /// </summary>
        /// <param name="company"></param>
        /// <param name="reader"></param>
        public DiaryControlView(Company company, IDiaryReader reader, IDiaryWriter writer)
        {
            try
            {
                Company = company;
                _writer = writer;

                Diaries = new BindingList<DiaryData>(
                    reader.ReadAllDiaryData().OrderByDescending(d => d.Date).ToList() ?? new List<DiaryData>());
            }
            catch (Exception)
            {
                Diaries = new BindingList<DiaryData>();
            }
        }

        public DiaryControlView(Company company) : this(company, new DiaryCsvReader(company), new DiaryCsvWriter(company))
        {
        }

        public Company Company { get; private set; }

        public BindingList<DiaryData> Diaries { get; set; }

        public void Delete(DiaryData diary)
        {
            // 削除
            _writer.DeleteDiaryData(diary);
            Diaries.Remove(diary);
        }
    }
}
