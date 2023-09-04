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

namespace PowerLearnCandidate.Controls
{
    public partial class AnswerVariant : UserControl
    {
        private Answer answer;
        public AnswerVariant()
        {
            InitializeComponent();
        }
        public void Build(Answer answer)
        {
            this.answer = answer;
            btnSelect.Text = answer.Text;
        }

        private void cbIsChecked_CheckedChanged(object sender, EventArgs e)
        {
            answer.IsChecked = cbIsChecked.Checked;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            cbIsChecked.Checked = !cbIsChecked.Checked;
        }
    }
}
