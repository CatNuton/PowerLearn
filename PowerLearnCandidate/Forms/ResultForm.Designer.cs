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
            this.spQuestions = new PowerLearnCandidate.Controls.Spoiler();
            this.aflpQuestions = new PowerLearn.Controls.AdjustableFlowLayoutPanel();
            this.spbResult = new PowerLearnCandidate.Controls.Stat.StatProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.spQuestions.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Location = new System.Drawing.Point(340, 33);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(56, 13);
            this.lblTestName.TabIndex = 1;
            this.lblTestName.Text = "TestName";
            // 
            // lblMaxScore
            // 
            this.lblMaxScore.AutoSize = true;
            this.lblMaxScore.Location = new System.Drawing.Point(339, 0);
            this.lblMaxScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxScore.Name = "lblMaxScore";
            this.lblMaxScore.Size = new System.Drawing.Size(55, 13);
            this.lblMaxScore.TabIndex = 3;
            this.lblMaxScore.Text = "MaxScore";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(2, 0);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score";
            // 
            // lblTestAuthor
            // 
            this.lblTestAuthor.AutoSize = true;
            this.lblTestAuthor.Location = new System.Drawing.Point(2, 66);
            this.lblTestAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestAuthor.Name = "lblTestAuthor";
            this.lblTestAuthor.Size = new System.Drawing.Size(59, 13);
            this.lblTestAuthor.TabIndex = 5;
            this.lblTestAuthor.Text = "TestAuthor";
            // 
            // lblTestDescription
            // 
            this.lblTestDescription.AutoSize = true;
            this.lblTestDescription.Location = new System.Drawing.Point(339, 66);
            this.lblTestDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestDescription.Name = "lblTestDescription";
            this.lblTestDescription.Size = new System.Drawing.Size(81, 13);
            this.lblTestDescription.TabIndex = 6;
            this.lblTestDescription.Text = "TestDescription";
            // 
            // lblTestType
            // 
            this.lblTestType.AutoSize = true;
            this.lblTestType.Location = new System.Drawing.Point(2, 33);
            this.lblTestType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTestType.Name = "lblTestType";
            this.lblTestType.Size = new System.Drawing.Size(52, 13);
            this.lblTestType.TabIndex = 7;
            this.lblTestType.Text = "TestType";
            // 
            // spQuestions
            // 
            this.spQuestions.CollapsedText = "Show more";
            this.spQuestions.Controls.Add(this.aflpQuestions);
            this.spQuestions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.spQuestions.Location = new System.Drawing.Point(0, 155);
            this.spQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.spQuestions.Name = "spQuestions";
            this.spQuestions.Size = new System.Drawing.Size(674, 180);
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
            this.aflpQuestions.Size = new System.Drawing.Size(674, 162);
            this.aflpQuestions.TabIndex = 10;
            this.aflpQuestions.WrapContents = false;
            // 
            // spbResult
            // 
            this.spbResult.BackColor = System.Drawing.Color.Transparent;
            this.spbResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.spbResult.ForeColor = System.Drawing.Color.White;
            this.spbResult.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.spbResult.LeftText = "Правильно";
            this.spbResult.Location = new System.Drawing.Point(0, 100);
            this.spbResult.Margin = new System.Windows.Forms.Padding(2);
            this.spbResult.Name = "spbResult";
            this.spbResult.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(67)))));
            this.spbResult.RightText = "Неправильно";
            this.spbResult.Rounding = 30;
            this.spbResult.Size = new System.Drawing.Size(674, 49);
            this.spbResult.TabIndex = 8;
            this.spbResult.Value = 50F;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblScore, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMaxScore, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTestType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTestAuthor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTestDescription, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTestName, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 100);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(674, 335);
            this.Controls.Add(this.spbResult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.spQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.Shown += new System.EventHandler(this.ResultForm_Shown);
            this.spQuestions.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}