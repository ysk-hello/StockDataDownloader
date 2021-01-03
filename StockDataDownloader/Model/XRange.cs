using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataDownloader.Model
{
    public enum RangeUnit
    {
        Month = 10,
        Year = 15,
    }

    public class XRange
    {
        public XRange(int value, RangeUnit unit)
        {
            Value = value;
            Unit = unit;
        }

        public int Value { get; set; }

        public RangeUnit Unit { get; set; }

        public string DisplayName { get { return ToString(); } }

        public int Months { get { return GetMonths(); } }

        public override string ToString()
        {
            switch (Unit)
            {
                case RangeUnit.Month:
                    return string.Format("{0} {1}", Value, "か月");
                case RangeUnit.Year:
                    return string.Format("{0} {1}", Value, "年");
                default:
                    throw new NotSupportedException();
            }
        }

        public int GetMonths()
        {
            switch (Unit)
            {
                case RangeUnit.Month:
                    return Value;
                case RangeUnit.Year:
                    return Value * 12;
                default:
                    throw new NotSupportedException();
            }
        }

    }
}
