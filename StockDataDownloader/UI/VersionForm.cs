using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockDataDownloader.UI
{
    public partial class VersionForm : Form
    {
        public VersionForm()
        {
            InitializeComponent();
        }

        private void VersionForm_Load(object sender, EventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var info = FileVersionInfo.GetVersionInfo(assembly.Location);

            label1.Text = assembly.GetName().Name;
            label2.Text = info.FileVersion;
            label3.Text = info.LegalCopyright;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
