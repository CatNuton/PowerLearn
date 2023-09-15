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
        public Color ButtonBackColor { get => btnSelect.BackColor; set => btnSelect.BackColor = value; }
        public Color ButtonForeColor { get => btnSelect.ForeColor; set => btnSelect.ForeColor = value; }
        public Color ButtonHoverColor1 { get => btnSelect.HoverColor1; set => btnSelect.HoverColor1 = value; }
        public Color ButtonHoverColor2 { get => btnSelect.HoverColor2; set => btnSelect.HoverColor2 = value; }
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
