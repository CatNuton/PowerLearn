using PowerLearn;
using PowerLearn.Serialization;
using PowerLearnCandidate.Controls.Stat;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PowerLearnCandidate.Forms
{
    public partial class ResultForm : Form
    {
        private Test test;

        public ResultForm()
        {
            InitializeComponent();
            HorizontalScroll.Maximum = 0;
        }

        public void Build(Test test)
        {
            this.test = test;
            lblTestName.Text = $"Passed test: '{test.Name}'"; 
            lblScore.Text = $"Your score is {test.Score}";
            lblMaxScore.Text = $"Max score is {test.MaxScore}";
            lblTestAuthor.Text = $"Test created by {test.Author.Name.LastName} {test.Author.Name.FirstName}" +
                $" {test.Author.Name.Patronym}";
            lblTestType.Text = test.Type;
            lblTestDescription.Text = test.Description;
            lblQuestionCount.Text = test.Questions.Count.ToString();
            lblCandidateHeader.Text = $"Result of {test.Candidate}:";
            Text = $"{test.Name} Results";
            //aflpQuestions.AutoScroll = false;
            foreach (var q in test.Questions)
            {
                var sdc = new StatDetailCard();
                sdc.Build(q);
                aflpQuestions.Controls.Add(sdc);
            }
            int cc = 0;
            int ic = 0;
            foreach (var question in test.Questions)
            {
                if (question.Score == question.MaxScore)
                {
                    cc++;
                }
                else
                {
                    ic++;
                }
            }
            lblRightAnswersCount.Text = $"{cc} Correct";
            lblIncorrectAnswersCount.Text = $"{ic} Incorrect";
            spbResult.Value = (float)((100 * test.Score) / test.MaxScore);
        }

        public void BuildAndShow(Test test)
        {
            Build(test);
            Show();
        }


        private async void ResultForm_Shown(object sender, System.EventArgs e)
        {
            var filePath = Path.GetTempFileName();
            using (var sw = new StreamWriter(filePath))
            {
                var s = new XmlSerializer(typeof(TestProxy));
                s.Serialize(sw, new TestProxy(test));
            }
            await FileServer.Instance.Upload(filePath, "verb", "uploadCompleted",
                "id", test.Id.ToString(),
                "name", test.Candidate.Name.ToString(),
                "max", test.MaxScore.ToString(),
                "score", test.Score.ToString());
        }

        private void spQuestions_SpoilerCollapsed(object sender, System.EventArgs e)
        {
            Height -= spQuestions.FullHeight;
        }

        private void spQuestions_SpoilerUncollapsed(object sender, System.EventArgs e)
        {
            Height += spQuestions.FullHeight;
        }
    }
}
