using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerLearn;
using System.Net.Http;

namespace PowerLearnCandidate
{
    public partial class EnterDataForm : Form
    {
        public string Path { get; private set; }
        public Person Candidate { get; set; }
        public EnterDataForm()
        {
            InitializeComponent();
            var img = (Image)Properties.Resources.ResourceManager.GetObject("ButtonStartPNG");
        }

        private async void btnStartTest_Click(object sender, EventArgs e)
        {
            Candidate = new Person
            {
                Name = new FullName
                {
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    Patronym = tbPatronym.Text
                }
            };
            try
            {
                var tb = await FileServer.Instance.Download(tbId.Text, Candidate.ToString());
                Path = System.IO.Path.GetTempFileName();
                File.WriteAllBytes(Path, tb);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            UpdateInterface();
        }

        private void UpdateInterface()
        {
            btnStartTest.Enabled = !string.IsNullOrEmpty(tbId.Text) &&
                !string.IsNullOrEmpty(tbFirstName.Text) &&
                !string.IsNullOrEmpty(tbLastName.Text) &&
                !string.IsNullOrEmpty(tbPatronym.Text);
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            UpdateInterface();
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            UpdateInterface();
        }

        private void tbPatronym_TextChanged(object sender, EventArgs e)
        {
            UpdateInterface();
        }
    }
}