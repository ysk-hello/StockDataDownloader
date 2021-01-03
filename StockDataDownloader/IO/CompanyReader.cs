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
    public class CompanyReader : ICompanyReader
    {
        private string _fileName;

        public CompanyReader(string fileName)
        {
            _fileName = fileName;
        }

        public List<Company> GetCompanies()
        {
            try
            {
                // ファイルなし
                if (!File.Exists(_fileName)) return null;

                var allLines = File.ReadAllLines(_fileName);
                
                var header = allLines.First();
                // ヘッダーなし
                if (!header.StartsWith("#")) return null;

                var lines = allLines.Skip(1);
                
                var companies = new List<Company>();
                foreach (var line in lines)
                {
                    var array = line.Split(',');
                    // データ不適切
                    if (array.Length != header.Split(',').Length) return null;

                    companies.Add(new Company { 
                        Country = (Country)Enum.Parse(typeof(Country), array[0]), 
                        Code = array[1].Trim(), 
                        Name = array[2].Trim() });
                }

                return companies;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                return null;
            }
        }
    }
}
