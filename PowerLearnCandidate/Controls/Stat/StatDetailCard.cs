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

namespace PowerLearnCandidate.Controls.Stat
{
    public partial class StatDetailCard : UserControl
    {
        public StatDetailCard()
        {
            InitializeComponent();
        }

        public void Build(Question question)
        {
            pbQuestionImage.Visible = question.Image != null;
            pbQuestionImage.Image = question.Image;
            lblQuestionText.Text = question.Text;
            foreach (var answer in question.Answers)
            {
                var sdi = new StatDetailItem { Dock = DockStyle.Fill };
                sdi.Build(answer);
                tlpAsnwers.Controls.Add(sdi);
            }
            lblResultValue.Text = $"{question.Score} / {question.MaxScore}";
        }
    }
}
