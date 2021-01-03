using StockDataDownloader.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataDownloader.IO.Interface
{
    public interface IDiaryWriter
    {
        void DeleteDiaryData(DiaryData diary);

        void WriteDiaryData(DiaryData diary);

        void WriteAllDiaryData(List<DiaryData> diaries);
    }
}
