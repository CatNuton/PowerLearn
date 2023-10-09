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
    public partial class MultipleAnswersControl : UserControl
    {
        private Question question;
        public event EventHandler Applied;
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

        public MultipleAnswersControl()
        {
            InitializeComponent();
        }

        public void Build(Question question)
        {
            tlpAnswersPanel.Controls.Clear();
            tlpAnswersPanel.ColumnStyles.Clear();
            tlpAnswersPanel.ColumnCount = 1;
            tlpAnswersPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.question = question;
            if (this.question.Image == null)
            {
                tableLayoutPanel.ColumnStyles[0].SizeType = SizeType.Absolute; 
                tableLayoutPanel.ColumnStyles[0].Width = 0;
                pbImage.Visible = false;
            }
            else
            {
                tableLayoutPanel.ColumnStyles[0].SizeType = SizeType.Percent; 
                tableLayoutPanel.ColumnStyles[0].Width = 33;
                pbImage.Image = this.question.Image;
            }
            lblQuestionText.Text = question.Text;
            foreach (var answer in question.Answers)
            {
                var av = new AnswerVariant
                {
                    Dock = DockStyle.Fill
                };
                av.Build(answer);
                tlpAnswersPanel.Controls.Add(av, tlpAnswersPanel.ColumnCount - 1, 0);
                tlpAnswersPanel.ColumnCount++;
                tlpAnswersPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            }
            tlpAnswersPanel.ColumnStyles.RemoveAt(tlpAnswersPanel.ColumnCount - 1);
            tlpAnswersPanel.Invalidate();
        }


        public void ShowAnswers()
        {
            var i = 0;
            btnApply.Text = "Apply";
            foreach (var answer in question.Answers)
            {
                var variant = (AnswerVariant)tlpAnswersPanel.Controls[i];
                variant.IgnoreChecked = true;
                if (!answer.IsRight)
                {
                    variant.BackColor = Color.FromArgb(241, 128, 126);
                }
                else
                {
                    variant.BackColor = Color.LightGreen;
                }
                i++;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Applied?.Invoke(this, EventArgs.Empty);
        }
    }
}
