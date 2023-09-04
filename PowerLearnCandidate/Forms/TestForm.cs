using PowerLearn;
using PowerLearnCandidate.Forms;
using PowerLearnCandidate.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PowerLearnCandidate
{
    public partial class TestForm : Form
    {
        private Question question;
        private Test test;
        private int id = -1;
        public TestForm(Test test)
        {
            InitializeComponent();
            this.test = test;
            navigationControl1.Build(test);
#if DEBUG
            FormBorderStyle = FormBorderStyle.Sizable;
#endif
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            multipleAnswersControl_MouseMove(this, e);
            base.OnMouseMove(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            //id=-1
            NextQuestion();
            //id=0
            
            base.OnLoad(e);
        }

        protected override void OnDeactivate(EventArgs e)
        {
            Activate();
            //TopMost = false;
            //TopMost = true;
            base.OnDeactivate(e);
        }

        private void singleAnswerControl1_Applied(object sender, StringEventArgs e)
        {
            //id=2
            question.Answers[0].EnteredAnswer = e.Value;
            NextQuestion();
            //id=3
        }

        private void NextQuestion(bool forward = true)
        {
            if (forward)
            {
                id++;
                navigationControl1.Forward();
            }
            else
            {
                id--;
                navigationControl1.Back();
            }
            if (id >= test.Questions.Count)
            {
                var rf = new ResultForm();
                rf.FormClosed += (_, __) => Close();
                rf.BuildAndShow(test);
                return;
            }
            else if (id < 0)
            {
                id = 0;
                return;
            }
            question = test.Questions[id];
            if (question.Type == QuestionType.SingleAnswer)
            {
                singleAnswerControl.Visible = true;
                multipleAnswersControl.Visible = false;
                singleAnswerControl.Build(question);
            }
            else if (question.Type == QuestionType.MultipleAnswers)
            {
                singleAnswerControl.Visible = false;
                multipleAnswersControl.Visible = true;
                multipleAnswersControl.Build(question);
            }
        }

        private void multipleAnswersControl_Applied(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void multipleAnswersControl_MouseMove(object sender, MouseEventArgs e)
        {
            var pt = Cursor.Position;
            pt = PointToClient(pt);
            var backRect = Rectangle.FromLTRB(0, 0, btnBack.Right, Height);
            var forwardRect = Rectangle.FromLTRB(btnForward.Left, 0, Width, Height);
            Text = e.Location.ToString();
            if (backRect.Contains(pt))
            {
                btnBack.Show();
            }
            else
            {
                btnBack.Hide();
            }
            if (forwardRect.Contains(pt))
            {
                btnForward.Show();
            }
            else
            {
                btnForward.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NextQuestion(false);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }
    }
}
