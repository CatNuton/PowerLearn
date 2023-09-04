using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using PowerLearn;

namespace PowerLearnChecker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dgvTestsView.AutoGenerateColumns = true;
        }

        private async void tsbDownload_Click(object sender, EventArgs e)
        {
            var fs = new FileServer("130.61.26.111", "3001");
            byte[] r;
            try
            {
                r = await fs.Download("verb", "getList", "id", tstbId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Program cannot find completed tests!\n{ex}");
                return;
            }
            var xml = Encoding.UTF8.GetString(r);
            var serializer = new XmlSerializer(typeof(Tests));
            using (var reader = new StringReader(xml))
            {
                var tests = (Tests)serializer.Deserialize(reader);
                bindingSource.DataSource = tests;
            }
        }

        private void tstbId_TextChanged(object sender, EventArgs e)
        {
            tsbDownload.Enabled = !string.IsNullOrEmpty(tstbId.Text);
        }
    }
}
