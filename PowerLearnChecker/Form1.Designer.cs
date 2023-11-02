namespace PowerLearnChecker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.tslId = new System.Windows.Forms.ToolStripLabel();
            this.tstbId = new System.Windows.Forms.ToolStripTextBox();
            this.tsbDownload = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteSelectedUser = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteTest = new System.Windows.Forms.ToolStripButton();
            this.dgvTestsView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new PowerLearnChecker.Controls.DateTimeColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslId,
            this.tstbId,
            this.tsbDownload,
            this.btnDeleteSelectedUser,
            this.btnDeleteTest});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(624, 27);
            this.toolBar.TabIndex = 0;
            this.toolBar.Text = "toolStrip1";
            // 
            // tslId
            // 
            this.tslId.Name = "tslId";
            this.tslId.Size = new System.Drawing.Size(17, 24);
            this.tslId.Text = "Id";
            // 
            // tstbId
            // 
            this.tstbId.Name = "tstbId";
            this.tstbId.Size = new System.Drawing.Size(76, 27);
            this.tstbId.TextChanged += new System.EventHandler(this.tstbId_TextChanged);
            // 
            // tsbDownload
            // 
            this.tsbDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDownload.Enabled = false;
            this.tsbDownload.Image = global::PowerLearnChecker.Properties.Resources.Search;
            this.tsbDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDownload.Name = "tsbDownload";
            this.tsbDownload.Size = new System.Drawing.Size(24, 24);
            this.tsbDownload.Text = "Search...";
            this.tsbDownload.Click += new System.EventHandler(this.tsbDownload_Click);
            // 
            // btnDeleteSelectedUser
            // 
            this.btnDeleteSelectedUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteSelectedUser.Enabled = false;
            this.btnDeleteSelectedUser.Image = global::PowerLearnChecker.Properties.Resources.Delete_Current;
            this.btnDeleteSelectedUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteSelectedUser.Name = "btnDeleteSelectedUser";
            this.btnDeleteSelectedUser.Size = new System.Drawing.Size(24, 24);
            this.btnDeleteSelectedUser.Text = "Delete Selected User";
            this.btnDeleteSelectedUser.Click += new System.EventHandler(this.btnDeleteSelectedUser_Click);
            // 
            // btnDeleteTest
            // 
            this.btnDeleteTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteTest.Enabled = false;
            this.btnDeleteTest.Image = global::PowerLearnChecker.Properties.Resources.Delete_Test;
            this.btnDeleteTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteTest.Name = "btnDeleteTest";
            this.btnDeleteTest.Size = new System.Drawing.Size(24, 24);
            this.btnDeleteTest.Text = "Delete Test";
            this.btnDeleteTest.Click += new System.EventHandler(this.btnDeleteTest_ClickAsync);
            // 
            // dgvTestsView
            // 
            this.dgvTestsView.AllowUserToAddRows = false;
            this.dgvTestsView.AllowUserToDeleteRows = false;
            this.dgvTestsView.AutoGenerateColumns = false;
            this.dgvTestsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestsView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTestsView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTestsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvTestsView.DataSource = this.bindingSource;
            this.dgvTestsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTestsView.Location = new System.Drawing.Point(0, 27);
            this.dgvTestsView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTestsView.MultiSelect = false;
            this.dgvTestsView.Name = "dgvTestsView";
            this.dgvTestsView.ReadOnly = true;
            this.dgvTestsView.RowHeadersWidth = 51;
            this.dgvTestsView.RowTemplate.Height = 24;
            this.dgvTestsView.Size = new System.Drawing.Size(624, 347);
            this.dgvTestsView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            this.maxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "Test";
            this.bindingSource.DataSource = typeof(PowerLearnChecker.Tests);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 374);
            this.Controls.Add(this.dgvTestsView);
            this.Controls.Add(this.toolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Power Learn Checker";
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripLabel tslId;
        private System.Windows.Forms.ToolStripTextBox tstbId;
        private System.Windows.Forms.DataGridView dgvTestsView;
        private System.Windows.Forms.ToolStripButton tsbDownload;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private Controls.DateTimeColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnDeleteSelectedUser;
        private System.Windows.Forms.ToolStripButton btnDeleteTest;
    }
}

