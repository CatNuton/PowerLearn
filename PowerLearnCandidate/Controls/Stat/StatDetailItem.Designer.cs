namespace PowerLearnCandidate.Controls.Stat
{
    partial class StatDetailItem
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
            this.pbCheckedImage = new System.Windows.Forms.PictureBox();
            this.lblAnswerText = new System.Windows.Forms.Label();
            this.lblAnswerWeight = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.pbCheckedImage, 0, 0);
            this.tlpMain.Controls.Add(this.lblAnswerText, 1, 0);
            this.tlpMain.Controls.Add(this.lblAnswerWeight, 2, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(371, 35);
            this.tlpMain.TabIndex = 0;
            // 
            // pbCheckedImage
            // 
            this.pbCheckedImage.Location = new System.Drawing.Point(4, 4);
            this.pbCheckedImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbCheckedImage.Name = "pbCheckedImage";
            this.pbCheckedImage.Size = new System.Drawing.Size(29, 27);
            this.pbCheckedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCheckedImage.TabIndex = 0;
            this.pbCheckedImage.TabStop = false;
            // 
            // lblAnswerText
            // 
            this.lblAnswerText.AutoSize = true;
            this.lblAnswerText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnswerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnswerText.Location = new System.Drawing.Point(41, 0);
            this.lblAnswerText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswerText.Name = "lblAnswerText";
            this.lblAnswerText.Size = new System.Drawing.Size(159, 35);
            this.lblAnswerText.TabIndex = 1;
            this.lblAnswerText.Text = "lblAnswerText";
            this.lblAnswerText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnswerWeight
            // 
            this.lblAnswerWeight.AutoSize = true;
            this.lblAnswerWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnswerWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnswerWeight.Location = new System.Drawing.Point(208, 0);
            this.lblAnswerWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswerWeight.Name = "lblAnswerWeight";
            this.lblAnswerWeight.Size = new System.Drawing.Size(159, 35);
            this.lblAnswerWeight.TabIndex = 2;
            this.lblAnswerWeight.Text = "lblAnswerWeight";
            this.lblAnswerWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatDetailItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StatDetailItem";
            this.Size = new System.Drawing.Size(371, 35);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.PictureBox pbCheckedImage;
        private System.Windows.Forms.Label lblAnswerText;
        private System.Windows.Forms.Label lblAnswerWeight;
    }
}
