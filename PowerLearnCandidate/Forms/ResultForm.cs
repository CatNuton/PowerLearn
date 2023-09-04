using PowerLearn;
using PowerLearn.Serialization;
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
        }

        public void Build(Test test)
        {
            this.test = test;
            lblScore.Text = $"Your score is {test.Score}";
            lblMaxScore.Text = $"Max score is {test.MaxScore}";
            lblTestName.Text = $"Thanks for passing test '{test.Name}'!";
            lblTestAuthor.Text = $"Test created by {test.Author.Name.LastName} {test.Author.Name.FirstName}" +
                $" {test.Author.Name.Patronym}";
            lblTestType.Text = test.Type;
            lblTestDesription.Text = test.Description;
            Text = $"{test.Name} Results";
        }

        public void BuildAndShow(Test test) 
        {
            Build(test);
            Show();
        }

        private async void btnUploadResult_Click(object sender, System.EventArgs e)
        {
            var fs = new FileServer("130.61.26.111", "3001");
            var filePath = Path.GetTempFileName();
            using (var sw = new StreamWriter(filePath))
            {
                var s = new XmlSerializer(typeof(TestProxy));
                s.Serialize(sw, new TestProxy(test));
            }
            await fs.Upload(filePath, "verb", "uploadCompleted",
                "id", test.Id.ToString(),
                "name", test.Candidate.Name.ToString(),
                "max", test.MaxScore.ToString(),
                "score", test.Score.ToString());
            Close();
        }
    }
}
