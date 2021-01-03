using StockDataDownloader.IO;
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
        public DiaryControlView(Company company)
        {
            try
            {
                Company = company;

                var reader = new DiaryCsvReader(Company);
                Diaries = new BindingList<DiaryData>(
                    reader.ReadAllDiaryData().OrderByDescending(d => d.Date).ToList() ?? new List<DiaryData>());
            }
            catch (Exception)
            {
                Diaries = new BindingList<DiaryData>();
            }
        }

        public Company Company { get; private set; }

        public BindingList<DiaryData> Diaries { get; set; }

        public void Delete(DiaryData diary)
        {
            var writer = new DiaryCsvWriter(Company);
            // 削除
            writer.DeleteDiaryData(diary);
            Diaries.Remove(diary);
        }
    }
}
