﻿using StockDataDownloader.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataDownloader.IO.Interface
{
    public interface IDiaryReader
    {
        DiaryData ReadDiaryData(DateTime date);

        List<DiaryData> ReadAllDiaryData();
    }
}
