using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockDataDownloader.IO;

namespace StockDataDownloaderTests
{
    [TestClass]
    public class CompanyReaderTest
    {
        [TestMethod]
        public void 会社を取得する()
        {
            // 正常
            var reader = new CompanyReader("company_14.csv");
            Assert.AreEqual(14, reader.GetCompanies().Count);
        }

        [TestMethod]
        public void 会社を取得する2()
        {
            // 正常: 中身なし
            var reader = new CompanyReader("company_notext.csv");
            Assert.IsNull(reader.GetCompanies());
        }

        [TestMethod]
        public void 会社を取得する3()
        {
            // 異常: ファイルなし
            var reader = new CompanyReader("hogehoge.csv");
            Assert.IsNull(reader.GetCompanies());
        }

        [TestMethod]
        public void 会社を取得する4()
        {
            // 異常: ヘッダーなし
            var reader = new CompanyReader("company_noheader.csv");
            Assert.IsNull(reader.GetCompanies());
        }

        [TestMethod]
        public void 会社を取得する5()
        {
            // 異常: カンマ少ない
            var reader = new CompanyReader("company_c1.csv");
            Assert.IsNull(reader.GetCompanies());
        }

        [TestMethod]
        public void 会社を取得する6()
        {
            // 異常: カンマ多い
            var reader = new CompanyReader("company_c3.csv");
            Assert.IsNull(reader.GetCompanies());
        }
    }
}
