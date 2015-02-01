namespace IMDBCloneApplication
{
    partial class AddMoviesToGenres
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
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imdbcloneDataSet = new IMDBCloneApplication.imdbcloneDataSet();
            this.labelSelectGenre = new System.Windows.Forms.Label();
            this.dataGridViewGenreSearch = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesDataGridView = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelSelectMoviesToAdd = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelSelectMoviesToRemove = new System.Windows.Forms.Label();
            this.dataGridViewMovieGenre = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviegenreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonRemove = new System.Windows.Forms.Button();
            this.genreTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.genreTableAdapter();
            this.movieTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.movieTableAdapter();
            this.moviegenreTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.moviegenreTableAdapter();
            this.movieSearchTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.movieSearchTableAdapter();
            this.genreSearchTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.genreSearchTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenreSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviegenreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "genre";
            this.genreBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // imdbcloneDataSet
            // 
            this.imdbcloneDataSet.DataSetName = "imdbcloneDataSet";
            this.imdbcloneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelSelectGenre
            // 
            this.labelSelectGenre.AutoSize = true;
            this.labelSelectGenre.Location = new System.Drawing.Point(9, 15);
            this.labelSelectGenre.Name = "labelSelectGenre";
            this.labelSelectGenre.Size = new System.Drawing.Size(79, 13);
            this.labelSelectGenre.TabIndex = 2;
            this.labelSelectGenre.Text = "Select a genre:";
            // 
            // dataGridViewGenreSearch
            // 
            this.dataGridViewGenreSearch.AllowUserToAddRows = false;
            this.dataGridViewGenreSearch.AllowUserToDeleteRows = false;
            this.dataGridViewGenreSearch.AllowUserToResizeRows = false;
            this.dataGridViewGenreSearch.AutoGenerateColumns = false;
            this.dataGridViewGenreSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGenreSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenreSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewGenreSearch.DataSource = this.genreSearchBindingSource;
            this.dataGridViewGenreSearch.Location = new System.Drawing.Point(12, 31);
            this.dataGridViewGenreSearch.MultiSelect = false;
            this.dataGridViewGenreSearch.Name = "dataGridViewGenreSearch";
            this.dataGridViewGenreSearch.ReadOnly = true;
            this.dataGridViewGenreSearch.RowHeadersVisible = false;
            this.dataGridViewGenreSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGenreSearch.Size = new System.Drawing.Size(154, 341);
            this.dataGridViewGenreSearch.TabIndex = 3;
            this.dataGridViewGenreSearch.SelectionChanged += new System.EventHandler(this.DataGridViewGenreSearch_SelectionChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreSearchBindingSource
            // 
            this.genreSearchBindingSource.DataMember = "genreSearch";
            this.genreSearchBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // moviesDataGridView
            // 
            this.moviesDataGridView.AllowUserToAddRows = false;
            this.moviesDataGridView.AllowUserToDeleteRows = false;
            this.moviesDataGridView.AllowUserToResizeRows = false;
            this.moviesDataGridView.AutoGenerateColumns = false;
            this.moviesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.moviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.moviesDataGridView.DataSource = this.movieBindingSource;
            this.moviesDataGridView.Location = new System.Drawing.Point(175, 31);
            this.moviesDataGridView.MultiSelect = false;
            this.moviesDataGridView.Name = "moviesDataGridView";
            this.moviesDataGridView.ReadOnly = true;
            this.moviesDataGridView.RowHeadersVisible = false;
            this.moviesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.moviesDataGridView.Size = new System.Drawing.Size(404, 143);
            this.moviesDataGridView.TabIndex = 4;
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
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "movie";
            this.movieBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // labelSelectMoviesToAdd
            // 
            this.labelSelectMoviesToAdd.AutoSize = true;
            this.labelSelectMoviesToAdd.Location = new System.Drawing.Point(172, 15);
            this.labelSelectMoviesToAdd.Name = "labelSelectMoviesToAdd";
            this.labelSelectMoviesToAdd.Size = new System.Drawing.Size(194, 13);
            this.labelSelectMoviesToAdd.TabIndex = 5;
            this.labelSelectMoviesToAdd.Text = "Select movies to add to selected genre:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(495, 180);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(84, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAddSlectedMovies_Click);
            // 
            // labelSelectMoviesToRemove
            // 
            this.labelSelectMoviesToRemove.AutoSize = true;
            this.labelSelectMoviesToRemove.Location = new System.Drawing.Point(172, 211);
            this.labelSelectMoviesToRemove.Name = "labelSelectMoviesToRemove";
            this.labelSelectMoviesToRemove.Size = new System.Drawing.Size(222, 13);
            this.labelSelectMoviesToRemove.TabIndex = 7;
            this.labelSelectMoviesToRemove.Text = "Select movies to remove from selected genre:";
            // 
            // dataGridViewMovieGenre
            // 
            this.dataGridViewMovieGenre.AllowUserToAddRows = false;
            this.dataGridViewMovieGenre.AllowUserToDeleteRows = false;
            this.dataGridViewMovieGenre.AllowUserToResizeRows = false;
            this.dataGridViewMovieGenre.AutoGenerateColumns = false;
            this.dataGridViewMovieGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMovieGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovieGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn1,
            this.yearDataGridViewTextBoxColumn1});
            this.dataGridViewMovieGenre.DataSource = this.movieSearchBindingSource;
            this.dataGridViewMovieGenre.Location = new System.Drawing.Point(175, 227);
            this.dataGridViewMovieGenre.MultiSelect = false;
            this.dataGridViewMovieGenre.Name = "dataGridViewMovieGenre";
            this.dataGridViewMovieGenre.ReadOnly = true;
            this.dataGridViewMovieGenre.RowHeadersVisible = false;
            this.dataGridViewMovieGenre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMovieGenre.Size = new System.Drawing.Size(404, 145);
            this.dataGridViewMovieGenre.TabIndex = 8;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn1
            // 
            this.yearDataGridViewTextBoxColumn1.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn1.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn1.Name = "yearDataGridViewTextBoxColumn1";
            this.yearDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // movieSearchBindingSource
            // 
            this.movieSearchBindingSource.DataMember = "movieSearch";
            this.movieSearchBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // moviegenreBindingSource
            // 
            this.moviegenreBindingSource.DataMember = "moviegenre";
            this.moviegenreBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(500, 378);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(79, 22);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.ButtonRemoveSelectedMovies_Click);
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // moviegenreTableAdapter
            // 
            this.moviegenreTableAdapter.ClearBeforeFill = true;
            // 
            // movieSearchTableAdapter
            // 
            this.movieSearchTableAdapter.ClearBeforeFill = true;
            // 
            // genreSearchTableAdapter
            // 
            this.genreSearchTableAdapter.ClearBeforeFill = true;
            // 
            // AddMoviesToGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 411);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.dataGridViewMovieGenre);
            this.Controls.Add(this.labelSelectMoviesToRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelSelectMoviesToAdd);
            this.Controls.Add(this.moviesDataGridView);
            this.Controls.Add(this.dataGridViewGenreSearch);
            this.Controls.Add(this.labelSelectGenre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddMoviesToGenres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/remove movies to/from genres";
            this.Load += new System.EventHandler(this.AddMoviesToGenres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenreSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovieGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviegenreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private imdbcloneDataSet imdbcloneDataSet;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private imdbcloneDataSetTableAdapters.genreTableAdapter genreTableAdapter;
        private System.Windows.Forms.Label labelSelectGenre;
        private System.Windows.Forms.DataGridView dataGridViewGenreSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView moviesDataGridView;
        private System.Windows.Forms.Label labelSelectMoviesToAdd;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private imdbcloneDataSetTableAdapters.movieTableAdapter movieTableAdapter;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelSelectMoviesToRemove;
        private System.Windows.Forms.DataGridView dataGridViewMovieGenre;
        private System.Windows.Forms.BindingSource moviegenreBindingSource;
        private imdbcloneDataSetTableAdapters.moviegenreTableAdapter moviegenreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource movieSearchBindingSource;
        private imdbcloneDataSetTableAdapters.movieSearchTableAdapter movieSearchTableAdapter;
        private System.Windows.Forms.BindingSource genreSearchBindingSource;
        private imdbcloneDataSetTableAdapters.genreSearchTableAdapter genreSearchTableAdapter;
    }
}