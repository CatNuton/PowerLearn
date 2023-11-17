using PowerLearn;
using PowerLearnCandidate.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerLearnCandidate.Controls.Stat
{
    public partial class StatDetailItem : UserControl
    {
        public StatDetailItem()
        {
            InitializeComponent();
        }

        public void Build(Answer answer)
        {
            lblAnswerWeight.Visible = answer.Weight != 0;
            lblAnswerText.Text = answer.Text;
            lblAnswerWeight.Text = answer.Weight.ToString();
            if (answer.IsChecked)
            {
                pbCheckedImage.Image = Resources.Checked;
            }
            else
            {
                pbCheckedImage.Image = Resources.Unchecked;
            }
            if (answer.IsRight)
            {
                lblAnswerText.ForeColor = Color.Green;
            }
            else
            {
                lblAnswerText.ForeColor = Color.Red;
            }
        }
    }
}
