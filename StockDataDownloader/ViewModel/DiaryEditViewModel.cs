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
    public class DiaryEditViewModel : ViewModelBase
    {
        private Company _company;

        private DiaryData _diary;

        public DiaryEditViewModel(Company company, DiaryData diary)
        {
            _company = company;
            _diary = diary;

            if (diary == null)
            {
                DateEnabled = true;
                return;
            }

            Date = diary.Date;
            DateEnabled = false;
            Text = diary.Text;
        }

        private DateTime _date = DateTime.Today;
        public DateTime Date
        {
            get{ return _date; }
            set
            {
                SetProperty(ref _date, value);
            }
        }

        private bool _dateEnabled = true;
        public bool DateEnabled
        {
            get { return _dateEnabled; }
            set
            {
                SetProperty(ref _dateEnabled, value);
            }
        }

        private string _text = string.Empty;
        public string Text
        {
            get { return _text; }
            set
            {
                SetProperty(ref _text, value);
            }
        }

        public bool IsDateOK()
        {
            try
            {
                var reader = new DiaryCsvReader(_company);
                var diaries = reader.ReadAllDiaryData();

                return diaries?.All(d => d.Date.Date != Date.Date) ?? true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Save(BindingList<DiaryData> diaries)
        {
            try
            {
                if(_diary == null)
                {
                    _diary = new DiaryData { Date = this.Date, Text = this.Text };

                    // insert
                    var temp = diaries.Where(d => d.Date > this.Date).Last();
                    var index = diaries.IndexOf(temp);

                    diaries.Insert(index+1, _diary);
                }
                else
                {
                    _diary.Date = Date;
                    _diary.Text = Text;
                }

                var writer = new DiaryCsvWriter(_company);
                writer.WriteDiaryData(_diary);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
