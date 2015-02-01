namespace IMDBCloneApplication
{
    partial class ActorForm
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
            this.actorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imdbcloneDataSet = new IMDBCloneApplication.imdbcloneDataSet();
            this.searchByNameLabel = new System.Windows.Forms.Label();
            this.actorTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.actorTableAdapter();
            this.dataGridViewActors = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.movieTableAdapter();
            this.actedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actedTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.actedTableAdapter();
            this.dataGridViewActed = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorsLabel = new System.Windows.Forms.Label();
            this.moviesActorActedInLabel = new System.Windows.Forms.Label();
            this.imdbcloneDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieSearchTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.movieSearchTableAdapter();
            this.actorSearchTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.actorSearchTableAdapter();
            this.tableAdapterManager = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.TableAdapterManager();
            this.actorNameTextBox = new System.Windows.Forms.TextBox();
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.biographyTextBox = new System.Windows.Forms.TextBox();
            this.menuStripActors = new System.Windows.Forms.MenuStrip();
            this.actorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrRemoveActorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addremoveActorsTofromMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchActorComboBox = new System.Windows.Forms.ComboBox();
            nameLabel = new System.Windows.Forms.Label();
            birthdateLabel = new System.Windows.Forms.Label();
            biographyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSetBindingSource)).BeginInit();
            this.menuStripActors.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(32, 37);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Name:";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Location = new System.Drawing.Point(18, 66);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(52, 13);
            birthdateLabel.TabIndex = 14;
            birthdateLabel.Text = "Birthdate:";
            // 
            // biographyLabel
            // 
            biographyLabel.AutoSize = true;
            biographyLabel.Location = new System.Drawing.Point(13, 92);
            biographyLabel.Name = "biographyLabel";
            biographyLabel.Size = new System.Drawing.Size(57, 13);
            biographyLabel.TabIndex = 15;
            biographyLabel.Text = "Biography:";
            // 
            // actorBindingSource
            // 
            this.actorBindingSource.DataMember = "actor";
            this.actorBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // imdbcloneDataSet
            // 
            this.imdbcloneDataSet.DataSetName = "imdbcloneDataSet";
            this.imdbcloneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchByNameLabel
            // 
            this.searchByNameLabel.AutoSize = true;
            this.searchByNameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchByNameLabel.Location = new System.Drawing.Point(572, 6);
            this.searchByNameLabel.Name = "searchByNameLabel";
            this.searchByNameLabel.Size = new System.Drawing.Size(87, 13);
            this.searchByNameLabel.TabIndex = 6;
            this.searchByNameLabel.Text = "Search by name:";
            // 
            // actorTableAdapter
            // 
            this.actorTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewActors
            // 
            this.dataGridViewActors.AllowUserToAddRows = false;
            this.dataGridViewActors.AllowUserToDeleteRows = false;
            this.dataGridViewActors.AllowUserToResizeRows = false;
            this.dataGridViewActors.AutoGenerateColumns = false;
            this.dataGridViewActors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn});
            this.dataGridViewActors.DataSource = this.actorSearchBindingSource;
            this.dataGridViewActors.Location = new System.Drawing.Point(12, 281);
            this.dataGridViewActors.MultiSelect = false;
            this.dataGridViewActors.Name = "dataGridViewActors";
            this.dataGridViewActors.ReadOnly = true;
            this.dataGridViewActors.RowHeadersVisible = false;
            this.dataGridViewActors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActors.Size = new System.Drawing.Size(344, 163);
            this.dataGridViewActors.TabIndex = 10;
            this.dataGridViewActors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActors_CellContentClick);
            this.dataGridViewActors.SelectionChanged += new System.EventHandler(this.DataGridViewActors_SelectionChanged);
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
            // actorSearchBindingSource
            // 
            this.actorSearchBindingSource.DataMember = "actorSearch";
            this.actorSearchBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "movie";
            this.movieBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
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
            // dataGridViewActed
            // 
            this.dataGridViewActed.AllowUserToAddRows = false;
            this.dataGridViewActed.AllowUserToDeleteRows = false;
            this.dataGridViewActed.AllowUserToResizeRows = false;
            this.dataGridViewActed.AutoGenerateColumns = false;
            this.dataGridViewActed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn});
            this.dataGridViewActed.DataSource = this.movieSearchBindingSource;
            this.dataGridViewActed.Enabled = false;
            this.dataGridViewActed.Location = new System.Drawing.Point(362, 281);
            this.dataGridViewActed.MultiSelect = false;
            this.dataGridViewActed.Name = "dataGridViewActed";
            this.dataGridViewActed.ReadOnly = true;
            this.dataGridViewActed.RowHeadersVisible = false;
            this.dataGridViewActed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActed.Size = new System.Drawing.Size(460, 163);
            this.dataGridViewActed.TabIndex = 11;
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
            // actorsLabel
            // 
            this.actorsLabel.AutoSize = true;
            this.actorsLabel.Location = new System.Drawing.Point(12, 265);
            this.actorsLabel.Name = "actorsLabel";
            this.actorsLabel.Size = new System.Drawing.Size(40, 13);
            this.actorsLabel.TabIndex = 12;
            this.actorsLabel.Text = "Actors:";
            // 
            // moviesActorActedInLabel
            // 
            this.moviesActorActedInLabel.AutoSize = true;
            this.moviesActorActedInLabel.Location = new System.Drawing.Point(359, 265);
            this.moviesActorActedInLabel.Name = "moviesActorActedInLabel";
            this.moviesActorActedInLabel.Size = new System.Drawing.Size(215, 13);
            this.moviesActorActedInLabel.TabIndex = 13;
            this.moviesActorActedInLabel.Text = "Movies in which the selected actor acted in:";
            // 
            // imdbcloneDataSetBindingSource
            // 
            this.imdbcloneDataSetBindingSource.DataSource = this.imdbcloneDataSet;
            this.imdbcloneDataSetBindingSource.Position = 0;
            // 
            // movieSearchTableAdapter
            // 
            this.movieSearchTableAdapter.ClearBeforeFill = true;
            // 
            // actorSearchTableAdapter
            // 
            this.actorSearchTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.actedTableAdapter = this.actedTableAdapter;
            this.tableAdapterManager.actorSearchTableAdapter = this.actorSearchTableAdapter;
            this.tableAdapterManager.actorTableAdapter = this.actorTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.directedTableAdapter = null;
            this.tableAdapterManager.directorSearchTableAdapter = null;
            this.tableAdapterManager.directorTableAdapter = null;
            this.tableAdapterManager.genreSearchTableAdapter = null;
            this.tableAdapterManager.genreTableAdapter = null;
            this.tableAdapterManager.moviegenreTableAdapter = null;
            this.tableAdapterManager.movieSearchTableAdapter = this.movieSearchTableAdapter;
            this.tableAdapterManager.movieTableAdapter = this.movieTableAdapter;
            this.tableAdapterManager.UpdateOrder = IMDBCloneApplication.imdbcloneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // actorNameTextBox
            // 
            this.actorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actorSearchBindingSource, "name", true));
            this.actorNameTextBox.Location = new System.Drawing.Point(76, 34);
            this.actorNameTextBox.Name = "actorNameTextBox";
            this.actorNameTextBox.ReadOnly = true;
            this.actorNameTextBox.Size = new System.Drawing.Size(154, 20);
            this.actorNameTextBox.TabIndex = 14;
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.actorSearchBindingSource, "birthdate", true));
            this.birthdateDateTimePicker.Enabled = false;
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(76, 60);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(154, 20);
            this.birthdateDateTimePicker.TabIndex = 15;
            // 
            // biographyTextBox
            // 
            this.biographyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actorSearchBindingSource, "biography", true));
            this.biographyTextBox.Location = new System.Drawing.Point(76, 89);
            this.biographyTextBox.Multiline = true;
            this.biographyTextBox.Name = "biographyTextBox";
            this.biographyTextBox.ReadOnly = true;
            this.biographyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.biographyTextBox.Size = new System.Drawing.Size(746, 162);
            this.biographyTextBox.TabIndex = 16;
            // 
            // menuStripActors
            // 
            this.menuStripActors.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStripActors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actorsToolStripMenuItem});
            this.menuStripActors.Location = new System.Drawing.Point(0, 0);
            this.menuStripActors.Name = "menuStripActors";
            this.menuStripActors.Size = new System.Drawing.Size(830, 24);
            this.menuStripActors.TabIndex = 17;
            this.menuStripActors.Text = "menuStripActors";
            // 
            // actorsToolStripMenuItem
            // 
            this.actorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrRemoveActorsToolStripMenuItem,
            this.addremoveActorsTofromMoviesToolStripMenuItem});
            this.actorsToolStripMenuItem.Name = "actorsToolStripMenuItem";
            this.actorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.actorsToolStripMenuItem.Text = "Actors";
            // 
            // addOrRemoveActorsToolStripMenuItem
            // 
            this.addOrRemoveActorsToolStripMenuItem.Name = "addOrRemoveActorsToolStripMenuItem";
            this.addOrRemoveActorsToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.addOrRemoveActorsToolStripMenuItem.Text = "Add or remove actors";
            this.addOrRemoveActorsToolStripMenuItem.Click += new System.EventHandler(this.AddOrRemoveActorsToolStripMenuItem_Click);
            // 
            // addremoveActorsTofromMoviesToolStripMenuItem
            // 
            this.addremoveActorsTofromMoviesToolStripMenuItem.Name = "addremoveActorsTofromMoviesToolStripMenuItem";
            this.addremoveActorsTofromMoviesToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.addremoveActorsTofromMoviesToolStripMenuItem.Text = "Add/remove actors to/from movies";
            this.addremoveActorsTofromMoviesToolStripMenuItem.Click += new System.EventHandler(this.AddremoveActorsTofromMoviesToolStripMenuItem_Click);
            // 
            // searchActorComboBox
            // 
            this.searchActorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchActorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchActorComboBox.DataSource = this.actorBindingSource;
            this.searchActorComboBox.DisplayMember = "name";
            this.searchActorComboBox.FormattingEnabled = true;
            this.searchActorComboBox.Location = new System.Drawing.Point(665, 3);
            this.searchActorComboBox.Name = "searchActorComboBox";
            this.searchActorComboBox.Size = new System.Drawing.Size(157, 21);
            this.searchActorComboBox.TabIndex = 7;
            this.searchActorComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchActorComboBox_SelectedIndexChanged);
            this.searchActorComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchActorComboBox_KeyDown);
            // 
            // ActorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 456);
            this.Controls.Add(biographyLabel);
            this.Controls.Add(this.biographyTextBox);
            this.Controls.Add(birthdateLabel);
            this.Controls.Add(this.birthdateDateTimePicker);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.actorNameTextBox);
            this.Controls.Add(this.moviesActorActedInLabel);
            this.Controls.Add(this.actorsLabel);
            this.Controls.Add(this.dataGridViewActed);
            this.Controls.Add(this.dataGridViewActors);
            this.Controls.Add(this.searchActorComboBox);
            this.Controls.Add(this.searchByNameLabel);
            this.Controls.Add(this.menuStripActors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ActorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actors";
            this.Load += new System.EventHandler(this.ActorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSetBindingSource)).EndInit();
            this.menuStripActors.ResumeLayout(false);
            this.menuStripActors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchByNameLabel;
        private imdbcloneDataSet imdbcloneDataSet;
        private System.Windows.Forms.BindingSource actorBindingSource;
        private imdbcloneDataSetTableAdapters.actorTableAdapter actorTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewActors;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private imdbcloneDataSetTableAdapters.movieTableAdapter movieTableAdapter;
        private System.Windows.Forms.BindingSource actedBindingSource;
        private imdbcloneDataSetTableAdapters.actedTableAdapter actedTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewActed;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label actorsLabel;
        private System.Windows.Forms.Label moviesActorActedInLabel;
        private System.Windows.Forms.BindingSource imdbcloneDataSetBindingSource;
        private System.Windows.Forms.BindingSource movieSearchBindingSource;
        private imdbcloneDataSetTableAdapters.movieSearchTableAdapter movieSearchTableAdapter;
        private System.Windows.Forms.BindingSource actorSearchBindingSource;
        private imdbcloneDataSetTableAdapters.actorSearchTableAdapter actorSearchTableAdapter;
        private imdbcloneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox actorNameTextBox;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.TextBox biographyTextBox;
        private System.Windows.Forms.MenuStrip menuStripActors;
        private System.Windows.Forms.ToolStripMenuItem actorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrRemoveActorsToolStripMenuItem;
        private System.Windows.Forms.ComboBox searchActorComboBox;
        private System.Windows.Forms.ToolStripMenuItem addremoveActorsTofromMoviesToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
    }
}