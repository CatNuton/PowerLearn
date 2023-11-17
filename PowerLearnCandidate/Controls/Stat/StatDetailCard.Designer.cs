namespace PowerLearnCandidate.Controls.Stat
{
    partial class StatDetailCard
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblResultText = new System.Windows.Forms.Label();
            this.tlpAsnwers = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.pbQuestionImage = new System.Windows.Forms.PictureBox();
            this.lblResultValue = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.White;
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.lblResultText, 1, 1);
            this.tlpMain.Controls.Add(this.tlpAsnwers, 1, 0);
            this.tlpMain.Controls.Add(this.tlpLeft, 0, 0);
            this.tlpMain.Controls.Add(this.lblResultValue, 2, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(664, 255);
            this.tlpMain.TabIndex = 0;
            // 
            // lblResultText
            // 
            this.lblResultText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultText.Location = new System.Drawing.Point(198, 39);
            this.lblResultText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultText.Name = "lblResultText";
            this.lblResultText.Size = new System.Drawing.Size(381, 216);
            this.lblResultText.TabIndex = 2;
            this.lblResultText.Text = "Points:";
            this.lblResultText.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tlpAsnwers
            // 
            this.tlpAsnwers.AutoSize = true;
            this.tlpAsnwers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpAsnwers.ColumnCount = 1;
            this.tlpMain.SetColumnSpan(this.tlpAsnwers, 2);
            this.tlpAsnwers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAsnwers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAsnwers.Location = new System.Drawing.Point(198, 4);
            this.tlpAsnwers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpAsnwers.MinimumSize = new System.Drawing.Size(0, 31);
            this.tlpAsnwers.Name = "tlpAsnwers";
            this.tlpAsnwers.RowCount = 1;
            this.tlpAsnwers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAsnwers.Size = new System.Drawing.Size(462, 31);
            this.tlpAsnwers.TabIndex = 3;
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeft.Controls.Add(this.lblQuestionText, 0, 1);
            this.tlpLeft.Controls.Add(this.pbQuestionImage, 0, 0);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(4, 4);
            this.tlpLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 2;
            this.tlpMain.SetRowSpan(this.tlpLeft, 2);
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeft.Size = new System.Drawing.Size(186, 247);
            this.tlpLeft.TabIndex = 4;
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestionText.Location = new System.Drawing.Point(4, 123);
            this.lblQuestionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(178, 124);
            this.lblQuestionText.TabIndex = 1;
            this.lblQuestionText.Text = "label1";
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbQuestionImage
            // 
            this.pbQuestionImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbQuestionImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbQuestionImage.Location = new System.Drawing.Point(4, 4);
            this.pbQuestionImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbQuestionImage.Name = "pbQuestionImage";
            this.pbQuestionImage.Size = new System.Drawing.Size(178, 115);
            this.pbQuestionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQuestionImage.TabIndex = 0;
            this.pbQuestionImage.TabStop = false;
            // 
            // lblResultValue
            // 
            this.lblResultValue.AutoSize = true;
            this.lblResultValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResultValue.Location = new System.Drawing.Point(587, 39);
            this.lblResultValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultValue.Name = "lblResultValue";
            this.lblResultValue.Size = new System.Drawing.Size(73, 216);
            this.lblResultValue.TabIndex = 5;
            this.lblResultValue.Text = "label1";
            this.lblResultValue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // StatDetailCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StatDetailCard";
            this.Size = new System.Drawing.Size(664, 255);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpLeft.ResumeLayout(false);
            this.tlpLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.PictureBox pbQuestionImage;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Label lblResultText;
        private System.Windows.Forms.TableLayoutPanel tlpAsnwers;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.Label lblResultValue;
    }
}
