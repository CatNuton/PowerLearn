namespace PowerLearnCreator.Forms
{
    partial class AuthorEditor
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
            this.aflpAccountSettings = new PowerLearnCreator.Controls.AdjustableFlowLayoutPanel();
            this.tbFirstName = new PowerLearnCreator.Controls.GoogleTextBox();
            this.tbLastName = new PowerLearnCreator.Controls.GoogleTextBox();
            this.tbPatronym = new PowerLearnCreator.Controls.GoogleTextBox();
            this.btnSaveAuthor = new System.Windows.Forms.Button();
            this.aflpAccountSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // aflpAccountSettings
            // 
            this.aflpAccountSettings.AutoScroll = true;
            this.aflpAccountSettings.AutoSize = true;
            this.aflpAccountSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aflpAccountSettings.Controls.Add(this.tbLastName);
            this.aflpAccountSettings.Controls.Add(this.tbFirstName);
            this.aflpAccountSettings.Controls.Add(this.tbPatronym);
            this.aflpAccountSettings.Controls.Add(this.btnSaveAuthor);
            this.aflpAccountSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aflpAccountSettings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.aflpAccountSettings.Location = new System.Drawing.Point(0, 0);
            this.aflpAccountSettings.Name = "aflpAccountSettings";
            this.aflpAccountSettings.Padding = new System.Windows.Forms.Padding(5, 10, 10, 10);
            this.aflpAccountSettings.Size = new System.Drawing.Size(241, 193);
            this.aflpAccountSettings.TabIndex = 3;
            this.aflpAccountSettings.WrapContents = false;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(8, 29);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.TextPreview = "First Name";
            this.tbFirstName.Size = new System.Drawing.Size(220, 22);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(8, 73);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbLastName.Name = "tbLastName";
            this.tbFirstName.TextPreview = "Last Name";
            this.tbLastName.Size = new System.Drawing.Size(220, 22);
            this.tbLastName.TabIndex = 2;
            this.tbFirstName.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // tbPatronym
            // 
            this.tbPatronym.Location = new System.Drawing.Point(8, 117);
            this.tbPatronym.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbPatronym.Name = "tbPatronym";
            this.tbFirstName.TextPreview = "Patronym";
            this.tbPatronym.Size = new System.Drawing.Size(220, 22);
            this.tbPatronym.TabIndex = 3;
            this.tbFirstName.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // btnSaveAuthor
            // 
            this.btnSaveAuthor.Enabled = false;
            this.btnSaveAuthor.Location = new System.Drawing.Point(8, 145);
            this.btnSaveAuthor.Name = "btnSaveAuthor";
            this.btnSaveAuthor.Size = new System.Drawing.Size(220, 23);
            this.btnSaveAuthor.TabIndex = 6;
            this.btnSaveAuthor.Text = "Save";
            this.btnSaveAuthor.UseVisualStyleBackColor = true;
            this.btnSaveAuthor.Click += new System.EventHandler(this.btnSaveAuthor_Click);
            // 
            // AuthorEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(241, 193);
            this.Controls.Add(this.aflpAccountSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorEditor";
            this.Text = "AuthorEditor";
            this.Deactivate += new System.EventHandler(this.AuthorEditor_Deactivate);
            this.aflpAccountSettings.ResumeLayout(false);
            this.aflpAccountSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.AdjustableFlowLayoutPanel aflpAccountSettings;
        private PowerLearnCreator.Controls.GoogleTextBox tbFirstName;
        private PowerLearnCreator.Controls.GoogleTextBox tbLastName;
        private PowerLearnCreator.Controls.GoogleTextBox tbPatronym;
        private System.Windows.Forms.Button btnSaveAuthor;
    }
}