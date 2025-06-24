using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using PowerLearn;
using PowerLearn.Serialization;
using PowerLearnCreator.Controls;
using PowerLearnCreator.Forms;
using QuestionEventArgs = PowerLearnCreator.Controls.QuestionEventArgs;

namespace PowerLearnCreator
{
    public partial class CreatorForm : Form
    {
        private Test currentTest;
        private string savedFilePath;
        private readonly Dictionary<string, Action> addQuestionMethods;
        private readonly UserSettings userSettings = new UserSettings();

        public CreatorForm()
        {
            InitializeComponent();
            addQuestionMethods = new Dictionary<string, Action> {
                {"MultipleAnswers", AddMultipleAnswersQuestion },
                {"SingleAnswer", AddSingleAnswerQuestion }
            };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var x = spltTestCreator.Panel2.ClientSize.Width - userSettings.Width;
            var y = 0;
            userSettings.Visible = false;
            spltTestCreator.Panel2.Controls.Add(userSettings);
            userSettings.Location = new Point(x, y);
            userSettings.Dock = DockStyle.Top | DockStyle.Right;
            userSettings.BringToFront();
        }

        private void adjustableFlowLayoutPanel1_ActiveQuestionChanged(object sender, QuestionEventArgs e)
        {
            QuestionControlPanel.Build(e.Question);
            QuestionControlPanel.Visible = e.Question != null;
        }

        private void btnNewTest_Click(object sender, EventArgs e)
        {
            currentTest = new Test();
            currentTest.Name = "Unnamed";
            currentTest.Description = "";
            currentTest.Type = "Unknown";
            UpdateInterface();
        }

        private void UpdateInterface()
        {
            Text = $"Power Learn Creator - {currentTest.Name}";
            adjflQuestionList.Build(currentTest);
            btnCreateQuestion.Enabled = true;
            btnTest.Enabled = !string.IsNullOrEmpty(savedFilePath);
            btnTestOptions.Enabled = true;
            btnUpload.Enabled = !string.IsNullOrEmpty(savedFilePath);
            btnUser.Enabled = true;
            btnOpenChecker.Enabled = currentTest.Uploaded;
            UpdateQuestionControl();
            if (currentTest.Author != null)
            {
                userSettings.FirstName = currentTest.Author.Name.FirstName;
                userSettings.LastName = currentTest.Author.Name.LastName;
                userSettings.Patronym = currentTest.Author.Name.Patronym;
            }
        }

        private void qstcntrlQuestionRedactor_AddAnswerClick(object sender, EventArgs e)
        {
            //MessageBox.Show("Added!");
            var a = new Answer();
            adjflQuestionList.ActiveQuestion.Answers.Add(a);
            QuestionControlPanel.Build(adjflQuestionList.ActiveQuestion);
        }

        private void qstcntrlQuestionRedactor_DeleteAnswerClick(object sender, AnswerEventArgs e)
        {
            adjflQuestionList.ActiveQuestion.Answers.Remove(e.Answer);
            QuestionControlPanel.Build(adjflQuestionList.ActiveQuestion);
        }

        private void qstcntrlQuestionRedactor_AddImageClick(object sender, AddImageEventArgs e)
        {
            adjflQuestionList.ActiveQuestion.Image = e.Image.Resize(new Size(600, 600));
            QuestionControlPanel.Build(adjflQuestionList.ActiveQuestion);
        }

        private void qstcntrlQuestionRedactor_DeleteImageClick(object sender, EventArgs e)
        {
            adjflQuestionList.ActiveQuestion.Image = null;
            QuestionControlPanel.Build(adjflQuestionList.ActiveQuestion);
        }

        private void adjflQuestionList_DeleteQuestion(object sender, QuestionEventArgs e)
        {
            currentTest.Questions.Remove(e.Question);
            adjflQuestionList.Build(currentTest);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Process.Start("PowerLearnCandidate", $"\"{savedFilePath}\"");
        }

        private void btnSaveTest_Click(object sender, EventArgs e)
        {
            if (!isNameWritten())
            {
                ShowExeption();
                return;
            }

            if (string.IsNullOrEmpty(savedFilePath))
            {
                SaveAs();
            }
            SaveFile();
            UpdateInterface();
        }

        private void btnOpenTest_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Helper.Clean();
            using (var sr = new StreamReader(openFileDialog.FileName))
            {
                var s = new XmlSerializer(typeof(TestProxy));
                var sres = (TestProxy)s.Deserialize(sr);
                currentTest = sres.Test;
                currentTest.Uploaded = CheckIfTestUploaded();
                savedFilePath = openFileDialog.FileName;
                UpdateInterface();
            }
        }

        private void btnSaveTestAs_Click(object sender, EventArgs e)
        {
            if (!isNameWritten())
            {
                ShowExeption();
                return;
            }
            SaveAs();
            SaveFile();
            UpdateInterface();
        }

