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
using PowerLearn.Serialization;

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
            await DownloadTests();
        }

        private async Task DownloadTests()
        {
            byte[] r;
            try
            {
                r = await FileServer.Instance.Download("verb", "getList", "id", tstbId.Text);
                btnDeleteCurrent.Enabled = true;
                btnDeleteTest.Enabled = true;
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

        private async void btnDeleteCurrent_Click(object sender, EventArgs e)
        {
            var test = (Test)bindingSource.Current;
            await FileServer.Instance.SendVerb("verb", "deleteCompleted", "id", test.Id.ToString(), "name", test.Name);
            await DownloadTests();
        }

        private async void btnDeleteTest_ClickAsync(object sender, EventArgs e)
        {
            var test = (Test)bindingSource.Current;
            await FileServer.Instance.SendVerb("verb", "deleteTest", "id", tstbId.Text);
            bindingSource.DataSource = null;
            tstbId.Clear();
        }
    }
}