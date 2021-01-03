using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockDataDownloader.Model;
using StockDataDownloader.IO;
using StockDataDownloader.ViewModel;

namespace StockDataDownloader.UI
{
    public partial class DiaryControl : UserControl
    {
        private DiaryControlView _viewModel;

        public event EventHandler<DiaryDataEventArgs> DiaryDataSelected;

        public DiaryControl()
        {
            InitializeComponent();
        }

        public void Init(Company company)
        {
            _viewModel = new DiaryControlView(company);

            dataGridView1.DataSource = _viewModel.Diaries;
            dataGridView1.Columns[nameof(DiaryData.Date)].HeaderText = "日付";
            dataGridView1.Columns[nameof(DiaryData.Text)].HeaderText = "テキスト";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var viewModel = new DiaryEditViewModel(_viewModel.Company, null);
                using (var dialog = new DiaryEditForm(viewModel, _viewModel.Diaries))
                {
                    var result = dialog.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                // ログは画面では記録しない
                MessageBox.Show(ex.Message);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // FullRowSelect
            var rows = dataGridView1.SelectedRows.OfType<DataGridViewRow>();
            var selected = rows.Select(r => r.DataBoundItem as DiaryData).Single();

            try
            {
                var viewModel = new DiaryEditViewModel(_viewModel.Company, selected);
                using (var dialog = new DiaryEditForm(viewModel, _viewModel.Diaries))
                {
                    var result = dialog.ShowDialog();
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                // ログは画面では記録しない
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // FullRowSelect
            var rows = dataGridView1.SelectedRows.OfType<DataGridViewRow>();
            var selected = rows.Select(r => r.DataBoundItem as DiaryData).Single();

            try
            {
                var result = MessageBox.Show("delete?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _viewModel.Delete(selected);
                }
            }
            catch (Exception ex)
            {
                // ログは画面では記録しない
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (DiaryDataSelected != null)
            {
                var rows = dataGridView1.SelectedRows.OfType<DataGridViewRow>().Select(r => r.DataBoundItem as DiaryData);
                var selected = rows?.SingleOrDefault() ?? null;

                if(selected != null)
                {
                    DiaryDataSelected(this, new DiaryDataEventArgs(selected.Date, selected.Text));
                }
            }
        }
    }
}
