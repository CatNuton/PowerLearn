namespace PowerLearnCandidate.Controls
{
    partial class MultipleAnswersControl
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
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tlpAnswersPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnApply = new PowerLearn.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestionText.BackColor = System.Drawing.Color.Black;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestionText.ForeColor = System.Drawing.Color.White;
            this.lblQuestionText.Location = new System.Drawing.Point(320, 0);
            this.lblQuestionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(635, 203);
            this.lblQuestionText.TabIndex = 5;
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.BackColor = System.Drawing.Color.Black;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(4, 4);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(308, 195);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // tlpAnswersPanel
            // 
            this.tlpAnswersPanel.BackColor = System.Drawing.Color.Black;
            this.tlpAnswersPanel.ColumnCount = 1;
            this.tableLayoutPanel.SetColumnSpan(this.tlpAnswersPanel, 2);
            this.tlpAnswersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAnswersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAnswersPanel.Location = new System.Drawing.Point(4, 207);
            this.tlpAnswersPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tlpAnswersPanel.Name = "tlpAnswersPanel";
            this.tlpAnswersPanel.RowCount = 1;
            this.tlpAnswersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAnswersPanel.Size = new System.Drawing.Size(951, 196);
            this.tlpAnswersPanel.TabIndex = 7;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.lblQuestionText, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.tlpAnswersPanel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pbImage, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(959, 407);
            this.tableLayoutPanel.TabIndex = 8;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.White;
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApply.HoverColor1 = System.Drawing.Color.Empty;
            this.btnApply.HoverColor2 = System.Drawing.Color.Empty;
            this.btnApply.IsRounded = true;
            this.btnApply.Location = new System.Drawing.Point(0, 407);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Rounding = 60;
            this.btnApply.Size = new System.Drawing.Size(959, 74);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Check";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // MultipleAnswersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.btnApply);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(672, 481);
            this.Name = "MultipleAnswersControl";
            this.Size = new System.Drawing.Size(959, 481);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TableLayoutPanel tlpAnswersPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private PowerLearn.Controls.RoundedButton btnApply;
    }
}
