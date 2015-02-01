namespace IMDBCloneApplication
{
    partial class AddDirectorsToMovies
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
            this.comboBoxSelectedMovie = new System.Windows.Forms.ComboBox();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imdbcloneDataSet = new IMDBCloneApplication.imdbcloneDataSet();
            this.directorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.directorTableAdapter();
            this.titleLabel = new System.Windows.Forms.Label();
            this.movieSearchDataGridView = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorSearchTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.directorSearchTableAdapter();
            this.directorSelectLabel = new System.Windows.Forms.Label();
            this.directorDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.movieTableAdapter();
            this.movieSelectLabel = new System.Windows.Forms.Label();
            this.directedDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directedTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.directedTableAdapter();
            this.directedSelectLabel = new System.Windows.Forms.Label();
            this.buttonAddSelectedDirector = new System.Windows.Forms.Button();
            this.buttonRemoveSelectedDirector = new System.Windows.Forms.Button();
            this.movieSearchTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.movieSearchTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSelectedMovie
            // 
            this.comboBoxSelectedMovie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSelectedMovie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSelectedMovie.DataSource = this.movieBindingSource;
            this.comboBoxSelectedMovie.DisplayMember = "title";
            this.comboBoxSelectedMovie.FormattingEnabled = true;
            this.comboBoxSelectedMovie.Location = new System.Drawing.Point(95, 8);
            this.comboBoxSelectedMovie.Name = "comboBoxSelectedMovie";
            this.comboBoxSelectedMovie.Size = new System.Drawing.Size(184, 21);
            this.comboBoxSelectedMovie.TabIndex = 0;
            this.comboBoxSelectedMovie.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectedMovie_SelectedIndexChanged);
            this.comboBoxSelectedMovie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxSelectedMovie_KeyDown);
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "movie";
            this.movieBindingSource.DataSource = this.imdbcloneDataSet;
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
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(70, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Find a movie:";
            // 
            // movieSearchDataGridView
            // 
            this.movieSearchDataGridView.AllowUserToAddRows = false;
            this.movieSearchDataGridView.AllowUserToDeleteRows = false;
            this.movieSearchDataGridView.AllowUserToResizeRows = false;
            this.movieSearchDataGridView.AutoGenerateColumns = false;
            this.movieSearchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.movieSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieSearchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn1,
            this.yearDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn});
            this.movieSearchDataGridView.DataSource = this.movieSearchBindingSource;
            this.movieSearchDataGridView.Location = new System.Drawing.Point(12, 76);
            this.movieSearchDataGridView.MultiSelect = false;
            this.movieSearchDataGridView.Name = "movieSearchDataGridView";
            this.movieSearchDataGridView.ReadOnly = true;
            this.movieSearchDataGridView.RowHeadersVisible = false;
            this.movieSearchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movieSearchDataGridView.Size = new System.Drawing.Size(502, 150);
            this.movieSearchDataGridView.TabIndex = 2;
            this.movieSearchDataGridView.SelectionChanged += new System.EventHandler(this.MovieSearchDataGridView_SelectionChanged);
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
            // directorSearchBindingSource
            // 
            this.directorSearchBindingSource.DataMember = "directorSearch";
            this.directorSearchBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // directorSearchTableAdapter
            // 
            this.directorSearchTableAdapter.ClearBeforeFill = true;
            // 
            // directorSelectLabel
            // 
            this.directorSelectLabel.AutoSize = true;
            this.directorSelectLabel.Location = new System.Drawing.Point(9, 242);
            this.directorSelectLabel.Name = "directorSelectLabel";
            this.directorSelectLabel.Size = new System.Drawing.Size(120, 13);
            this.directorSelectLabel.TabIndex = 3;
            this.directorSelectLabel.Text = "Select a to add director:";
            // 
            // directorDataGridView
            // 
            this.directorDataGridView.AllowUserToAddRows = false;
            this.directorDataGridView.AllowUserToDeleteRows = false;
            this.directorDataGridView.AllowUserToResizeRows = false;
            this.directorDataGridView.AutoGenerateColumns = false;
            this.directorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.directorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn});
            this.directorDataGridView.DataSource = this.directorBindingSource;
            this.directorDataGridView.Location = new System.Drawing.Point(12, 258);
            this.directorDataGridView.MultiSelect = false;
            this.directorDataGridView.Name = "directorDataGridView";
            this.directorDataGridView.ReadOnly = true;
            this.directorDataGridView.RowHeadersVisible = false;
            this.directorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.directorDataGridView.Size = new System.Drawing.Size(247, 150);
            this.directorDataGridView.TabIndex = 4;
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
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // movieSelectLabel
            // 
            this.movieSelectLabel.AutoSize = true;
            this.movieSelectLabel.Location = new System.Drawing.Point(9, 60);
            this.movieSelectLabel.Name = "movieSelectLabel";
            this.movieSelectLabel.Size = new System.Drawing.Size(80, 13);
            this.movieSelectLabel.TabIndex = 5;
            this.movieSelectLabel.Text = "Select a movie:";
            // 
            // directedDataGridView
            // 
            this.directedDataGridView.AllowUserToAddRows = false;
            this.directedDataGridView.AllowUserToDeleteRows = false;
            this.directedDataGridView.AllowUserToResizeRows = false;
            this.directedDataGridView.AutoGenerateColumns = false;
            this.directedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.directedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.birthdateDataGridViewTextBoxColumn1});
            this.directedDataGridView.DataSource = this.directedBindingSource;
            this.directedDataGridView.Location = new System.Drawing.Point(268, 258);
            this.directedDataGridView.MultiSelect = false;
            this.directedDataGridView.Name = "directedDataGridView";
            this.directedDataGridView.ReadOnly = true;
            this.directedDataGridView.RowHeadersVisible = false;
            this.directedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.directedDataGridView.Size = new System.Drawing.Size(246, 150);
            this.directedDataGridView.TabIndex = 6;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // birthdateDataGridViewTextBoxColumn1
            // 
            this.birthdateDataGridViewTextBoxColumn1.DataPropertyName = "birthdate";
            this.birthdateDataGridViewTextBoxColumn1.HeaderText = "birthdate";
            this.birthdateDataGridViewTextBoxColumn1.Name = "birthdateDataGridViewTextBoxColumn1";
            this.birthdateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // directedBindingSource
            // 
            this.directedBindingSource.DataMember = "directed";
            this.directedBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // directedTableAdapter
            // 
            this.directedTableAdapter.ClearBeforeFill = true;
            // 
            // directedSelectLabel
            // 
            this.directedSelectLabel.AutoSize = true;
            this.directedSelectLabel.Location = new System.Drawing.Point(265, 242);
            this.directedSelectLabel.Name = "directedSelectLabel";
            this.directedSelectLabel.Size = new System.Drawing.Size(133, 13);
            this.directedSelectLabel.TabIndex = 7;
            this.directedSelectLabel.Text = "Select directors to remove:";
            // 
            // buttonAddSelectedDirector
            // 
            this.buttonAddSelectedDirector.Location = new System.Drawing.Point(187, 414);
            this.buttonAddSelectedDirector.Name = "buttonAddSelectedDirector";
            this.buttonAddSelectedDirector.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSelectedDirector.TabIndex = 8;
            this.buttonAddSelectedDirector.Text = "Add";
            this.buttonAddSelectedDirector.UseVisualStyleBackColor = true;
            this.buttonAddSelectedDirector.Click += new System.EventHandler(this.ButtonAddSelectedDirector_Click);
            // 
            // buttonRemoveSelectedDirector
            // 
            this.buttonRemoveSelectedDirector.Location = new System.Drawing.Point(439, 414);
            this.buttonRemoveSelectedDirector.Name = "buttonRemoveSelectedDirector";
            this.buttonRemoveSelectedDirector.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveSelectedDirector.TabIndex = 9;
            this.buttonRemoveSelectedDirector.Text = "Remove";
            this.buttonRemoveSelectedDirector.UseVisualStyleBackColor = true;
            this.buttonRemoveSelectedDirector.Click += new System.EventHandler(this.ButtonRemoveSelectedDirector_Click);
            // 
            // movieSearchTableAdapter
            // 
            this.movieSearchTableAdapter.ClearBeforeFill = true;
            // 
            // AddDirectorsToMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 446);
            this.Controls.Add(this.buttonRemoveSelectedDirector);
            this.Controls.Add(this.buttonAddSelectedDirector);
            this.Controls.Add(this.directedSelectLabel);
            this.Controls.Add(this.directedDataGridView);
            this.Controls.Add(this.movieSelectLabel);
            this.Controls.Add(this.directorDataGridView);
            this.Controls.Add(this.directorSelectLabel);
            this.Controls.Add(this.movieSearchDataGridView);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.comboBoxSelectedMovie);
            this.Name = "AddDirectorsToMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/remove Directors to/from Movies";
            this.Load += new System.EventHandler(this.AddDirectorsTo_Movies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectedMovie;
        private imdbcloneDataSet imdbcloneDataSet;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private imdbcloneDataSetTableAdapters.directorTableAdapter directorTableAdapter;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView movieSearchDataGridView;
        private System.Windows.Forms.BindingSource directorSearchBindingSource;
        private imdbcloneDataSetTableAdapters.directorSearchTableAdapter directorSearchTableAdapter;
        private System.Windows.Forms.Label directorSelectLabel;
        private System.Windows.Forms.DataGridView directorDataGridView;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private imdbcloneDataSetTableAdapters.movieTableAdapter movieTableAdapter;
        private System.Windows.Forms.Label movieSelectLabel;
        private System.Windows.Forms.DataGridView directedDataGridView;
        private System.Windows.Forms.BindingSource directedBindingSource;
        private imdbcloneDataSetTableAdapters.directedTableAdapter directedTableAdapter;
        private System.Windows.Forms.Label directedSelectLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button buttonAddSelectedDirector;
        private System.Windows.Forms.Button buttonRemoveSelectedDirector;
        private System.Windows.Forms.BindingSource movieSearchBindingSource;
        private imdbcloneDataSetTableAdapters.movieSearchTableAdapter movieSearchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
    }
}