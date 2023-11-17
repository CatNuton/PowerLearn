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
            Text = $"{test.Name} Results";
            aflpQuestions.AutoScroll = false;
            foreach (var q in test.Questions)
            {
                var sdc = new StatDetailCard();
                sdc.Build(q);
                aflpQuestions.Controls.Add(sdc);
            }
            spbResult.Value = (float)((100 * test.Score) / test.MaxScore);
        }

        public void BuildAndShow(Test test)
        {
            Build(test);
            Show();
        }

        private async void btnUploadResult_Click(object sender, System.EventArgs e)
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
            Close();
        }
    }
}
