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
    public partial class AnswerEditor : BaseEditor
    {
        private readonly Answer origAnswer;
        private readonly Answer editAnswer;
        public AnswerEditor()
        {
            InitializeComponent();
        }
        public AnswerEditor(Answer answer) : this()
        {
            origAnswer = answer;
            editAnswer = new Answer
            {
                Text = answer.Text,
                Weight = answer.Weight
            };
            pgAnswerProperties.SelectedObject = this.editAnswer;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            ApplyChanges();
        }
        private void btn_Apply_Click(object sender, EventArgs e)
        {
            ApplyChanges();
            OnChangesApplied();
        }
        protected override void ApplyChanges()
        {
            origAnswer.Text = editAnswer.Text;
            origAnswer.Weight = editAnswer.Weight;
            base.ApplyChanges();
        }
    }
}