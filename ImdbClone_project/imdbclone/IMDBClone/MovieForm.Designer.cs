namespace IMDBCloneApplication
{
    partial class MovieForm
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label rankLabel;
            this.actorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imdbcloneDataSet = new IMDBCloneApplication.imdbcloneDataSet();
            this.actorTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.actorTableAdapter();
            this.movieTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.movieTableAdapter();
            this.tableAdapterManager = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSearchByTitle = new System.Windows.Forms.ComboBox();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewActors = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieSearchTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.movieSearchTableAdapter();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.rankTextBox = new System.Windows.Forms.TextBox();
            this.actorSearchTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.actorSearchTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adddeleteMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewGenre = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreSearchTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.genreSearchTableAdapter();
            titleLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            rankLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorSearchBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreSearchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(358, 48);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 19;
            titleLabel.Text = "Title:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(354, 74);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 20;
            yearLabel.Text = "Year:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(323, 100);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 21;
            descriptionLabel.Text = "Description:";
            // 
            // rankLabel
            // 
            rankLabel.AutoSize = true;
            rankLabel.Location = new System.Drawing.Point(353, 234);
            rankLabel.Name = "rankLabel";
            rankLabel.Size = new System.Drawing.Size(36, 13);
            rankLabel.TabIndex = 22;
            rankLabel.Text = "Rank:";
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
            // actorTableAdapter
            // 
            this.actorTableAdapter.ClearBeforeFill = true;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.actedTableAdapter = null;
            this.tableAdapterManager.actorSearchTableAdapter = null;
            this.tableAdapterManager.actorTableAdapter = this.actorTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.directedTableAdapter = null;
            this.tableAdapterManager.directorSearchTableAdapter = null;
            this.tableAdapterManager.directorTableAdapter = null;
            this.tableAdapterManager.genreSearchTableAdapter = null;
            this.tableAdapterManager.genreTableAdapter = null;
            this.tableAdapterManager.moviegenreTableAdapter = null;
            this.tableAdapterManager.movieSearchTableAdapter = null;
            this.tableAdapterManager.movieTableAdapter = this.movieTableAdapter;
            this.tableAdapterManager.UpdateOrder = IMDBCloneApplication.imdbcloneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.AllowUserToAddRows = false;
            this.dataGridViewMovies.AllowUserToDeleteRows = false;
            this.dataGridViewMovies.AllowUserToResizeRows = false;
            this.dataGridViewMovies.AutoGenerateColumns = false;
            this.dataGridViewMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn});
            this.dataGridViewMovies.DataSource = this.movieSearchBindingSource;
            this.dataGridViewMovies.Location = new System.Drawing.Point(12, 288);
            this.dataGridViewMovies.MultiSelect = false;
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.ReadOnly = true;
            this.dataGridViewMovies.RowHeadersVisible = false;
            this.dataGridViewMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMovies.Size = new System.Drawing.Size(476, 282);
            this.dataGridViewMovies.TabIndex = 13;
            this.dataGridViewMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovies_CellContentClick);
            this.dataGridViewMovies.SelectionChanged += new System.EventHandler(this.DataGridViewMovies_SelectionChanged);
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
            // comboBoxSearchByTitle
            // 
            this.comboBoxSearchByTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSearchByTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSearchByTitle.DataSource = this.movieBindingSource;
            this.comboBoxSearchByTitle.DisplayMember = "title";
            this.comboBoxSearchByTitle.FormattingEnabled = true;
            this.comboBoxSearchByTitle.Location = new System.Drawing.Point(655, 3);
            this.comboBoxSearchByTitle.Name = "comboBoxSearchByTitle";
            this.comboBoxSearchByTitle.Size = new System.Drawing.Size(242, 21);
            this.comboBoxSearchByTitle.TabIndex = 14;
            this.comboBoxSearchByTitle.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSearchByTitle_SelectedIndexChanged);
            this.comboBoxSearchByTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxSearchByTitle_KeyDown);
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "movie";
            this.movieBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(572, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search by title:";
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
            this.dataGridViewActors.Enabled = false;
            this.dataGridViewActors.Location = new System.Drawing.Point(494, 288);
            this.dataGridViewActors.MultiSelect = false;
            this.dataGridViewActors.Name = "dataGridViewActors";
            this.dataGridViewActors.ReadOnly = true;
            this.dataGridViewActors.RowHeadersVisible = false;
            this.dataGridViewActors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActors.Size = new System.Drawing.Size(266, 282);
            this.dataGridViewActors.TabIndex = 19;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actorSearchBindingSource
            // 
            this.actorSearchBindingSource.DataMember = "actorSearch";
            this.actorSearchBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // movieSearchTableAdapter
            // 
            this.movieSearchTableAdapter.ClearBeforeFill = true;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieSearchBindingSource, "title", true));
            this.titleTextBox.Location = new System.Drawing.Point(390, 45);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(507, 20);
            this.titleTextBox.TabIndex = 20;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieSearchBindingSource, "year", true));
            this.yearTextBox.Location = new System.Drawing.Point(390, 71);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.ReadOnly = true;
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 21;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieSearchBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(390, 97);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(507, 128);
            this.descriptionTextBox.TabIndex = 22;
            // 
            // rankTextBox
            // 
            this.rankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieSearchBindingSource, "rank", true));
            this.rankTextBox.Location = new System.Drawing.Point(390, 231);
            this.rankTextBox.Name = "rankTextBox";
            this.rankTextBox.ReadOnly = true;
            this.rankTextBox.Size = new System.Drawing.Size(100, 20);
            this.rankTextBox.TabIndex = 23;
            // 
            // actorSearchTableAdapter
            // 
            this.actorSearchTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Actors which acted in selected movie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Movies:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adddeleteMoviesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.fileToolStripMenuItem.Text = "Movies";
            // 
            // adddeleteMoviesToolStripMenuItem
            // 
            this.adddeleteMoviesToolStripMenuItem.Name = "adddeleteMoviesToolStripMenuItem";
            this.adddeleteMoviesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.adddeleteMoviesToolStripMenuItem.Text = "Add or delete movies";
            this.adddeleteMoviesToolStripMenuItem.Click += new System.EventHandler(this.AdddeleteMoviesToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(763, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Genre:";
            // 
            // dataGridViewGenre
            // 
            this.dataGridViewGenre.AllowUserToAddRows = false;
            this.dataGridViewGenre.AllowUserToDeleteRows = false;
            this.dataGridViewGenre.AllowUserToResizeRows = false;
            this.dataGridViewGenre.AutoGenerateColumns = false;
            this.dataGridViewGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridViewGenre.DataSource = this.genreSearchBindingSource;
            this.dataGridViewGenre.Enabled = false;
            this.dataGridViewGenre.Location = new System.Drawing.Point(766, 288);
            this.dataGridViewGenre.Name = "dataGridViewGenre";
            this.dataGridViewGenre.ReadOnly = true;
            this.dataGridViewGenre.RowHeadersVisible = false;
            this.dataGridViewGenre.Size = new System.Drawing.Size(131, 282);
            this.dataGridViewGenre.TabIndex = 28;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Genre";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // genreSearchBindingSource
            // 
            this.genreSearchBindingSource.DataMember = "genreSearch";
            this.genreSearchBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // genreSearchTableAdapter
            // 
            this.genreSearchTableAdapter.ClearBeforeFill = true;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 582);
            this.Controls.Add(this.dataGridViewGenre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(rankLabel);
            this.Controls.Add(this.rankTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.dataGridViewActors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSearchByTitle);
            this.Controls.Add(this.dataGridViewMovies);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorSearchBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreSearchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private imdbcloneDataSet imdbcloneDataSet;
        private System.Windows.Forms.BindingSource actorBindingSource;
        private imdbcloneDataSetTableAdapters.actorTableAdapter actorTableAdapter;
        private imdbcloneDataSetTableAdapters.movieTableAdapter movieTableAdapter;
        private imdbcloneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.ComboBox comboBoxSearchByTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewActors;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource movieSearchBindingSource;
        private imdbcloneDataSetTableAdapters.movieSearchTableAdapter movieSearchTableAdapter;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox rankTextBox;
        private System.Windows.Forms.BindingSource actorSearchBindingSource;
        private imdbcloneDataSetTableAdapters.actorSearchTableAdapter actorSearchTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adddeleteMoviesToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewGenre;
        private System.Windows.Forms.BindingSource genreSearchBindingSource;
        private imdbcloneDataSetTableAdapters.genreSearchTableAdapter genreSearchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
    }
}

