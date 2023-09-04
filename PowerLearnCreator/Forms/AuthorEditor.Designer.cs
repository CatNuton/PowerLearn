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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblPatronym = new System.Windows.Forms.Label();
            this.tbPatronym = new System.Windows.Forms.TextBox();
            this.btnSaveAuthor = new System.Windows.Forms.Button();
            this.aflpAccountSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // aflpAccountSettings
            // 
            this.aflpAccountSettings.AutoScroll = true;
            this.aflpAccountSettings.AutoSize = true;
            this.aflpAccountSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aflpAccountSettings.Controls.Add(this.lblFirstName);
            this.aflpAccountSettings.Controls.Add(this.tbFirstName);
            this.aflpAccountSettings.Controls.Add(this.lblLastName);
            this.aflpAccountSettings.Controls.Add(this.tbLastName);
            this.aflpAccountSettings.Controls.Add(this.lblPatronym);
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
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(8, 13);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 16);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(8, 29);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(220, 22);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.Click += new System.EventHandler(this.tbFirstName_TextChanged);
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(8, 57);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(8, 73);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(220, 22);
            this.tbLastName.TabIndex = 3;
            // 
            // lblPatronym
            // 
            this.lblPatronym.AutoSize = true;
            this.lblPatronym.Location = new System.Drawing.Point(8, 101);
            this.lblPatronym.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblPatronym.Name = "lblPatronym";
            this.lblPatronym.Size = new System.Drawing.Size(64, 16);
            this.lblPatronym.TabIndex = 4;
            this.lblPatronym.Text = "Patronym";
            // 
            // tbPatronym
            // 
            this.tbPatronym.Location = new System.Drawing.Point(8, 117);
            this.tbPatronym.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbPatronym.Name = "tbPatronym";
            this.tbPatronym.Size = new System.Drawing.Size(220, 22);
            this.tbPatronym.TabIndex = 5;
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
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblPatronym;
        private System.Windows.Forms.TextBox tbPatronym;
        private System.Windows.Forms.Button btnSaveAuthor;
    }
}