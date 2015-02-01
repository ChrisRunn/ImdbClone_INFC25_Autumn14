namespace IMDBCloneApplication
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
            this.imdbcloneDataSet1 = new IMDBCloneApplication.imdbcloneDataSet();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movieFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actorFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutIMDBCloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.auditBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imdbcloneDataSet11 = new IMDBCloneApplication.imdbcloneDataSet1();
            this.auditTableAdapter = new IMDBCloneApplication.imdbcloneDataSet1TableAdapters.AuditTableAdapter();
            this.dgvAudit2 = new System.Windows.Forms.DataGridView();
            this.auditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imdbcloneDataSet1
            // 
            this.imdbcloneDataSet1.DataSetName = "imdbcloneDataSet";
            this.imdbcloneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(729, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieFormToolStripMenuItem,
            this.directorFormToolStripMenuItem,
            this.actorFormToolStripMenuItem,
            this.genreToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // movieFormToolStripMenuItem
            // 
            this.movieFormToolStripMenuItem.Name = "movieFormToolStripMenuItem";
            this.movieFormToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.movieFormToolStripMenuItem.Text = "Movies";
            this.movieFormToolStripMenuItem.Click += new System.EventHandler(this.MovieFormToolStripMenuItem_Click);
            this.movieFormToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.movieFormToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // directorFormToolStripMenuItem
            // 
            this.directorFormToolStripMenuItem.Name = "directorFormToolStripMenuItem";
            this.directorFormToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.directorFormToolStripMenuItem.Text = "Directors";
            this.directorFormToolStripMenuItem.Click += new System.EventHandler(this.DirectorFormToolStripMenuItem_Click);
            this.directorFormToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.directorFormToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // actorFormToolStripMenuItem
            // 
            this.actorFormToolStripMenuItem.Name = "actorFormToolStripMenuItem";
            this.actorFormToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.actorFormToolStripMenuItem.Text = "Actors";
            this.actorFormToolStripMenuItem.Click += new System.EventHandler(this.ActorFormToolStripMenuItem_Click);
            this.actorFormToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.actorFormToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.genreToolStripMenuItem.Text = "Genre";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.GenreToolStripMenuItem_Click);
            this.genreToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.genreToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.exitToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutIMDBCloneToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutIMDBCloneToolStripMenuItem
            // 
            this.aboutIMDBCloneToolStripMenuItem.Name = "aboutIMDBCloneToolStripMenuItem";
            this.aboutIMDBCloneToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutIMDBCloneToolStripMenuItem.Text = "About IMDB Clone";
            this.aboutIMDBCloneToolStripMenuItem.Click += new System.EventHandler(this.AboutIMDBCloneToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(729, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(272, 17);
            this.toolStripStatusLabel.Text = "Welcome. Please select an action in the File menu.";
            // 
            // auditBindingSource1
            // 
            this.auditBindingSource1.DataMember = "Audit";
            this.auditBindingSource1.DataSource = this.imdbcloneDataSet11;
            // 
            // imdbcloneDataSet11
            // 
            this.imdbcloneDataSet11.DataSetName = "imdbcloneDataSet1";
            this.imdbcloneDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auditTableAdapter
            // 
            this.auditTableAdapter.ClearBeforeFill = true;
            // 
            // dgvAudit2
            // 
            this.dgvAudit2.AutoGenerateColumns = false;
            this.dgvAudit2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAudit2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tableNameDataGridViewTextBoxColumn,
            this.auditDataDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn});
            this.dgvAudit2.DataSource = this.auditBindingSource;
            this.dgvAudit2.Location = new System.Drawing.Point(22, 46);
            this.dgvAudit2.Name = "dgvAudit2";
            this.dgvAudit2.Size = new System.Drawing.Size(674, 288);
            this.dgvAudit2.TabIndex = 3;
            // 
            // auditBindingSource
            // 
            this.auditBindingSource.DataMember = "Audit";
            this.auditBindingSource.DataSource = this.imdbcloneDataSet11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableNameDataGridViewTextBoxColumn
            // 
            this.tableNameDataGridViewTextBoxColumn.DataPropertyName = "tableName";
            this.tableNameDataGridViewTextBoxColumn.HeaderText = "tableName";
            this.tableNameDataGridViewTextBoxColumn.Name = "tableNameDataGridViewTextBoxColumn";
            // 
            // auditDataDataGridViewTextBoxColumn
            // 
            this.auditDataDataGridViewTextBoxColumn.DataPropertyName = "auditData";
            this.auditDataDataGridViewTextBoxColumn.HeaderText = "auditData";
            this.auditDataDataGridViewTextBoxColumn.Name = "auditDataDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "userName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 381);
            this.Controls.Add(this.dgvAudit2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMDB Clone";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private imdbcloneDataSet imdbcloneDataSet1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem movieFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directorFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actorFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutIMDBCloneToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.BindingSource auditBindingSource;
        private imdbcloneDataSet1 imdbcloneDataSet11;
        private System.Windows.Forms.BindingSource auditBindingSource1;
        private imdbcloneDataSet1TableAdapters.AuditTableAdapter auditTableAdapter;
        private System.Windows.Forms.DataGridView dgvAudit2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
    }
}