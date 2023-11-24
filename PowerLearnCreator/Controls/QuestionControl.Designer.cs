namespace PowerLearnCreator.Controls
{
    partial class QuestionControl
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
            this.grpAnswers = new System.Windows.Forms.GroupBox();
            this.adjflwpAnswerList = new PowerLearnCreator.Controls.AnswersFlowLayoutPanel();
            this.pnlControlAnswer = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gtbQuestionText = new PowerLearn.Controls.GoogleTextBox();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pctrQuestionImage = new System.Windows.Forms.PictureBox();
            this.cmsImageContextPanel = new System.Windows.Forms.ContextMenuStrip();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.grpAnswers.SuspendLayout();
            this.pnlControlAnswer.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrQuestionImage)).BeginInit();
            this.cmsImageContextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAnswers
            // 
            this.grpAnswers.AutoSize = true;
            this.grpAnswers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpAnswers.BackColor = System.Drawing.Color.White;
            this.tlpMain.SetColumnSpan(this.grpAnswers, 2);
            this.grpAnswers.Controls.Add(this.adjflwpAnswerList);
            this.grpAnswers.Controls.Add(this.pnlControlAnswer);
            this.grpAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAnswers.Location = new System.Drawing.Point(5, 210);
            this.grpAnswers.Margin = new System.Windows.Forms.Padding(4);
            this.grpAnswers.Name = "grpAnswers";
            this.grpAnswers.Padding = new System.Windows.Forms.Padding(4);
            this.grpAnswers.Size = new System.Drawing.Size(948, 313);
            this.grpAnswers.TabIndex = 8;
            this.grpAnswers.TabStop = false;
            this.grpAnswers.Text = "Answers";
            // 
            // adjflwpAnswerList
            // 
            this.adjflwpAnswerList.AutoScroll = true;
            this.adjflwpAnswerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adjflwpAnswerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adjflwpAnswerList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.adjflwpAnswerList.Location = new System.Drawing.Point(4, 17);
            this.adjflwpAnswerList.Margin = new System.Windows.Forms.Padding(4);
            this.adjflwpAnswerList.Name = "adjflwpAnswerList";
            this.adjflwpAnswerList.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.adjflwpAnswerList.Size = new System.Drawing.Size(880, 292);
            this.adjflwpAnswerList.TabIndex = 1;
            this.adjflwpAnswerList.WrapContents = false;
            // 
            // pnlControlAnswer
            // 
            this.pnlControlAnswer.BackColor = System.Drawing.Color.White;
            this.pnlControlAnswer.Controls.Add(this.btnAdd);
            this.pnlControlAnswer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControlAnswer.Location = new System.Drawing.Point(884, 17);
            this.pnlControlAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlControlAnswer.Name = "pnlControlAnswer";
            this.pnlControlAnswer.Size = new System.Drawing.Size(60, 292);
            this.pnlControlAnswer.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69F));
            this.tlpMain.Controls.Add(this.gtbQuestionText, 1, 0);
            this.tlpMain.Controls.Add(this.pnlImage, 0, 0);
            this.tlpMain.Controls.Add(this.grpAnswers, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61F));
            this.tlpMain.Size = new System.Drawing.Size(958, 528);
            this.tlpMain.TabIndex = 12;
            // 
            // gtbQuestionText
            // 
            this.gtbQuestionText.BackColor = System.Drawing.Color.White;
            this.gtbQuestionText.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.gtbQuestionText.BorderColorNotActive = System.Drawing.Color.DarkGray;
            this.gtbQuestionText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtbQuestionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gtbQuestionText.Font = new System.Drawing.Font("Arial", 11.25F);
            this.gtbQuestionText.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.gtbQuestionText.ForeColor = System.Drawing.Color.Black;
            this.gtbQuestionText.Location = new System.Drawing.Point(301, 4);
            this.gtbQuestionText.Multiline = true;
            this.gtbQuestionText.Name = "gtbQuestionText";
            this.gtbQuestionText.Padding = new System.Windows.Forms.Padding(5, 0, 5, 3);
            this.gtbQuestionText.SelectionStart = 0;
            this.gtbQuestionText.Size = new System.Drawing.Size(653, 198);
            this.gtbQuestionText.TabIndex = 16;
            this.gtbQuestionText.TextInput = "";
            this.gtbQuestionText.TextPreview = "Question text";
            this.gtbQuestionText.UseSystemPasswordChar = false;
            // 
            // pnlImage
            // 
            this.pnlImage.AutoSize = true;
            this.pnlImage.Controls.Add(this.lblMessage);
            this.pnlImage.Controls.Add(this.pctrQuestionImage);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImage.Location = new System.Drawing.Point(5, 5);
            this.pnlImage.Margin = new System.Windows.Forms.Padding(4);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Padding = new System.Windows.Forms.Padding(4);
            this.pnlImage.Size = new System.Drawing.Size(288, 196);
            this.pnlImage.TabIndex = 11;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMessage.Location = new System.Drawing.Point(4, 4);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(280, 188);
            this.lblMessage.TabIndex = 15;
            this.lblMessage.Text = "Double click here to open and add image!";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.DoubleClick += new System.EventHandler(this.ImageDoubleClick);
            // 
            // pctrQuestionImage
            // 
            this.pctrQuestionImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrQuestionImage.BackColor = System.Drawing.Color.White;
            this.pctrQuestionImage.ContextMenuStrip = this.cmsImageContextPanel;
            this.pctrQuestionImage.Location = new System.Drawing.Point(4, 4);
            this.pctrQuestionImage.Margin = new System.Windows.Forms.Padding(4);
            this.pctrQuestionImage.Name = "pctrQuestionImage";
            this.pctrQuestionImage.Size = new System.Drawing.Size(276, 188);
            this.pctrQuestionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrQuestionImage.TabIndex = 14;
            this.pctrQuestionImage.TabStop = false;
            this.pctrQuestionImage.DoubleClick += new System.EventHandler(this.ImageDoubleClick);
            // 
            // cmsImageContextPanel
            // 
            this.cmsImageContextPanel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsImageContextPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmsImageContextPanel.Name = "cmsImageContextPanel";
            this.cmsImageContextPanel.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "PNG file|*.png|JPG file| *.jpg;*.jpeg|All files|*.*";
            this.dlgOpen.SupportMultiDottedExtensions = true;
            this.dlgOpen.Title = "Select an image for the question";
            // 
            // QuestionControl
            // 
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuestionControl";
            this.Size = new System.Drawing.Size(958, 528);
            this.grpAnswers.ResumeLayout(false);
            this.pnlControlAnswer.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrQuestionImage)).EndInit();
            this.cmsImageContextPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpAnswers;
        private System.Windows.Forms.Panel pnlControlAnswer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pctrQuestionImage;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private AnswersFlowLayoutPanel adjflwpAnswerList;
        private System.Windows.Forms.ContextMenuStrip cmsImageContextPanel;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private PowerLearn.Controls.GoogleTextBox gtbQuestionText;
    }
}
