using PowerLearnCandidate.Controls;

namespace PowerLearnCandidate
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.singleAnswerControl = new PowerLearnCandidate.Controls.SingleAnswerControl();
            this.multipleAnswersControl = new PowerLearnCandidate.Controls.MultipleAnswersControl();
            this.navigationControl1 = new PowerLearnCandidate.NavigationControl();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBack.Location = new System.Drawing.Point(13, 223);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 22);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnForward.Location = new System.Drawing.Point(761, 223);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(80, 22);
            this.btnForward.TabIndex = 3;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Visible = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // singleAnswerControl
            // 
            this.singleAnswerControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.singleAnswerControl.Location = new System.Drawing.Point(0, 50);
            this.singleAnswerControl.Margin = new System.Windows.Forms.Padding(0);
            this.singleAnswerControl.MinimumSize = new System.Drawing.Size(537, 261);
            this.singleAnswerControl.Name = "singleAnswerControl";
            this.singleAnswerControl.Size = new System.Drawing.Size(854, 394);
            this.singleAnswerControl.TabIndex = 5;
            this.singleAnswerControl.Applied += new System.EventHandler<PowerLearnCandidate.Controls.StringEventArgs>(this.singleAnswerControl1_Applied);
            // 
            // multipleAnswersControl
            // 
            this.multipleAnswersControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multipleAnswersControl.Location = new System.Drawing.Point(0, 50);
            this.multipleAnswersControl.Margin = new System.Windows.Forms.Padding(4);
            this.multipleAnswersControl.MinimumSize = new System.Drawing.Size(538, 385);
            this.multipleAnswersControl.Name = "multipleAnswersControl";
            this.multipleAnswersControl.Size = new System.Drawing.Size(854, 393);
            this.multipleAnswersControl.TabIndex = 1;
            this.multipleAnswersControl.Visible = false;
            this.multipleAnswersControl.Applied += new System.EventHandler(this.multipleAnswersControl_Applied);
            this.multipleAnswersControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.multipleAnswersControl_MouseMove);
            // 
            // navigationControl1
            // 
            this.navigationControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationControl1.Location = new System.Drawing.Point(0, 0);
            this.navigationControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.navigationControl1.Name = "navigationControl1";
            this.navigationControl1.Size = new System.Drawing.Size(854, 50);
            this.navigationControl1.TabIndex = 4;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 443);
            this.Controls.Add(this.singleAnswerControl);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.multipleAnswersControl);
            this.Controls.Add(this.navigationControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private MultipleAnswersControl multipleAnswersControl;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private NavigationControl navigationControl1;
        private SingleAnswerControl singleAnswerControl;
    }
}