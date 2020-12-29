using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataDownloader.Model
{
    public class Company
    {
        public Country Country { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }
    }
}
