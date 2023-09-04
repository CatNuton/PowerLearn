using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerLearn;
using PowerLearnCreator.Controls;
using QuestionEventArgs = PowerLearnCreator.Controls.QuestionEventArgs;

namespace PowerLearnCreator
{
    public class QuestionsFlowLayoutPanel : AdjustableFlowLayoutPanel
    {
        private Question activeQuestion;

        public Test Test { get; private set; }
        public Question ActiveQuestion
        {
            get => activeQuestion; set
            {
                activeQuestion = value;
                OnActiveQuestionChanged(new QuestionEventArgs(activeQuestion));
            }
        }
        private int deletedQuestionIndex = -1;
        public event EventHandler<QuestionEventArgs> ActiveQuestionChanged;
        public event EventHandler<QuestionEventArgs> DeleteQuestion;

        public void Build(Test test)
        {
            Test = test;
            Controls.Clear();
            foreach (var item in Test.Questions)
            {
                //if (item == ActiveQuestion)
                //{
                //    activeQuestionDeleted = false;
                //}
                AddQuestion(item);
            }
            if (deletedQuestionIndex != -1) 
            {
                if (deletedQuestionIndex == 0)
                {
                    ActiveQuestion = Test.Questions[0];
                }
                else
                {
                    ActiveQuestion = Test.Questions[deletedQuestionIndex - 1];
                }
            }
            deletedQuestionIndex = -1;
        }
        private void AddQuestion(Question question)
        {
            var cmsDeleteContextMenu = new ContextMenuStrip();
            var deleteMenu = cmsDeleteContextMenu.Items.Add("Delete");
            deleteMenu.Click += (_, __) =>
            {
                var e = new QuestionEventArgs(question);
                deletedQuestionIndex = Test.Questions.IndexOf(question);
                OnDeleteQuestion(e);
            };
            var questBtn = new SelectableButton
            {
                Text = $"{Controls.Count + 1}",
                ContextMenuStrip = cmsDeleteContextMenu
            };
            ActiveQuestionChanged += (_, __) =>
            {
                SetVisualStyle(question, questBtn);
            };
            questBtn.Click += (_, __) =>
            {
                ActiveQuestion = question;
            };
            Controls.Add(questBtn);
            SetVisualStyle(question, questBtn);
        }

        private void SetVisualStyle(Question question, SelectableButton questBtn)
        {
            questBtn.Selected = ActiveQuestion == question;
        }

        protected virtual void OnActiveQuestionChanged(QuestionEventArgs e)
        {
            ActiveQuestionChanged?.Invoke(this, e);
        }

        protected virtual void OnDeleteQuestion(QuestionEventArgs e)
        {
            DeleteQuestion?.Invoke(this, e);
        }
    }
}
