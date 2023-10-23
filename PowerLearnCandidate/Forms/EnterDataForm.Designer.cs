namespace PowerLearnCandidate
{
    partial class EnterDataForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterDataForm));
            this.lblAtention = new System.Windows.Forms.Label();
            this.placeholder = new System.Windows.Forms.Placeholder(this.components);
            this.tbPatronym = new PowerLearn.Controls.GoogleTextBox();
            this.tbFirstName = new PowerLearn.Controls.GoogleTextBox();
            this.tbLastName = new PowerLearn.Controls.GoogleTextBox();
            this.tbId = new PowerLearn.Controls.GoogleTextBox();
            this.btnStartTest = new PowerLearn.Controls.RoundedButton();
            this.SuspendLayout();
            // 
            // lblAtention
            // 
            this.lblAtention.Location = new System.Drawing.Point(17, 16);
            this.lblAtention.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtention.Name = "lblAtention";
            this.lblAtention.Size = new System.Drawing.Size(615, 38);
            this.lblAtention.TabIndex = 0;
            this.lblAtention.Text = "Attention! \r\nAfter the test starts, the program will enter to fullscreen mode!";
            this.lblAtention.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // placeholder
            // 
            this.placeholder.ShowOnFocus = true;
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
            this.tbPatronym.Location = new System.Drawing.Point(21, 206);
            this.tbPatronym.Name = "tbPatronym";
            this.tbPatronym.Padding = new System.Windows.Forms.Padding(5, 0, 5, 3);
            this.tbPatronym.SelectionStart = 0;
            this.tbPatronym.Size = new System.Drawing.Size(245, 40);
            this.tbPatronym.TabIndex = 5;
            this.tbPatronym.TextInput = "";
            this.tbPatronym.TextPreview = "Patronym";
            this.tbPatronym.UseSystemPasswordChar = false;
            this.tbPatronym.TextChanged += new System.EventHandler(this.tbPatronym_TextChanged);
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
            this.tbFirstName.Location = new System.Drawing.Point(21, 160);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Padding = new System.Windows.Forms.Padding(5, 0, 5, 3);
            this.tbFirstName.SelectionStart = 0;
            this.tbFirstName.Size = new System.Drawing.Size(245, 40);
            this.tbFirstName.TabIndex = 4;
            this.tbFirstName.TextInput = "";
            this.tbFirstName.TextPreview = "First Name";
            this.tbFirstName.UseSystemPasswordChar = false;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
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
            this.tbLastName.Location = new System.Drawing.Point(20, 114);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Padding = new System.Windows.Forms.Padding(5, 0, 5, 3);
            this.tbLastName.SelectionStart = 0;
            this.tbLastName.Size = new System.Drawing.Size(245, 40);
            this.tbLastName.TabIndex = 3;
            this.tbLastName.TextInput = "";
            this.tbLastName.TextPreview = "Last Name";
            this.tbLastName.UseSystemPasswordChar = false;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.White;
            this.tbId.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.tbId.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.tbId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbId.Font = new System.Drawing.Font("Arial", 11F);
            this.tbId.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbId.ForeColor = System.Drawing.Color.Black;
            this.tbId.Location = new System.Drawing.Point(20, 68);
            this.tbId.Name = "tbId";
            this.tbId.Padding = new System.Windows.Forms.Padding(5, 0, 5, 3);
            this.tbId.SelectionStart = 0;
            this.tbId.Size = new System.Drawing.Size(245, 40);
            this.tbId.TabIndex = 2;
            this.tbId.TextInput = "";
            this.tbId.TextPreview = "ID";
            this.tbId.UseSystemPasswordChar = false;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // btnStartTest
            // 
            this.btnStartTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStartTest.Enabled = false;
            this.btnStartTest.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStartTest.HoverColor2 = System.Drawing.Color.Silver;
            this.btnStartTest.IsRounded = true;
            this.btnStartTest.Location = new System.Drawing.Point(20, 255);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Rounding = 80;
            this.btnStartTest.Size = new System.Drawing.Size(611, 41);
            this.btnStartTest.TabIndex = 6;
            this.btnStartTest.Text = "Start!";
            this.btnStartTest.UseVisualStyleBackColor = false;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // EnterDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 306);
            this.Controls.Add(this.tbPatronym);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.lblAtention);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EnterDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PowerLearn - candidate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAtention;
        private System.Windows.Forms.Placeholder placeholder;
        private PowerLearn.Controls.RoundedButton btnStartTest;
        private PowerLearn.Controls.GoogleTextBox tbId;
        private PowerLearn.Controls.GoogleTextBox tbLastName;
        private PowerLearn.Controls.GoogleTextBox tbFirstName;
        private PowerLearn.Controls.GoogleTextBox tbPatronym;
    }
}

