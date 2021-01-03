using StockDataDownloader.Model;
using StockDataDownloader.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockDataDownloader.UI
{
    public partial class DiaryEditForm : Form
    {
        private DiaryEditViewModel _viewMode;

        private BindingList<DiaryData> _diaries;

        public DiaryEditForm(DiaryEditViewModel viewModel, BindingList<DiaryData> diaries)
        {
            InitializeComponent();

            _viewMode = viewModel;
            _diaries = diaries;

            dateTimePicker1.DataBindings.Add(nameof(dateTimePicker1.Value), _viewMode, nameof(_viewMode.Date), false, DataSourceUpdateMode.OnPropertyChanged);
            dateTimePicker1.DataBindings.Add(nameof(dateTimePicker1.Enabled), _viewMode, nameof(_viewMode.DateEnabled), false, DataSourceUpdateMode.OnPropertyChanged);
            richTextBox1.DataBindings.Add(nameof(richTextBox1.Text), _viewMode, nameof(_viewMode.Text));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                _viewMode.Save(_diaries);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!_viewMode.IsDateOK())
                {
                    errorProvider1.SetError((DateTimePicker)sender, "error");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError((DateTimePicker)sender, string.Empty);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
