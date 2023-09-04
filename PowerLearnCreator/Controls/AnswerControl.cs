using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerLearn;
using PowerLearnCreator.Forms;

namespace PowerLearnCreator.Controls
{
    public partial class AnswerControl : UserControl
    {
        private Answer answer;

        public AnswerControl()
        {
            InitializeComponent();
        }
        public Answer Answer
        {
            get => answer; set
            {
                answer = value;
                cbAnswer.Text = answer.Text;
                cbAnswer.Checked = answer.IsRight;
            }
        }
        internal event EventHandler AnswerDelete;
        protected virtual void OnAnswerDelete()
        {
            AnswerDelete?.Invoke(this, EventArgs.Empty);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            btnDelete.Visible = true;
            btnEdit.Visible = true;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            var pt = PointToClient(Cursor.Position);
            if (ClientRectangle.Contains(pt))
            {
                return;
            }
            base.OnMouseLeave(e);
            btnDelete.Visible = false;
            btnEdit.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnAnswerDelete();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var ea = new AnswerEditor(Answer);
            ea.ChangesApplied += (_, __) => UpdateUI();
            var dr = ea.ShowDialog();
            if (dr == DialogResult.OK)
            {
                UpdateUI();
            }
        }

        private void UpdateUI()
        {
            cbAnswer.Text = Answer.Text;
        }

        private void cbAnswer_CheckedChanged(object sender, EventArgs e)
        {
            Answer.IsRight = cbAnswer.Checked;
        }
    }
}
