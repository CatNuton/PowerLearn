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
    public partial class SingleAnswerControl : UserControl
    {
        private Question question;
        public event EventHandler<StringEventArgs> Applied;
        public new event MouseEventHandler MouseMove
        {
            add
            {
                base.MouseMove += value;
                AddMouseMove(Controls, value);
            }
            remove
            {
                base.MouseMove -= value;
                RemoveMouseMove(Controls, value);
            }
        }

        private void AddMouseMove(ControlCollection controls, MouseEventHandler handler)
        {
            foreach (Control control in controls)
            {
                control.MouseMove += handler;
                if (control.Controls.Count > 0)
                {
                    AddMouseMove(control.Controls, handler);
                }
            }
        }

        private void RemoveMouseMove(ControlCollection controls, MouseEventHandler handler)
        {
            foreach (Control control in controls)
            {
                control.MouseMove -= handler;
                if (control.Controls.Count > 0)
                {
                    RemoveMouseMove(control.Controls, handler);
                }
            }
        }


        public void ShowAnswers()
        {
            var answerText = question.Answers[0].Text.Trim();
            var enteredText = tbAnswer.Text;
            if (answerText.Equals(enteredText, StringComparison.OrdinalIgnoreCase))
            {
                tbAnswer.BorderColor = Color.LightGreen;
            }
            else
            {
                tbAnswer.BorderColor = Color.FromArgb(241, 128, 126);
            }
            tbAnswer.Invalidate();
            btnApply.Text = "Apply";
            tbAnswer.Enabled = false;
        }

        public SingleAnswerControl()
        {
            InitializeComponent();
        }

        public void Build(Question question)
        {
            tbAnswer.Text = "";
            this.question = question;
            if (this.question.Image == null)
            {
                pbImage.Visible = false;
            }
            else
            {
                pbImage.Image = this.question.Image;
            }
            lblQuestionText.Text = this.question.Text;
            tbAnswer.Enabled = true;
            btnApply.Text = "Check";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Applied?.Invoke(this, new StringEventArgs(tbAnswer.Text));
        }

        private void tbAnswer_TextChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = !string.IsNullOrWhiteSpace(tbAnswer.Text);
        }
    }
}
