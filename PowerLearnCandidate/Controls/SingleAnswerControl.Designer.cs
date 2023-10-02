namespace PowerLearnCandidate.Controls
{
    partial class SingleAnswerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnApply = new PowerLearnCandidate.Controls.RoundedButton();
            this.tbAnswer = new PowerLearnCandidate.Controls.GoogleTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tlpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Black;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(4, 4);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(260, 232);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestionText.ForeColor = System.Drawing.Color.Black;
            this.lblQuestionText.Location = new System.Drawing.Point(272, 0);
            this.lblQuestionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(683, 240);
            this.lblQuestionText.TabIndex = 1;
            this.lblQuestionText.Text = "Text";
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpContainer
            // 
            this.tlpContainer.BackColor = System.Drawing.Color.White;
            this.tlpContainer.ColumnCount = 2;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.Controls.Add(this.lblQuestionText, 1, 0);
            this.tlpContainer.Controls.Add(this.pbImage, 0, 0);
            this.tlpContainer.Controls.Add(this.btnApply, 0, 3);
            this.tlpContainer.Controls.Add(this.tbAnswer, 0, 2);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 5;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.Size = new System.Drawing.Size(959, 508);
            this.tlpContainer.TabIndex = 4;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnApply.Enabled = false;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApply.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnApply.HoverColor2 = System.Drawing.Color.Silver;
            this.btnApply.IsRounded = true;
            this.btnApply.Location = new System.Drawing.Point(12, 379);
            this.btnApply.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Rounding = 80;
            this.btnApply.Size = new System.Drawing.Size(253, 41);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Check";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tbAnswer
            // 
            this.tbAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAnswer.BackColor = System.Drawing.Color.White;
            this.tbAnswer.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.tbAnswer.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.tlpContainer.SetColumnSpan(this.tbAnswer, 2);
            this.tbAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAnswer.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbAnswer.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbAnswer.ForeColor = System.Drawing.Color.Black;
            this.tbAnswer.Location = new System.Drawing.Point(12, 329);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.SelectionStart = 0;
            this.tbAnswer.Size = new System.Drawing.Size(935, 40);
            this.tbAnswer.TabIndex = 8;
            this.tbAnswer.TextInput = "";
            this.tbAnswer.TextPreview = "Answer";
            this.tbAnswer.UseSystemPasswordChar = false;
            this.tbAnswer.TextChanged += new System.EventHandler(this.tbAnswer_TextChanged);
            // 
            // SingleAnswerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(706, 406);
            this.Name = "SingleAnswerControl";
            this.Size = new System.Drawing.Size(959, 508);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tlpContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private RoundedButton btnApply;
        private GoogleTextBox tbAnswer;
    }
}
