using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerLearnCreator.Forms
{
    public partial class MessageCopyBox : Form
    {
        private string messageToCopy;
        public MessageCopyBox()
        {
            InitializeComponent();
        }

        public void ShowMessage(string message)
        {
            ShowDialog();
            lblMessage.Text = message;
            messageToCopy = message;
        }

        public void ShowMessage(string message, string messageToCopy, string messageToCopyType)
        {
            lblMessage.Text = message;
            this.messageToCopy = messageToCopy;
            btnCopy.Text += $" {messageToCopyType}";
            ShowDialog();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(messageToCopy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
