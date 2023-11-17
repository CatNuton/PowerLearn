﻿using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using PowerLearn;

namespace PowerLearnChecker
{
    public partial class MainForm : Form
    {
        private int id;
        public MainForm()
        {
            InitializeComponent();
            dgvTestsView.AutoGenerateColumns = true;
        }

        public MainForm(int id)
        {
            InitializeComponent();
            dgvTestsView.AutoGenerateColumns = true;
            this.id = id;
            tstbId.Text = id.ToString();
            tsbDownload.PerformClick();
        }

        private async void tsbDownload_Click(object sender, EventArgs e)
        {
            await Build();
        }

        private async Task Build()
        {
            byte[] r;
            try
            {
                r = await FileServer.Instance.Download("verb", "getList", "id", id.ToString());
                btnDeleteSelectedUser.Enabled = true;
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
            id = int.Parse(tstbId.Text);
        }

        private async void btnDeleteSelectedUser_Click(object sender, EventArgs e)
        {
            var test = (Test)bindingSource.Current;
            await Build();
            await FileServer.Instance.SendVerb("verb", "deleteCompleted", "id", test.Id.ToString(), "name", test.Name);
        }

        private async void btnDeleteTest_ClickAsync(object sender, EventArgs e)
        {
            var test = (Test)bindingSource.Current;
            await Build();
            await FileServer.Instance.SendVerb("verb", "deleteTest", "id", tstbId.Text);
        }
    }
}