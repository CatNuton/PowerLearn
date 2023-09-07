using PowerLearn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerLearnCreator.Forms
{
    public partial class AuthorEditor : Form
    {
        public AuthorEditor()
        {
            InitializeComponent();
        }

        public AuthorEditor(Person author) : this()
        {
            Author = new Person();
            if (author != null)
            {
                FirstName = author.Name.FirstName;
                LastName = author.Name.LastName;
                Patronym = author.Name.Patronym;
            }
        }

        public event EventHandler ChangesSave;
        public Person Author { get; set; }
        public string FirstName
        {
            get => tbFirstName.Text; set
            {
                tbFirstName.Text = value;
                if (Author != null && Author.Name != null)
                {
                    Author.Name.FirstName = value;
                }
            }
        }
        public string LastName
        {
            get => tbLastName.Text; set
            {
                tbLastName.Text = value;
                if (Author != null && Author.Name != null)
                {
                    Author.Name.LastName = value;
                }
            }
        }
        public string Patronym
        {
            get => tbPatronym.Text; set
            {
                tbPatronym.Text = value;
                if (Author != null && Author.Name != null)
                {
                    Author.Name.Patronym = value;
                }
            }
        }

        private void btnSaveAuthor_Click(object sender, EventArgs e)
        {
            ChangesSave?.Invoke(this, EventArgs.Empty);
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            btnSaveAuthor.Enabled = !string.IsNullOrWhiteSpace(tbFirstName.Text);
        }

        private void AuthorEditor_Deactivate(object sender, EventArgs e)
        {
            Close();
        }
    }
}
