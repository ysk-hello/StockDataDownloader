using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StockDataDownloader.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // https://www.atmarkit.co.jp/ait/articles/1804/25/news021.html#common
        // ref: 参照渡し。呼び出す前の初期化必須。
        // out: 参照渡し。呼び出す前の初期化不要。

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName]string propName = "")
        {
            if(Equals(field, value))
            {
                return false;
            }

            field = value;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }

            return true;
        }
    }
}
