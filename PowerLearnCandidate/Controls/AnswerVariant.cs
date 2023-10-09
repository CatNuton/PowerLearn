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
    public partial class AnswerVariant : RoundedCheckBox
    {
        private Answer answer;

        //public AnswerVariant()
        //{
        //    InitializeComponent();
        //}

        public void Build(Answer answer)
        {
            this.answer = answer;
            Text = answer.Text;
            IgnoreChecked = false;
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);
            answer.IsChecked = Checked;
        }
    }
}
