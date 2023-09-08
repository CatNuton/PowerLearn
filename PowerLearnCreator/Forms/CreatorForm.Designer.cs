namespace PowerLearnCreator
{
    partial class CreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatorForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnNewTest = new System.Windows.Forms.ToolStripButton();
            this.btnOpenTest = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCreateQuestion = new PowerLearnCreator.Controls.QuestionTypeSplitButton();
            this.btnTest = new System.Windows.Forms.ToolStripButton();
            this.btnTestOptions = new System.Windows.Forms.ToolStripButton();
            this.btnUser = new System.Windows.Forms.ToolStripButton();
            this.btnUpload = new System.Windows.Forms.ToolStripButton();
            this.spltTestCreator = new System.Windows.Forms.SplitContainer();
            this.adjflQuestionList = new PowerLearnCreator.QuestionsFlowLayoutPanel();
            this.QuestionControlPanel = new PowerLearnCreator.Controls.QuestionControl();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltTestCreator)).BeginInit();
            this.spltTestCreator.Panel1.SuspendLayout();
            this.spltTestCreator.Panel2.SuspendLayout();
            this.spltTestCreator.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Xml files| *.xml";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Xml file|*.xml";
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewTest,
            this.btnOpenTest,
            this.btnSave,
            this.btnSaveAs,
            this.toolStripSeparator1,
            this.btnCreateQuestion,
            this.btnTest,
            this.btnTestOptions,
            this.btnUser,
            this.btnUpload});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1052, 27);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // btnNewTest
            // 
            this.btnNewTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewTest.Image = global::PowerLearnCreator.Properties.Resources.New;
            this.btnNewTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewTest.Name = "btnNewTest";
            this.btnNewTest.Size = new System.Drawing.Size(29, 24);
            this.btnNewTest.Text = "New";
            this.btnNewTest.ToolTipText = "New ";
            this.btnNewTest.Click += new System.EventHandler(this.btnNewTest_Click);
            // 
            // btnOpenTest
            // 
            this.btnOpenTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenTest.Image = global::PowerLearnCreator.Properties.Resources.Open;
            this.btnOpenTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenTest.Name = "btnOpenTest";
            this.btnOpenTest.Size = new System.Drawing.Size(29, 24);
            this.btnOpenTest.Text = "Open";
            this.btnOpenTest.Click += new System.EventHandler(this.btnOpenTest_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::PowerLearnCreator.Properties.Resources.Save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(29, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSaveTest_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAs.Enabled = false;
            this.btnSaveAs.Image = global::PowerLearnCreator.Properties.Resources.Save_as;
            this.btnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(29, 24);
            this.btnSaveAs.Text = "Save as...";
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveTestAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnCreateQuestion
            // 
            this.btnCreateQuestion.Enabled = false;
            this.btnCreateQuestion.Image = global::PowerLearnCreator.Properties.Resources.Add;
            this.btnCreateQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateQuestion.Name = "btnCreateQuestion";
            this.btnCreateQuestion.SelectedValue = PowerLearn.QuestionType.MultipleAnswers;
            this.btnCreateQuestion.Size = new System.Drawing.Size(139, 24);
            this.btnCreateQuestion.Text = "Add Question";
            this.btnCreateQuestion.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btnCreateQuestion_DropDownItemClicked);
            // 
            // btnTest
            // 
            this.btnTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTest.Enabled = false;
            this.btnTest.Image = global::PowerLearnCreator.Properties.Resources.Test;
            this.btnTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(29, 24);
            this.btnTest.Text = "Enter your test";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnTestOptions
            // 
            this.btnTestOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTestOptions.Enabled = false;
            this.btnTestOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTestOptions.Image")));
            this.btnTestOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTestOptions.Name = "btnTestOptions";
            this.btnTestOptions.Size = new System.Drawing.Size(29, 24);
            this.btnTestOptions.Text = "Test Options";
            this.btnTestOptions.Click += new System.EventHandler(this.btnTestOptions_Click);
            // 
            // btnUser
            // 
            this.btnUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUser.Enabled = false;
            this.btnUser.Image = global::PowerLearnCreator.Properties.Resources.User;
            this.btnUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(29, 24);
            this.btnUser.Text = "User";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpload.Enabled = false;
            this.btnUpload.Image = global::PowerLearnCreator.Properties.Resources.Upload;
            this.btnUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(29, 24);
            this.btnUpload.Text = "Upload";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // spltTestCreator
            // 
            this.spltTestCreator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltTestCreator.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spltTestCreator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.spltTestCreator.IsSplitterFixed = true;
            this.spltTestCreator.Location = new System.Drawing.Point(0, 27);
            this.spltTestCreator.Margin = new System.Windows.Forms.Padding(4);
            this.spltTestCreator.Name = "spltTestCreator";
            // 
            // spltTestCreator.Panel1
            // 
            this.spltTestCreator.Panel1.BackColor = System.Drawing.Color.White;
            this.spltTestCreator.Panel1.Controls.Add(this.adjflQuestionList);
            // 
            // spltTestCreator.Panel2
            // 
            this.spltTestCreator.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.spltTestCreator.Panel2.Controls.Add(this.QuestionControlPanel);
            this.spltTestCreator.Size = new System.Drawing.Size(1052, 433);
            this.spltTestCreator.SplitterDistance = 100;
            this.spltTestCreator.SplitterWidth = 1;
            this.spltTestCreator.TabIndex = 0;
            this.spltTestCreator.TabStop = false;
            // 
            // adjflQuestionList
            // 
            this.adjflQuestionList.ActiveQuestion = null;
            this.adjflQuestionList.AutoScroll = true;
            this.adjflQuestionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adjflQuestionList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.adjflQuestionList.Location = new System.Drawing.Point(0, 0);
            this.adjflQuestionList.Margin = new System.Windows.Forms.Padding(4);
            this.adjflQuestionList.Name = "adjflQuestionList";
            this.adjflQuestionList.Size = new System.Drawing.Size(100, 433);
            this.adjflQuestionList.TabIndex = 3;
            this.adjflQuestionList.WrapContents = false;
            this.adjflQuestionList.ActiveQuestionChanged += new System.EventHandler<PowerLearnCreator.Controls.QuestionEventArgs>(this.adjustableFlowLayoutPanel1_ActiveQuestionChanged);
            this.adjflQuestionList.DeleteQuestion += new System.EventHandler<PowerLearnCreator.Controls.QuestionEventArgs>(this.adjflQuestionList_DeleteQuestion);
            // 
            // QuestionControlPanel
            // 
            this.QuestionControlPanel.AddAnswerEnabled = true;
            this.QuestionControlPanel.AutoSize = true;
            this.QuestionControlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.QuestionControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionControlPanel.Location = new System.Drawing.Point(0, 0);
            this.QuestionControlPanel.Margin = new System.Windows.Forms.Padding(5);
            this.QuestionControlPanel.Name = "QuestionControlPanel";
            this.QuestionControlPanel.QuestionText = null;
            this.QuestionControlPanel.Size = new System.Drawing.Size(951, 433);
            this.QuestionControlPanel.TabIndex = 2;
            this.QuestionControlPanel.Visible = false;
            this.QuestionControlPanel.AddAnswerClick += new System.EventHandler(this.qstcntrlQuestionRedactor_AddAnswerClick);
            this.QuestionControlPanel.DeleteAnswerClick += new System.EventHandler<PowerLearnCreator.Controls.AnswerEventArgs>(this.qstcntrlQuestionRedactor_DeleteAnswerClick);
            this.QuestionControlPanel.AddImageClick += new System.EventHandler<PowerLearnCreator.Controls.AddImageEventArgs>(this.qstcntrlQuestionRedactor_AddImageClick);
            this.QuestionControlPanel.DeleteImageClick += new System.EventHandler(this.qstcntrlQuestionRedactor_DeleteImageClick);
            // 
            // CreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 460);
            this.Controls.Add(this.spltTestCreator);
            this.Controls.Add(this.ToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1070, 507);
            this.Name = "CreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "0";
            this.Text = "Power Learn Creator";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.spltTestCreator.Panel1.ResumeLayout(false);
            this.spltTestCreator.Panel2.ResumeLayout(false);
            this.spltTestCreator.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltTestCreator)).EndInit();
            this.spltTestCreator.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton btnOpenTest;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnSaveAs;
        private System.Windows.Forms.ToolStripButton btnNewTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnTest;
        private System.Windows.Forms.ToolStripButton btnTestOptions;
        private System.Windows.Forms.SplitContainer spltTestCreator;
        private QuestionsFlowLayoutPanel adjflQuestionList;
        private System.Windows.Forms.ToolStripButton btnUser;
        private System.Windows.Forms.ToolStripButton btnUpload;
        private Controls.QuestionTypeSplitButton btnCreateQuestion;
        private Controls.QuestionControl QuestionControlPanel;
    }
}

