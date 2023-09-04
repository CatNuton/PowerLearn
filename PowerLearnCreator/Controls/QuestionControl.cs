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

namespace PowerLearnCreator.Controls
{
    public partial class QuestionControl : UserControl
    {
        public QuestionControl()
        {
            InitializeComponent();
        }
        public Question Question { get; private set; }
        public bool AddAnswerEnabled { get => btnAdd.Enabled; set => btnAdd.Enabled = value; }
        public event EventHandler AddAnswerClick;
        public event EventHandler<AnswerEventArgs> DeleteAnswerClick;
        public event EventHandler<AddImageEventArgs> AddImageClick;
        public event EventHandler DeleteImageClick;

        public void Build(Question question)
        {
            if (question == null)
            {
                return;
            }
            Question = question;
            SetupControls();
            Show();
        }
        private void SetupControls()
        {
            if (Question.Image != null)
            {
                pctrQuestionImage.Image = Question.Image;
                lblMessage.SendToBack();
            }
            else
            {
                pctrQuestionImage.Image = null;
                lblMessage.BringToFront();
            }
            txtbxQuestionText.Text = Question.Text;
            adjflwpAnswerList.Controls.Clear();
            foreach (var item in Question.Answers)
            {
                //Додавати обробник події настискання на кнопку Delete
                var ctrl = new AnswerControl
                {
                    Answer = item
                };
                ctrl.AnswerDelete += (s, _) =>
                {
                    var ac = (AnswerControl)s;
                    var e = new AnswerEventArgs(ac.Answer);
                    OnDeleteAnswerClick(e);
                };
                adjflwpAnswerList.Controls.Add(ctrl);
            }
            if (Question.Type == QuestionType.SingleAnswer &&
                Question.Answers.Count != 0)
            {
                AddAnswerEnabled = false;
            }
            else
            {
                AddAnswerEnabled = true;
            }
        }
        public string QuestionText { get; set; }

        protected virtual void OnDeleteAnswerClick(AnswerEventArgs e)
        {
            DeleteAnswerClick?.Invoke(this, e);
        }

        protected virtual void OnAddImageClick(AddImageEventArgs e)
        {
            AddImageClick?.Invoke(this, e);
        }
        private void txtbxQuestionText_TextChanged(object sender, EventArgs e)
        {
            Question.Text = txtbxQuestionText.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAnswerClick?.Invoke(this, EventArgs.Empty);
        }

        internal void AddAnswer(Answer a)
        {
            //lbAnswers.Items.Add(a.Text);
        }

        private void ImageDoubleClick(object sender, EventArgs e)
        {
            var dr = dlgOpen.ShowDialog();
            if (dr != DialogResult.OK)
            {
                return;
            }
            var img = Image.FromFile(dlgOpen.FileName);
            var ev = new AddImageEventArgs(img);
            OnAddImageClick(ev);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnDeleteImageClick();
        }

        protected virtual void OnDeleteImageClick()
        {
            DeleteImageClick?.Invoke(this, EventArgs.Empty);
        }
    }
}