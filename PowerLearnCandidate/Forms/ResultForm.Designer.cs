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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMaxScore = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblTestAuthor = new System.Windows.Forms.Label();
            this.lblTestType = new System.Windows.Forms.Label();
            this.lblTestDesription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTestName
            // 
            this.lblTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestName.Location = new System.Drawing.Point(17, 9);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(482, 25);
            this.lblTestName.TabIndex = 0;
            this.lblTestName.Text = "Name";
            this.lblTestName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.Location = new System.Drawing.Point(17, 47);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(482, 25);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxScore
            // 
            this.lblMaxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxScore.Location = new System.Drawing.Point(17, 86);
            this.lblMaxScore.Name = "lblMaxScore";
            this.lblMaxScore.Size = new System.Drawing.Size(482, 25);
            this.lblMaxScore.TabIndex = 2;
            this.lblMaxScore.Text = "Max Score";
            this.lblMaxScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(217, 226);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(77, 23);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "Upload result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnUploadResult_Click);
            // 
            // lblTestAuthor
            // 
            this.lblTestAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestAuthor.Location = new System.Drawing.Point(12, 120);
            this.lblTestAuthor.Name = "lblTestAuthor";
            this.lblTestAuthor.Size = new System.Drawing.Size(487, 25);
            this.lblTestAuthor.TabIndex = 4;
            this.lblTestAuthor.Text = "Author";
            this.lblTestAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTestType
            // 
            this.lblTestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestType.Location = new System.Drawing.Point(12, 154);
            this.lblTestType.Name = "lblTestType";
            this.lblTestType.Size = new System.Drawing.Size(487, 25);
            this.lblTestType.TabIndex = 5;
            this.lblTestType.Text = "Type";
            this.lblTestType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTestDesription
            // 
            this.lblTestDesription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestDesription.Location = new System.Drawing.Point(12, 189);
            this.lblTestDesription.Name = "lblTestDesription";
            this.lblTestDesription.Size = new System.Drawing.Size(487, 25);
            this.lblTestDesription.TabIndex = 6;
            this.lblTestDesription.Text = "Description";
            this.lblTestDesription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 309);
            this.Controls.Add(this.lblTestDesription);
            this.Controls.Add(this.lblTestType);
            this.Controls.Add(this.lblTestAuthor);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblMaxScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTestName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMaxScore;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblTestAuthor;
        private System.Windows.Forms.Label lblTestType;
        private System.Windows.Forms.Label lblTestDesription;
    }
}