namespace IMDBCloneApplication
{
    partial class DirectorForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label birthdateLabel;
            System.Windows.Forms.Label biographyLabel;
            this.imdbcloneDataSet = new IMDBCloneApplication.imdbcloneDataSet();
            this.directorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.directorTableAdapter();
            this.tableAdapterManager = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.TableAdapterManager();
            this.directedTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.directedTableAdapter();
            this.movieTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.movieTableAdapter();
            this.directedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchDirectorComboBox = new System.Windows.Forms.ComboBox();
            this.directorSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biographyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectorLabel = new System.Windows.Forms.Label();
            this.MovieLabel = new System.Windows.Forms.Label();
            this.movieGridView = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchByNameLabel = new System.Windows.Forms.Label();
            this.movieSearchTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.movieSearchTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.directorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrRemoveDirectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addremoveDirectorsTofromMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actedTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.actedTableAdapter();
            this.directorSearchTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.directorSearchTableAdapter();
            this.directorNameTextBox = new System.Windows.Forms.TextBox();
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.biographyTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            birthdateLabel = new System.Windows.Forms.Label();
            biographyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(28, 41);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 25;
            nameLabel.Text = "Name:";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Location = new System.Drawing.Point(13, 83);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(52, 13);
            birthdateLabel.TabIndex = 26;
            birthdateLabel.Text = "Birthdate:";
            // 
            // biographyLabel
            // 
            biographyLabel.AutoSize = true;
            biographyLabel.Location = new System.Drawing.Point(8, 121);
            biographyLabel.Name = "biographyLabel";
            biographyLabel.Size = new System.Drawing.Size(57, 13);
            biographyLabel.TabIndex = 27;
            biographyLabel.Text = "Biography:";
            // 
            // imdbcloneDataSet
            // 
            this.imdbcloneDataSet.DataSetName = "imdbcloneDataSet";
            this.imdbcloneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // directorBindingSource
            // 
            this.directorBindingSource.DataMember = "director";
            this.directorBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // directorTableAdapter
            // 
            this.directorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.actedTableAdapter = null;
            this.tableAdapterManager.actorSearchTableAdapter = null;
            this.tableAdapterManager.actorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.directedTableAdapter = this.directedTableAdapter;
            this.tableAdapterManager.directorSearchTableAdapter = null;
            this.tableAdapterManager.directorTableAdapter = this.directorTableAdapter;
            this.tableAdapterManager.genreSearchTableAdapter = null;
            this.tableAdapterManager.genreTableAdapter = null;
            this.tableAdapterManager.moviegenreTableAdapter = null;
            this.tableAdapterManager.movieSearchTableAdapter = null;
            this.tableAdapterManager.movieTableAdapter = this.movieTableAdapter;
            this.tableAdapterManager.UpdateOrder = IMDBCloneApplication.imdbcloneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // directedTableAdapter
            // 
            this.directedTableAdapter.ClearBeforeFill = true;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // directedBindingSource
            // 
            this.directedBindingSource.DataMember = "directed";
            this.directedBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "movie";
            this.movieBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // searchDirectorComboBox
            // 
            this.searchDirectorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchDirectorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchDirectorComboBox.DataSource = this.directorBindingSource;
            this.searchDirectorComboBox.DisplayMember = "name";
            this.searchDirectorComboBox.FormattingEnabled = true;
            this.searchDirectorComboBox.Location = new System.Drawing.Point(679, 3);
            this.searchDirectorComboBox.Name = "searchDirectorComboBox";
            this.searchDirectorComboBox.Size = new System.Drawing.Size(143, 21);
            this.searchDirectorComboBox.TabIndex = 15;
            this.searchDirectorComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchDirectorComboBox_SelectedIndexChanged);
            this.searchDirectorComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchDirectorComboBox_KeyDown);
            // 
            // directorSearchBindingSource
            // 
            this.directorSearchBindingSource.DataMember = "directorSearch";
            this.directorSearchBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // directorGridView
            // 
            this.directorGridView.AllowUserToAddRows = false;
            this.directorGridView.AllowUserToDeleteRows = false;
            this.directorGridView.AllowUserToResizeRows = false;
            this.directorGridView.AutoGenerateColumns = false;
            this.directorGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.directorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.biographyDataGridViewTextBoxColumn});
            this.directorGridView.DataSource = this.directorSearchBindingSource;
            this.directorGridView.Location = new System.Drawing.Point(11, 286);
            this.directorGridView.MultiSelect = false;
            this.directorGridView.Name = "directorGridView";
            this.directorGridView.ReadOnly = true;
            this.directorGridView.RowHeadersVisible = false;
            this.directorGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.directorGridView.Size = new System.Drawing.Size(370, 158);
            this.directorGridView.TabIndex = 16;
            this.directorGridView.SelectionChanged += new System.EventHandler(this.DirectorGridView_SelectionChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // biographyDataGridViewTextBoxColumn
            // 
            this.biographyDataGridViewTextBoxColumn.DataPropertyName = "biography";
            this.biographyDataGridViewTextBoxColumn.HeaderText = "biography";
            this.biographyDataGridViewTextBoxColumn.Name = "biographyDataGridViewTextBoxColumn";
            this.biographyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DirectorLabel
            // 
            this.DirectorLabel.AutoSize = true;
            this.DirectorLabel.Location = new System.Drawing.Point(8, 270);
            this.DirectorLabel.Name = "DirectorLabel";
            this.DirectorLabel.Size = new System.Drawing.Size(47, 13);
            this.DirectorLabel.TabIndex = 18;
            this.DirectorLabel.Text = "Director:";
            // 
            // MovieLabel
            // 
            this.MovieLabel.AutoSize = true;
            this.MovieLabel.Location = new System.Drawing.Point(384, 270);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(265, 13);
            this.MovieLabel.TabIndex = 19;
            this.MovieLabel.Text = "Movies which have been directed by selected director:";
            // 
            // movieGridView
            // 
            this.movieGridView.AllowUserToAddRows = false;
            this.movieGridView.AllowUserToDeleteRows = false;
            this.movieGridView.AllowUserToResizeRows = false;
            this.movieGridView.AutoGenerateColumns = false;
            this.movieGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.movieGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn});
            this.movieGridView.DataSource = this.movieSearchBindingSource;
            this.movieGridView.Location = new System.Drawing.Point(387, 286);
            this.movieGridView.MultiSelect = false;
            this.movieGridView.Name = "movieGridView";
            this.movieGridView.ReadOnly = true;
            this.movieGridView.RowHeadersVisible = false;
            this.movieGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movieGridView.Size = new System.Drawing.Size(435, 158);
            this.movieGridView.TabIndex = 22;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "rank";
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            this.rankDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movieSearchBindingSource
            // 
            this.movieSearchBindingSource.DataMember = "movieSearch";
            this.movieSearchBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // searchByNameLabel
            // 
            this.searchByNameLabel.AutoSize = true;
            this.searchByNameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchByNameLabel.Location = new System.Drawing.Point(586, 6);
            this.searchByNameLabel.Name = "searchByNameLabel";
            this.searchByNameLabel.Size = new System.Drawing.Size(87, 13);
            this.searchByNameLabel.TabIndex = 24;
            this.searchByNameLabel.Text = "Search by name:";
            // 
            // movieSearchTableAdapter
            // 
            this.movieSearchTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // directorsToolStripMenuItem
            // 
            this.directorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrRemoveDirectorsToolStripMenuItem,
            this.addremoveDirectorsTofromMoviesToolStripMenuItem});
            this.directorsToolStripMenuItem.Name = "directorsToolStripMenuItem";
            this.directorsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.directorsToolStripMenuItem.Text = "Directors";
            // 
            // addOrRemoveDirectorsToolStripMenuItem
            // 
            this.addOrRemoveDirectorsToolStripMenuItem.Name = "addOrRemoveDirectorsToolStripMenuItem";
            this.addOrRemoveDirectorsToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.addOrRemoveDirectorsToolStripMenuItem.Text = "Add or remove directors";
            this.addOrRemoveDirectorsToolStripMenuItem.Click += new System.EventHandler(this.AddOrRemoveDirectorsToolStripMenuItem_Click);
            // 
            // addremoveDirectorsTofromMoviesToolStripMenuItem
            // 
            this.addremoveDirectorsTofromMoviesToolStripMenuItem.Name = "addremoveDirectorsTofromMoviesToolStripMenuItem";
            this.addremoveDirectorsTofromMoviesToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.addremoveDirectorsTofromMoviesToolStripMenuItem.Text = "Add/remove directors to/from movies";
            this.addremoveDirectorsTofromMoviesToolStripMenuItem.Click += new System.EventHandler(this.AddremoveDirectorsTofromMoviesToolStripMenuItem_Click);
            // 
            // actedBindingSource
            // 
            this.actedBindingSource.DataMember = "acted";
            this.actedBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // actedTableAdapter
            // 
            this.actedTableAdapter.ClearBeforeFill = true;
            // 
            // directorSearchTableAdapter
            // 
            this.directorSearchTableAdapter.ClearBeforeFill = true;
            // 
            // directorNameTextBox
            // 
            this.directorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.directorSearchBindingSource, "name", true));
            this.directorNameTextBox.Location = new System.Drawing.Point(70, 38);
            this.directorNameTextBox.Name = "directorNameTextBox";
            this.directorNameTextBox.ReadOnly = true;
            this.directorNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.directorNameTextBox.TabIndex = 26;
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.directorSearchBindingSource, "birthdate", true));
            this.birthdateDateTimePicker.Enabled = false;
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(70, 79);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdateDateTimePicker.TabIndex = 27;
            // 
            // biographyTextBox
            // 
            this.biographyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.directorSearchBindingSource, "biography", true));
            this.biographyTextBox.Location = new System.Drawing.Point(70, 118);
            this.biographyTextBox.Multiline = true;
            this.biographyTextBox.Name = "biographyTextBox";
            this.biographyTextBox.ReadOnly = true;
            this.biographyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.biographyTextBox.Size = new System.Drawing.Size(752, 142);
            this.biographyTextBox.TabIndex = 28;
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 456);
            this.Controls.Add(biographyLabel);
            this.Controls.Add(this.biographyTextBox);
            this.Controls.Add(birthdateLabel);
            this.Controls.Add(this.birthdateDateTimePicker);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.directorNameTextBox);
            this.Controls.Add(this.searchByNameLabel);
            this.Controls.Add(this.movieGridView);
            this.Controls.Add(this.MovieLabel);
            this.Controls.Add(this.DirectorLabel);
            this.Controls.Add(this.directorGridView);
            this.Controls.Add(this.searchDirectorComboBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "DirectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directors";
            this.Load += new System.EventHandler(this.DirectorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private imdbcloneDataSet imdbcloneDataSet;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private imdbcloneDataSetTableAdapters.directorTableAdapter directorTableAdapter;
        private imdbcloneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private imdbcloneDataSetTableAdapters.directedTableAdapter directedTableAdapter;
        private System.Windows.Forms.BindingSource directedBindingSource;
        private imdbcloneDataSetTableAdapters.movieTableAdapter movieTableAdapter;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.ComboBox searchDirectorComboBox;
        private System.Windows.Forms.DataGridView directorGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biographyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label DirectorLabel;
        private System.Windows.Forms.Label MovieLabel;
        private System.Windows.Forms.DataGridView movieGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label searchByNameLabel;
        private System.Windows.Forms.BindingSource movieSearchBindingSource;
        private imdbcloneDataSetTableAdapters.movieSearchTableAdapter movieSearchTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem directorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrRemoveDirectorsToolStripMenuItem;
        private System.Windows.Forms.BindingSource actedBindingSource;
        private imdbcloneDataSetTableAdapters.actedTableAdapter actedTableAdapter;
        private System.Windows.Forms.BindingSource directorSearchBindingSource;
        private imdbcloneDataSetTableAdapters.directorSearchTableAdapter directorSearchTableAdapter;
        private System.Windows.Forms.TextBox directorNameTextBox;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.TextBox biographyTextBox;
        private System.Windows.Forms.ToolStripMenuItem addremoveDirectorsTofromMoviesToolStripMenuItem;

    }
}