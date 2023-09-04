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
            this.lblTestsForTest = new System.Windows.Forms.Label();
            this.placeholder = new System.Windows.Forms.Placeholder(this.components);
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbPatronym = new System.Windows.Forms.TextBox();
            this.btnStartTest = new PowerLearnCandidate.Controls.RoundedButton();
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
            // lblTestsForTest
            // 
            this.lblTestsForTest.Location = new System.Drawing.Point(345, 68);
            this.lblTestsForTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestsForTest.Name = "lblTestsForTest";
            this.lblTestsForTest.Size = new System.Drawing.Size(287, 121);
            this.lblTestsForTest.TabIndex = 1;
            this.lblTestsForTest.Text = "You can use these additional tests to see, how to solve tests in Power Learn:\r\n1." +
    " Test where you can\'t see all the questions. Id: test1\r\n2. Test where you can se" +
    "e all the questions. Id: test2\r\n";
            this.lblTestsForTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // placeholder
            // 
            this.placeholder.ShowOnFocus = true;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(21, 68);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.Name = "tbId";
            this.placeholder.SetPlaceholder(this.tbId, "Test id");
            this.tbId.Size = new System.Drawing.Size(183, 22);
            this.tbId.TabIndex = 2;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(21, 100);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Name = "tbFirstName";
            this.placeholder.SetPlaceholder(this.tbFirstName, "First name");
            this.tbFirstName.Size = new System.Drawing.Size(183, 22);
            this.tbFirstName.TabIndex = 3;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(21, 132);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Name = "tbLastName";
            this.placeholder.SetPlaceholder(this.tbLastName, "Last name");
            this.tbLastName.Size = new System.Drawing.Size(183, 22);
            this.tbLastName.TabIndex = 4;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // tbPatronym
            // 
            this.tbPatronym.Location = new System.Drawing.Point(21, 166);
            this.tbPatronym.Margin = new System.Windows.Forms.Padding(4);
            this.tbPatronym.Name = "tbPatronym";
            this.placeholder.SetPlaceholder(this.tbPatronym, "Patronym");
            this.tbPatronym.Size = new System.Drawing.Size(183, 22);
            this.tbPatronym.TabIndex = 5;
            this.tbPatronym.TextChanged += new System.EventHandler(this.tbPatronym_TextChanged);
            // 
            // btnStartTest
            // 
            this.btnStartTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStartTest.Enabled = false;
            this.btnStartTest.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStartTest.HoverColor2 = System.Drawing.Color.Silver;
            this.btnStartTest.IsRounded = false;
            this.btnStartTest.Location = new System.Drawing.Point(21, 202);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Rounding = 0;
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
            this.ClientSize = new System.Drawing.Size(648, 255);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.tbPatronym);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblTestsForTest);
            this.Controls.Add(this.lblAtention);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EnterDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PowerLearn - candidate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtention;
        private System.Windows.Forms.Label lblTestsForTest;
        private System.Windows.Forms.Placeholder placeholder;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbPatronym;
        private Controls.RoundedButton btnStartTest;
    }
}

