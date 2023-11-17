using PowerLearn.Controls;

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
            this.aflpAccountSettings = new PowerLearn.Controls.AdjustableFlowLayoutPanel();
            this.tbLastName = new PowerLearn.Controls.GoogleTextBox();
            this.tbFirstName = new PowerLearn.Controls.GoogleTextBox();
            this.tbPatronym = new PowerLearn.Controls.GoogleTextBox();
            this.btnSaveAuthor = new PowerLearn.Controls.RoundedButton();
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
            this.aflpAccountSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aflpAccountSettings.Name = "aflpAccountSettings";
            this.aflpAccountSettings.Padding = new System.Windows.Forms.Padding(4, 8, 8, 8);
            this.aflpAccountSettings.Size = new System.Drawing.Size(195, 168);
            this.aflpAccountSettings.TabIndex = 3;
            this.aflpAccountSettings.WrapContents = false;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.White;
            this.tbLastName.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.tbLastName.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.tbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLastName.Font = new System.Drawing.Font("Arial", 11F);
            this.tbLastName.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbLastName.ForeColor = System.Drawing.Color.Black;
            this.tbLastName.Location = new System.Drawing.Point(6, 10);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Padding = new System.Windows.Forms.Padding(4, 0, 4, 2);
            this.tbLastName.SelectionStart = 0;
            this.tbLastName.Size = new System.Drawing.Size(179, 32);
            this.tbLastName.TabIndex = 7;
            this.tbLastName.TextInput = "";
            this.tbLastName.TextPreview = "Last Name";
            this.tbLastName.UseSystemPasswordChar = false;
            this.tbLastName.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.White;
            this.tbFirstName.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.tbFirstName.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFirstName.Font = new System.Drawing.Font("Arial", 11F);
            this.tbFirstName.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbFirstName.Location = new System.Drawing.Point(6, 46);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Padding = new System.Windows.Forms.Padding(4, 0, 4, 2);
            this.tbFirstName.SelectionStart = 0;
            this.tbFirstName.Size = new System.Drawing.Size(179, 32);
            this.tbFirstName.TabIndex = 8;
            this.tbFirstName.TextInput = "";
            this.tbFirstName.TextPreview = "First Name";
            this.tbFirstName.UseSystemPasswordChar = false;
            this.tbFirstName.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // tbPatronym
            // 
            this.tbPatronym.BackColor = System.Drawing.Color.White;
            this.tbPatronym.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.tbPatronym.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.tbPatronym.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPatronym.Font = new System.Drawing.Font("Arial", 11F);
            this.tbPatronym.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbPatronym.ForeColor = System.Drawing.Color.Black;
            this.tbPatronym.Location = new System.Drawing.Point(6, 82);
            this.tbPatronym.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPatronym.Name = "tbPatronym";
            this.tbPatronym.Padding = new System.Windows.Forms.Padding(4, 0, 4, 2);
            this.tbPatronym.SelectionStart = 0;
            this.tbPatronym.Size = new System.Drawing.Size(179, 32);
            this.tbPatronym.TabIndex = 9;
            this.tbPatronym.TextInput = "";
            this.tbPatronym.TextPreview = "Patronym";
            this.tbPatronym.UseSystemPasswordChar = false;
            this.tbPatronym.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // btnSaveAuthor
            // 
            this.btnSaveAuthor.BackColor = System.Drawing.Color.White;
            this.btnSaveAuthor.Enabled = false;
            this.btnSaveAuthor.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveAuthor.HoverColor2 = System.Drawing.Color.Silver;
            this.btnSaveAuthor.IsRounded = true;
            this.btnSaveAuthor.Location = new System.Drawing.Point(6, 118);
            this.btnSaveAuthor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveAuthor.Name = "btnSaveAuthor";
            this.btnSaveAuthor.Rounding = 30;
            this.btnSaveAuthor.Size = new System.Drawing.Size(179, 32);
            this.btnSaveAuthor.TabIndex = 6;
            this.btnSaveAuthor.Text = "Save";
            this.btnSaveAuthor.UseVisualStyleBackColor = false;
            this.btnSaveAuthor.Click += new System.EventHandler(this.btnSaveAuthor_Click);
            // 
            // AuthorEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(195, 168);
            this.Controls.Add(this.aflpAccountSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AuthorEditor";
            this.Text = "AuthorEditor";
            this.Deactivate += new System.EventHandler(this.AuthorEditor_Deactivate);
            this.aflpAccountSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdjustableFlowLayoutPanel aflpAccountSettings;
        private PowerLearn.Controls.RoundedButton btnSaveAuthor;
        private PowerLearn.Controls.GoogleTextBox tbPatronym;
        private GoogleTextBox tbFirstName;
        private PowerLearn.Controls.GoogleTextBox tbLastName;
    }
}