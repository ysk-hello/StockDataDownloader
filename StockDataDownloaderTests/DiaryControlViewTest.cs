using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StockDataDownloader.IO;
using StockDataDownloader.IO.Interface;
using StockDataDownloader.Model;
using StockDataDownloader.ViewModel;

namespace StockDataDownloaderTests
{
    [TestClass]
    public class DiaryControlViewTest
    {
        [TestMethod]
        public void ViewModelのテスト()
        {
            var reader = new Mock<IDiaryReader>();
            var writer = new Mock<IDiaryWriter>();

            var list = new List<DiaryData>();
            list.Add(new DiaryData { Date = DateTime.Today, Text = "test0"});
            list.Add(new DiaryData { Date = DateTime.Today.AddDays(-1), Text = "test1" });
            list.Add(new DiaryData { Date = DateTime.Today.AddDays(-2), Text = "test2" });

            reader.Setup(x => x.ReadAllDiaryData()).Returns(list);

            var company = new Company { Code = "1111", Country = Country.JAPAN, Name = "hogehoge" };

            var vm = new DiaryControlView(company, reader.Object, writer.Object);

            Assert.AreEqual("hogehoge", vm.Company.Name);

            Assert.AreEqual(3, vm.Diaries.Count);
            Assert.AreEqual("test0", vm.Diaries[0].Text);
            Assert.AreEqual("test1", vm.Diaries[1].Text);
            Assert.AreEqual("test2", vm.Diaries[2].Text);

            vm.Delete(list[1]);
            Assert.AreEqual(2, vm.Diaries.Count);
            Assert.AreEqual("test0", vm.Diaries[0].Text);
            Assert.AreEqual("test2", vm.Diaries[1].Text);
        }
    }
}
