namespace IMDBCloneApplication
{
    partial class Genre
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
            System.Windows.Forms.Label label1;
            this.dataGridViewGenres = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imdbcloneDataSet = new IMDBCloneApplication.imdbcloneDataSet();
            this.dataGridViewMoviesByGenre = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imdbcloneDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.genreTableAdapter();
            this.tableAdapterManager = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.TableAdapterManager();
            this.movieTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.movieTableAdapter();
            this.movieSearchTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.movieSearchTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveOrEditGenresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addremoveMoviesTofromGenresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoviesByGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(9, 49);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(39, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Genre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(211, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 13);
            label1.TabIndex = 5;
            label1.Text = "Movies by selected genre:";
            // 
            // dataGridViewGenres
            // 
            this.dataGridViewGenres.AllowUserToAddRows = false;
            this.dataGridViewGenres.AllowUserToDeleteRows = false;
            this.dataGridViewGenres.AllowUserToResizeColumns = false;
            this.dataGridViewGenres.AllowUserToResizeRows = false;
            this.dataGridViewGenres.AutoGenerateColumns = false;
            this.dataGridViewGenres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewGenres.DataSource = this.genreBindingSource;
            this.dataGridViewGenres.Location = new System.Drawing.Point(12, 65);
            this.dataGridViewGenres.MultiSelect = false;
            this.dataGridViewGenres.Name = "dataGridViewGenres";
            this.dataGridViewGenres.ReadOnly = true;
            this.dataGridViewGenres.RowHeadersVisible = false;
            this.dataGridViewGenres.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewGenres.Size = new System.Drawing.Size(196, 308);
            this.dataGridViewGenres.TabIndex = 0;
            this.dataGridViewGenres.SelectionChanged += new System.EventHandler(this.DataGridViewGenres_SelectionChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dataGridViewMoviesByGenre
            // 
            this.dataGridViewMoviesByGenre.AllowUserToAddRows = false;
            this.dataGridViewMoviesByGenre.AllowUserToDeleteRows = false;
            this.dataGridViewMoviesByGenre.AutoGenerateColumns = false;
            this.dataGridViewMoviesByGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMoviesByGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMoviesByGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn});
            this.dataGridViewMoviesByGenre.DataSource = this.movieSearchBindingSource;
            this.dataGridViewMoviesByGenre.Location = new System.Drawing.Point(214, 65);
            this.dataGridViewMoviesByGenre.Name = "dataGridViewMoviesByGenre";
            this.dataGridViewMoviesByGenre.ReadOnly = true;
            this.dataGridViewMoviesByGenre.RowHeadersVisible = false;
            this.dataGridViewMoviesByGenre.Size = new System.Drawing.Size(432, 308);
            this.dataGridViewMoviesByGenre.TabIndex = 4;
            this.dataGridViewMoviesByGenre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMoviesByGenre_CellContentClick);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "Rank";
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            this.rankDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movieSearchBindingSource
            // 
            this.movieSearchBindingSource.DataMember = "movieSearch";
            this.movieSearchBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "movie";
            this.movieBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // imdbcloneDataSetBindingSource
            // 
            this.imdbcloneDataSetBindingSource.DataSource = this.imdbcloneDataSet;
            this.imdbcloneDataSetBindingSource.Position = 0;
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.actedTableAdapter = null;
            this.tableAdapterManager.actorSearchTableAdapter = null;
            this.tableAdapterManager.actorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.directedTableAdapter = null;
            this.tableAdapterManager.directorSearchTableAdapter = null;
            this.tableAdapterManager.directorTableAdapter = null;
            this.tableAdapterManager.genreSearchTableAdapter = null;
            this.tableAdapterManager.genreTableAdapter = this.genreTableAdapter;
            this.tableAdapterManager.moviegenreTableAdapter = null;
            this.tableAdapterManager.movieSearchTableAdapter = null;
            this.tableAdapterManager.movieTableAdapter = this.movieTableAdapter;
            this.tableAdapterManager.UpdateOrder = IMDBCloneApplication.imdbcloneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // movieSearchTableAdapter
            // 
            this.movieSearchTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRemoveOrEditGenresToolStripMenuItem,
            this.addremoveMoviesTofromGenresToolStripMenuItem});
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.genreToolStripMenuItem.Text = "Genre";
            // 
            // addRemoveOrEditGenresToolStripMenuItem
            // 
            this.addRemoveOrEditGenresToolStripMenuItem.Name = "addRemoveOrEditGenresToolStripMenuItem";
            this.addRemoveOrEditGenresToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.addRemoveOrEditGenresToolStripMenuItem.Text = "Add, remove or edit genres";
            this.addRemoveOrEditGenresToolStripMenuItem.Click += new System.EventHandler(this.AddRemoveOrEditGenresToolStripMenuItem_Click);
            // 
            // addremoveMoviesTofromGenresToolStripMenuItem
            // 
            this.addremoveMoviesTofromGenresToolStripMenuItem.Name = "addremoveMoviesTofromGenresToolStripMenuItem";
            this.addremoveMoviesTofromGenresToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.addremoveMoviesTofromGenresToolStripMenuItem.Text = "Add/remove movies to/from genres";
            this.addremoveMoviesTofromGenresToolStripMenuItem.Click += new System.EventHandler(this.AddremoveMoviesTofromGenresToolStripMenuItem_Click);
            // 
            // Genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 384);
            this.Controls.Add(label1);
            this.Controls.Add(this.dataGridViewMoviesByGenre);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.dataGridViewGenres);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Genre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genre";
            this.Load += new System.EventHandler(this.Genre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoviesByGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGenres;
        private System.Windows.Forms.BindingSource imdbcloneDataSetBindingSource;
        private imdbcloneDataSet imdbcloneDataSet;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private imdbcloneDataSetTableAdapters.genreTableAdapter genreTableAdapter;
        private imdbcloneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private imdbcloneDataSetTableAdapters.movieTableAdapter movieTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewMoviesByGenre;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource movieSearchBindingSource;
        private imdbcloneDataSetTableAdapters.movieSearchTableAdapter movieSearchTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRemoveOrEditGenresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addremoveMoviesTofromGenresToolStripMenuItem;
    }
}