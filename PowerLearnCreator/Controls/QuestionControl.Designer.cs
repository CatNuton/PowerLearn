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
            this.components = new System.ComponentModel.Container();
            this.txtbxQuestionText = new System.Windows.Forms.TextBox();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.grpAnswers = new System.Windows.Forms.GroupBox();
            this.adjflwpAnswerList = new PowerLearnCreator.Controls.AnswersFlowLayoutPanel();
            this.pnlControlAnswer = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tblltQuestionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pctrQuestionImage = new System.Windows.Forms.PictureBox();
            this.cmsImageContextPanel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.grpAnswers.SuspendLayout();
            this.pnlControlAnswer.SuspendLayout();
            this.tblltQuestionPanel.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrQuestionImage)).BeginInit();
            this.cmsImageContextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxQuestionText
            // 
            this.txtbxQuestionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxQuestionText.Location = new System.Drawing.Point(5, 110);
            this.txtbxQuestionText.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxQuestionText.Multiline = true;
            this.txtbxQuestionText.Name = "txtbxQuestionText";
            this.txtbxQuestionText.Size = new System.Drawing.Size(948, 100);
            this.txtbxQuestionText.TabIndex = 10;
            this.txtbxQuestionText.TextChanged += new System.EventHandler(this.txtbxQuestionText_TextChanged);
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestionText.Location = new System.Drawing.Point(5, 82);
            this.lblQuestionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(948, 23);
            this.lblQuestionText.TabIndex = 9;
            this.lblQuestionText.Text = "Text of question";
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpAnswers
            // 
            this.grpAnswers.AutoSize = true;
            this.grpAnswers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpAnswers.BackColor = System.Drawing.Color.White;
            this.grpAnswers.Controls.Add(this.adjflwpAnswerList);
            this.grpAnswers.Controls.Add(this.pnlControlAnswer);
            this.grpAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAnswers.Location = new System.Drawing.Point(5, 219);
            this.grpAnswers.Margin = new System.Windows.Forms.Padding(4);
            this.grpAnswers.Name = "grpAnswers";
            this.grpAnswers.Padding = new System.Windows.Forms.Padding(4);
            this.grpAnswers.Size = new System.Drawing.Size(948, 304);
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
            this.adjflwpAnswerList.Size = new System.Drawing.Size(880, 283);
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
            this.pnlControlAnswer.Size = new System.Drawing.Size(60, 283);
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
            // tblltQuestionPanel
            // 
            this.tblltQuestionPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblltQuestionPanel.ColumnCount = 1;
            this.tblltQuestionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblltQuestionPanel.Controls.Add(this.pnlImage, 0, 0);
            this.tblltQuestionPanel.Controls.Add(this.txtbxQuestionText, 0, 2);
            this.tblltQuestionPanel.Controls.Add(this.lblQuestionText, 0, 1);
            this.tblltQuestionPanel.Controls.Add(this.grpAnswers, 0, 3);
            this.tblltQuestionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblltQuestionPanel.Location = new System.Drawing.Point(0, 0);
            this.tblltQuestionPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tblltQuestionPanel.Name = "tblltQuestionPanel";
            this.tblltQuestionPanel.RowCount = 4;
            this.tblltQuestionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblltQuestionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblltQuestionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblltQuestionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblltQuestionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblltQuestionPanel.Size = new System.Drawing.Size(958, 528);
            this.tblltQuestionPanel.TabIndex = 12;
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
            this.pnlImage.Size = new System.Drawing.Size(948, 72);
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
            this.lblMessage.Size = new System.Drawing.Size(940, 64);
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
            this.pctrQuestionImage.Size = new System.Drawing.Size(936, 60);
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
            this.Controls.Add(this.tblltQuestionPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuestionControl";
            this.Size = new System.Drawing.Size(958, 528);
            this.grpAnswers.ResumeLayout(false);
            this.pnlControlAnswer.ResumeLayout(false);
            this.tblltQuestionPanel.ResumeLayout(false);
            this.tblltQuestionPanel.PerformLayout();
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrQuestionImage)).EndInit();
            this.cmsImageContextPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtbxQuestionText;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.GroupBox grpAnswers;
        private System.Windows.Forms.Panel pnlControlAnswer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tblltQuestionPanel;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pctrQuestionImage;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private AnswersFlowLayoutPanel adjflwpAnswerList;
        private System.Windows.Forms.ContextMenuStrip cmsImageContextPanel;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
