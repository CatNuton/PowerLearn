namespace PowerLearnCandidate.Forms
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTestName = new System.Windows.Forms.Label();
            this.lblMaxScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTestAuthor = new System.Windows.Forms.Label();
            this.lblTestDescription = new System.Windows.Forms.Label();
            this.lblTestType = new System.Windows.Forms.Label();
            this.rtlpTest = new PowerLearnCandidate.Controls.RoundTableLayoutPanel();
            this.lblTestHeader = new System.Windows.Forms.Label();
            this.lblQuestionCount = new System.Windows.Forms.Label();
            this.lblQuestionCountText = new System.Windows.Forms.Label();
            this.spQuestions = new PowerLearnCandidate.Controls.Spoiler();
            this.aflpQuestions = new PowerLearn.Controls.AdjustableFlowLayoutPanel();
            this.spbResult = new PowerLearnCandidate.Controls.Stat.StatProgressBar();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.rtlpaCandidate = new PowerLearnCandidate.Controls.RoundTableLayoutPanel();
            this.lblCandidateHeader = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.lblRightAnswersCount = new System.Windows.Forms.Label();
            this.lblIncorrectAnswersCount = new System.Windows.Forms.Label();
            this.rtlpTest.SuspendLayout();
            this.spQuestions.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.rtlpaCandidate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestName.Location = new System.Drawing.Point(3, 24);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(71, 16);
            this.lblTestName.TabIndex = 1;
            this.lblTestName.Text = "TestName";
            // 
            // lblMaxScore
            // 
            this.lblMaxScore.AutoSize = true;
            this.lblMaxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxScore.Location = new System.Drawing.Point(2, 40);
            this.lblMaxScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxScore.Name = "lblMaxScore";
            this.lblMaxScore.Size = new System.Drawing.Size(68, 16);
            this.lblMaxScore.TabIndex = 3;
            this.lblMaxScore.Text = "MaxScore";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.Location = new System.Drawing.Point(2, 24);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(43, 16);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score";
            // 
            // lblTestAuthor
            // 
            this.lblTestAuthor.AutoSize = true;
            this.lblTestAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestAuthor.Location = new System.Drawing.Point(2, 40);
            this.lblTestAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestAuthor.Name = "lblTestAuthor";
            this.lblTestAuthor.Size = new System.Drawing.Size(72, 16);
            this.lblTestAuthor.TabIndex = 5;
            this.lblTestAuthor.Text = "TestAuthor";
            // 
            // lblTestDescription
            // 
            this.lblTestDescription.AutoSize = true;
            this.lblTestDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestDescription.Location = new System.Drawing.Point(2, 88);
            this.lblTestDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestDescription.Name = "lblTestDescription";
            this.lblTestDescription.Size = new System.Drawing.Size(102, 16);
            this.lblTestDescription.TabIndex = 6;
            this.lblTestDescription.Text = "TestDescription";
            // 
            // lblTestType
            // 
            this.lblTestType.AutoSize = true;
            this.lblTestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestType.Location = new System.Drawing.Point(2, 62);
            this.lblTestType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestType.Name = "lblTestType";
            this.lblTestType.Size = new System.Drawing.Size(66, 16);
            this.lblTestType.TabIndex = 7;
            this.lblTestType.Text = "TestType";
            // 
            // rtlpTest
            // 
            this.rtlpTest.AutoScroll = true;
            this.rtlpTest.ColumnCount = 2;
            this.rtlpTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.rtlpTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.rtlpTest.Controls.Add(this.lblTestHeader, 0, -1);
            this.rtlpTest.Controls.Add(this.lblTestName, 0, 1);
            this.rtlpTest.Controls.Add(this.lblTestType, 0, 3);
            this.rtlpTest.Controls.Add(this.lblQuestionCount, 1, 0);
            this.rtlpTest.Controls.Add(this.lblTestDescription, 0, 4);
            this.rtlpTest.Controls.Add(this.lblTestAuthor, 0, 2);
            this.rtlpTest.Controls.Add(this.lblQuestionCountText, 1, 3);
            this.rtlpTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtlpTest.Location = new System.Drawing.Point(3, 3);
            this.rtlpTest.Name = "rtlpTest";
            this.rtlpTest.Rounding = 0;
            this.rtlpTest.RowCount = 1;
            this.rtlpTest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlpTest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlpTest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlpTest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlpTest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlpTest.Size = new System.Drawing.Size(655, 141);
            this.rtlpTest.TabIndex = 0;
            // 
            // lblTestHeader
            // 
            this.lblTestHeader.AutoSize = true;
            this.lblTestHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestHeader.Location = new System.Drawing.Point(3, 0);
            this.lblTestHeader.Name = "lblTestHeader";
            this.lblTestHeader.Size = new System.Drawing.Size(109, 24);
            this.lblTestHeader.TabIndex = 0;
            this.lblTestHeader.Text = "About test:";
            // 
            // lblQuestionCount
            // 
            this.lblQuestionCount.AutoSize = true;
            this.lblQuestionCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestionCount.Location = new System.Drawing.Point(527, 0);
            this.lblQuestionCount.Name = "lblQuestionCount";
            this.rtlpTest.SetRowSpan(this.lblQuestionCount, 3);
            this.lblQuestionCount.Size = new System.Drawing.Size(125, 62);
            this.lblQuestionCount.TabIndex = 8;
            this.lblQuestionCount.Text = "QuestionCount";
            this.lblQuestionCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionCountText
            // 
            this.lblQuestionCountText.AutoSize = true;
            this.lblQuestionCountText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionCountText.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionCountText.Location = new System.Drawing.Point(527, 62);
            this.lblQuestionCountText.Name = "lblQuestionCountText";
            this.lblQuestionCountText.Size = new System.Drawing.Size(125, 26);
            this.lblQuestionCountText.TabIndex = 9;
            this.lblQuestionCountText.Text = "Questions";
            this.lblQuestionCountText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spQuestions
            // 
            this.spQuestions.CollapsedText = "Show more";
            this.spQuestions.Controls.Add(this.aflpQuestions);
            this.spQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spQuestions.Location = new System.Drawing.Point(2, 270);
            this.spQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.spQuestions.Name = "spQuestions";
            this.spQuestions.Size = new System.Drawing.Size(657, 224);
            this.spQuestions.TabIndex = 9;
            this.spQuestions.UncollapsedText = "Collapse";
            this.spQuestions.SpoilerCollapsed += new System.EventHandler(this.spQuestions_SpoilerCollapsed);
            this.spQuestions.SpoilerUncollapsed += new System.EventHandler(this.spQuestions_SpoilerUncollapsed);
            // 
            // aflpQuestions
            // 
            this.aflpQuestions.AutoScroll = true;
            this.aflpQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aflpQuestions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.aflpQuestions.Location = new System.Drawing.Point(0, 0);
            this.aflpQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.aflpQuestions.Name = "aflpQuestions";
            this.aflpQuestions.Size = new System.Drawing.Size(657, 206);
            this.aflpQuestions.TabIndex = 10;
            this.aflpQuestions.WrapContents = false;
            // 
            // spbResult
            // 
            this.spbResult.BackColor = System.Drawing.Color.Transparent;
            this.spbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spbResult.ForeColor = System.Drawing.Color.White;
            this.spbResult.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.spbResult.LeftText = "Правильно";
            this.spbResult.Location = new System.Drawing.Point(184, 58);
            this.spbResult.Margin = new System.Windows.Forms.Padding(2);
            this.spbResult.Name = "spbResult";
            this.spbResult.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.spbResult.RightText = "Неправильно";
            this.spbResult.Rounding = 30;
            this.spbResult.Size = new System.Drawing.Size(469, 31);
            this.spbResult.TabIndex = 8;
            this.spbResult.Value = 50F;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.rtlpaCandidate, 0, 1);
            this.tlpMain.Controls.Add(this.rtlpTest, 0, 0);
            this.tlpMain.Controls.Add(this.spQuestions, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(661, 496);
            this.tlpMain.TabIndex = 9;
            // 
            // rtlpaCandidate
            // 
            this.rtlpaCandidate.AutoSize = true;
            this.rtlpaCandidate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rtlpaCandidate.ColumnCount = 2;
            this.rtlpaCandidate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rtlpaCandidate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rtlpaCandidate.Controls.Add(this.spbResult, 1, 3);
            this.rtlpaCandidate.Controls.Add(this.lblMaxScore, 0, 2);
            this.rtlpaCandidate.Controls.Add(this.lblScore, 0, 1);
            this.rtlpaCandidate.Controls.Add(this.lblCandidateHeader, 0, 0);
            this.rtlpaCandidate.Controls.Add(this.lblAccuracy, 0, 3);
            this.rtlpaCandidate.Controls.Add(this.lblRightAnswersCount, 0, 4);
            this.rtlpaCandidate.Controls.Add(this.lblIncorrectAnswersCount, 1, 4);
            this.rtlpaCandidate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtlpaCandidate.Location = new System.Drawing.Point(3, 150);
            this.rtlpaCandidate.Name = "rtlpaCandidate";
            this.rtlpaCandidate.Rounding = 0;
            this.rtlpaCandidate.RowCount = 5;
            this.rtlpaCandidate.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlpaCandidate.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlpaCandidate.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlpaCandidate.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlpaCandidate.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rtlpaCandidate.Size = new System.Drawing.Size(655, 115);
            this.rtlpaCandidate.TabIndex = 10;
            // 
            // lblCandidateHeader
            // 
            this.lblCandidateHeader.AutoSize = true;
            this.lblCandidateHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCandidateHeader.Location = new System.Drawing.Point(3, 0);
            this.lblCandidateHeader.Name = "lblCandidateHeader";
            this.lblCandidateHeader.Size = new System.Drawing.Size(173, 24);
            this.lblCandidateHeader.TabIndex = 1;
            this.lblCandidateHeader.Text = "CandidateHeader";
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAccuracy.Location = new System.Drawing.Point(3, 56);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(63, 16);
            this.lblAccuracy.TabIndex = 9;
            this.lblAccuracy.Text = "Accuracy";
            // 
            // lblRightAnswersCount
            // 
            this.lblRightAnswersCount.AutoSize = true;
            this.lblRightAnswersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRightAnswersCount.Location = new System.Drawing.Point(3, 91);
            this.lblRightAnswersCount.Name = "lblRightAnswersCount";
            this.lblRightAnswersCount.Size = new System.Drawing.Size(176, 24);
            this.lblRightAnswersCount.TabIndex = 10;
            this.lblRightAnswersCount.Text = "RightAnswersCount";
            // 
            // lblIncorrectAnswersCount
            // 
            this.lblIncorrectAnswersCount.AutoSize = true;
            this.lblIncorrectAnswersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIncorrectAnswersCount.Location = new System.Drawing.Point(185, 91);
            this.lblIncorrectAnswersCount.Name = "lblIncorrectAnswersCount";
            this.lblIncorrectAnswersCount.Size = new System.Drawing.Size(206, 24);
            this.lblIncorrectAnswersCount.TabIndex = 11;
            this.lblIncorrectAnswersCount.Text = "IncorrectAnswersCount";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(661, 496);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.Shown += new System.EventHandler(this.ResultForm_Shown);
            this.rtlpTest.ResumeLayout(false);
            this.rtlpTest.PerformLayout();
            this.spQuestions.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.rtlpaCandidate.ResumeLayout(false);
            this.rtlpaCandidate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Label lblMaxScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTestAuthor;
        private System.Windows.Forms.Label lblTestDescription;
        private System.Windows.Forms.Label lblTestType;
        private Controls.Stat.StatProgressBar spbResult;
        private Controls.Spoiler spQuestions;
        private PowerLearn.Controls.AdjustableFlowLayoutPanel aflpQuestions;
        private Controls.RoundTableLayoutPanel rtlpTest;
        private System.Windows.Forms.Label lblTestHeader;
        private System.Windows.Forms.Label lblQuestionCount;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblQuestionCountText;
        private Controls.RoundTableLayoutPanel rtlpaCandidate;
        private System.Windows.Forms.Label lblCandidateHeader;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label lblRightAnswersCount;
        private System.Windows.Forms.Label lblIncorrectAnswersCount;
    }
}