        private void ShowExeption()
        {
            if (currentTest == null)
            {
                MessageBox.Show("Cannot save your project because test is not created\\loaded yet.", "PowerPoint error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (currentTest.Author == null && currentTest.Author == null)
            {
                MessageBox.Show("Cannot save your project because the name of the test creator is not specified.",
                    "PowerPoint error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveAs()
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            savedFilePath = saveFileDialog.FileName;
        }

        private bool isNameWritten()
        {
            return currentTest != null && currentTest.Author != null && currentTest.Author.Name != null ? true : false;
        }

        private void SaveFile()
        {
            using (var sw = new StreamWriter(savedFilePath))
            {
                var s = new XmlSerializer(typeof(TestProxy));
                s.Serialize(sw, new TestProxy(currentTest));
            }
        }

        private void btnTestOptions_Click(object sender, EventArgs e)
        {
            var etp = new TestPropertiesEditor(currentTest);
            etp.ChangesApplied += (_, __) => UpdateInterface();
            var dr = etp.ShowDialog();
            if (dr == DialogResult.OK)
            {
                UpdateInterface();
            }
        }

        private void adjflQuestionList_ControlAdded(object sender, ControlEventArgs e)
        {
            Text = adjflQuestionList.Size.ToString();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (currentTest.Author == null)
            {
                currentTest.Author = new Person();
            }
            var ae = new AuthorEditor(currentTest.Author);
            ae.StartPosition = FormStartPosition.Manual;
            ae.Top = ToolStrip.Bottom;
            ae.Left = Width - ae.Width;
            ae.Location = PointToScreen(ae.Location);
            ae.Show(this);
            ae.ChangesSave += (_, __) =>
            {
                currentTest.Author.Name.FirstName = ae.FirstName;
                currentTest.Author.Name.LastName = ae.LastName;
                currentTest.Author.Name.Patronym = ae.Patronym;
            };
            UpdateInterface();
        }

        private void UserSettings_ChangesSave(object sender, EventArgs e)
        {
            currentTest.Author = new Person
            {
                Name = new FullName
                {
                    FirstName = userSettings.FirstName,
                    LastName = userSettings.LastName,
                    Patronym = userSettings.Patronym,
                }
            };
            UpdateInterface();
            userSettings.Visible = false;
        }

        private void btnCreateQuestion_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            addQuestionMethods[e.ClickedItem.Name]();
            //var n = (QuestionType)Enum.Parse(typeof(QuestionType), e.ClickedItem.Name);
            //switch (n)
            //{
            //    case QuestionType.MultipleAnswers:
            //        AddMultipleAnswersQuestion();
            //        break;
            //    case QuestionType.SingleAnswer:
            //        AddSingleAnswerQuestion();
            //        break;
            //    default:
            //        break;
            //}
        }

        private void AddSingleAnswerQuestion()
        {
            var q = new Question(QuestionType.SingleAnswer);
            currentTest.Questions.Add(q);
            adjflQuestionList.Build(currentTest);
            adjflQuestionList.ActiveQuestion = q;
            QuestionControlPanel.Build(q);
        }

        private void AddMultipleAnswersQuestion()
        {
            var q = new Question(QuestionType.MultipleAnswers);
            currentTest.Questions.Add(q);
            adjflQuestionList.Build(currentTest);
            adjflQuestionList.ActiveQuestion = q;
            QuestionControlPanel.Build(q);
        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                btnUpload.Enabled = false;
                currentTest.Uploaded = true;
                btnSaveTest_Click(this, e);
                var r = await FileServer.Instance.Upload(savedFilePath, "verb", "upload", "id", currentTest.Id.ToString());
                var mcb = new MessageCopyBox();
                mcb.ShowMessage(r, currentTest.Id.ToString(), "id");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}\nProgram cannot upload this file on server!");
                currentTest.Uploaded = false;
                return;
            }
            finally
            {
                btnUpload.Enabled = true;
            }
        }

        public void UpdateQuestionControl()
        {
            if (adjflQuestionList.Controls.Count != 0 && adjflQuestionList.ActiveQuestion != null)
            {
                QuestionControlPanel.Build(adjflQuestionList.ActiveQuestion);
            }
            else if (adjflQuestionList.Controls.Count > 0 && adjflQuestionList.ActiveQuestion == null)
            {
                QuestionControlPanel.Visible = false;
            }
            else if (adjflQuestionList.Controls.Count == 0)
            {
                QuestionControlPanel.Visible = false;
            }
        }

        private void tsbOpenChecker_Click(object sender, EventArgs e)
        {
            Process.Start("PowerLearnChecker", currentTest.Id.ToString());
        }

        private bool CheckIfTestUploaded()
        {
            try
            {
                var r = FileServer.Instance.SendVerb("verb", "ifUploaded", "id", currentTest.Id.ToString()).Result;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void CreatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentTest != null)
            {
                var result = MessageBox.Show($"Save changes in file {currentTest.Name}.xml before closing?",
                    Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (savedFilePath != null)
                    {
                        SaveFile();
                    }
                    else
                    {
                        SaveAs();
                        SaveFile();
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}