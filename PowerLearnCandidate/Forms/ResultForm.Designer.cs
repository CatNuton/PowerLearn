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
            this.spbResult = new PowerLearnCandidate.Controls.Stat.StatProgressBar();
            this.aflpQuestions = new PowerLearn.Controls.AdjustableFlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Location = new System.Drawing.Point(107, 89);
            this.lblTestName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(71, 16);
            this.lblTestName.TabIndex = 1;
            this.lblTestName.Text = "TestName";
            // 
            // lblMaxScore
            // 
            this.lblMaxScore.AutoSize = true;
            this.lblMaxScore.Location = new System.Drawing.Point(107, 188);
            this.lblMaxScore.Name = "lblMaxScore";
            this.lblMaxScore.Size = new System.Drawing.Size(68, 16);
            this.lblMaxScore.TabIndex = 3;
            this.lblMaxScore.Text = "MaxScore";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(107, 149);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(43, 16);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score";
            // 
            // lblTestAuthor
            // 
            this.lblTestAuthor.AutoSize = true;
            this.lblTestAuthor.Location = new System.Drawing.Point(107, 246);
            this.lblTestAuthor.Name = "lblTestAuthor";
            this.lblTestAuthor.Size = new System.Drawing.Size(72, 16);
            this.lblTestAuthor.TabIndex = 5;
            this.lblTestAuthor.Text = "TestAuthor";
            // 
            // lblTestDescription
            // 
            this.lblTestDescription.AutoSize = true;
            this.lblTestDescription.Location = new System.Drawing.Point(107, 304);
            this.lblTestDescription.Name = "lblTestDescription";
            this.lblTestDescription.Size = new System.Drawing.Size(102, 16);
            this.lblTestDescription.TabIndex = 6;
            this.lblTestDescription.Text = "TestDescription";
            // 
            // lblTestType
            // 
            this.lblTestType.AutoSize = true;
            this.lblTestType.Location = new System.Drawing.Point(355, 248);
            this.lblTestType.Name = "lblTestType";
            this.lblTestType.Size = new System.Drawing.Size(66, 16);
            this.lblTestType.TabIndex = 7;
            this.lblTestType.Text = "TestType";
            // 
            // spbResult
            // 
            this.spbResult.BackColor = System.Drawing.Color.Transparent;
            this.spbResult.ForeColor = System.Drawing.Color.White;
            this.spbResult.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.spbResult.LeftText = "Правильно";
            this.spbResult.Location = new System.Drawing.Point(233, 142);
            this.spbResult.Name = "spbResult";
            this.spbResult.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.spbResult.RightText = "Неправильно";
            this.spbResult.Rounding = 30;
            this.spbResult.Size = new System.Drawing.Size(551, 60);
            this.spbResult.TabIndex = 8;
            this.spbResult.Value = 50F;
            // 
            // aflpQuestions
            // 
            this.aflpQuestions.AutoScroll = true;
            this.aflpQuestions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aflpQuestions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.aflpQuestions.Location = new System.Drawing.Point(0, 454);
            this.aflpQuestions.Name = "aflpQuestions";
            this.aflpQuestions.Size = new System.Drawing.Size(811, 135);
            this.aflpQuestions.TabIndex = 2;
            this.aflpQuestions.WrapContents = false;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(811, 589);
            this.Controls.Add(this.spbResult);
            this.Controls.Add(this.lblTestType);
            this.Controls.Add(this.lblTestDescription);
            this.Controls.Add(this.lblTestAuthor);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblMaxScore);
            this.Controls.Add(this.aflpQuestions);
            this.Controls.Add(this.lblTestName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Label lblMaxScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTestAuthor;
        private System.Windows.Forms.Label lblTestDescription;
        private System.Windows.Forms.Label lblTestType;
        private Controls.Stat.StatProgressBar spbResult;
        private PowerLearn.Controls.AdjustableFlowLayoutPanel aflpQuestions;
    }
}