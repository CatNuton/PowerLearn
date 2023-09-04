namespace PowerLearnCandidate.Controls
{
    partial class AnswerVariant
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
            this.cbIsChecked = new System.Windows.Forms.CheckBox();
            this.btnSelect = new PowerLearnCandidate.Controls.RoundedButton();
            this.SuspendLayout();
            // 
            // cbIsChecked
            // 
            this.cbIsChecked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIsChecked.AutoSize = true;
            this.cbIsChecked.Location = new System.Drawing.Point(158, 22);
            this.cbIsChecked.Margin = new System.Windows.Forms.Padding(4);
            this.cbIsChecked.Name = "cbIsChecked";
            this.cbIsChecked.Size = new System.Drawing.Size(18, 17);
            this.cbIsChecked.TabIndex = 0;
            this.cbIsChecked.UseVisualStyleBackColor = true;
            this.cbIsChecked.CheckedChanged += new System.EventHandler(this.cbIsChecked_CheckedChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelect.ForeColor = System.Drawing.Color.Black;
            this.btnSelect.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSelect.HoverColor2 = System.Drawing.Color.Gray;
            this.btnSelect.IsRounded = true;
            this.btnSelect.Location = new System.Drawing.Point(0, 0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Rounding = 30;
            this.btnSelect.Size = new System.Drawing.Size(199, 184);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Text";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // AnswerVariant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.cbIsChecked);
            this.Controls.Add(this.btnSelect);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnswerVariant";
            this.Size = new System.Drawing.Size(199, 184);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbIsChecked;
        private RoundedButton btnSelect;
    }
}
