namespace IMDBCloneApplication
{
    partial class AddActorsToMovies
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label label2;
            this.imdbcloneDataSet = new IMDBCloneApplication.imdbcloneDataSet();
            this.actorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.actorTableAdapter();
            this.tableAdapterManager = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.TableAdapterManager();
            this.movieTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.movieTableAdapter();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddSelectedActors = new System.Windows.Forms.Button();
            this.buttonRemoveSelectedActors = new System.Windows.Forms.Button();
            this.actorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewActed = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actedTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.actedTableAdapter();
            this.movieSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieSearchTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.movieSearchTableAdapter();
            this.comboBoxSelectedMovie = new System.Windows.Forms.ComboBox();
            this.movieSearchDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSelectMovie = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(8, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(70, 13);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Find a movie:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(7, 209);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(105, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Select actors to add:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(270, 209);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(122, 13);
            label2.TabIndex = 10;
            label2.Text = "Select actors to remove:";
            // 
            // imdbcloneDataSet
            // 
            this.imdbcloneDataSet.DataSetName = "imdbcloneDataSet";
            this.imdbcloneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actorBindingSource
            // 
            this.actorBindingSource.DataMember = "actor";
            this.actorBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // actorTableAdapter
            // 
            this.actorTableAdapter.ClearBeforeFill = true;
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
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "movie";
            this.movieBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // buttonAddSelectedActors
            // 
            this.buttonAddSelectedActors.Location = new System.Drawing.Point(183, 466);
            this.buttonAddSelectedActors.Name = "buttonAddSelectedActors";
            this.buttonAddSelectedActors.Size = new System.Drawing.Size(84, 23);
            this.buttonAddSelectedActors.TabIndex = 4;
            this.buttonAddSelectedActors.Text = "Add";
            this.buttonAddSelectedActors.UseVisualStyleBackColor = true;
            this.buttonAddSelectedActors.Click += new System.EventHandler(this.ButtonAddSelectedActors_Click);
            // 
            // buttonRemoveSelectedActors
            // 
            this.buttonRemoveSelectedActors.Location = new System.Drawing.Point(445, 466);
            this.buttonRemoveSelectedActors.Name = "buttonRemoveSelectedActors";
            this.buttonRemoveSelectedActors.Size = new System.Drawing.Size(84, 23);
            this.buttonRemoveSelectedActors.TabIndex = 5;
            this.buttonRemoveSelectedActors.Text = "Remove";
            this.buttonRemoveSelectedActors.UseVisualStyleBackColor = true;
            this.buttonRemoveSelectedActors.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // actorDataGridView
            // 
            this.actorDataGridView.AllowUserToAddRows = false;
            this.actorDataGridView.AllowUserToDeleteRows = false;
            this.actorDataGridView.AllowUserToResizeColumns = false;
            this.actorDataGridView.AllowUserToResizeRows = false;
            this.actorDataGridView.AutoGenerateColumns = false;
            this.actorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.actorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.birthdate});
            this.actorDataGridView.DataSource = this.actorBindingSource;
            this.actorDataGridView.Location = new System.Drawing.Point(10, 225);
            this.actorDataGridView.Name = "actorDataGridView";
            this.actorDataGridView.ReadOnly = true;
            this.actorDataGridView.RowHeadersVisible = false;
            this.actorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.actorDataGridView.Size = new System.Drawing.Size(257, 235);
            this.actorDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // birthdate
            // 
            this.birthdate.DataPropertyName = "birthdate";
            this.birthdate.HeaderText = "birthdate";
            this.birthdate.Name = "birthdate";
            this.birthdate.ReadOnly = true;
            // 
            // dataGridViewActed
            // 
            this.dataGridViewActed.AllowUserToAddRows = false;
            this.dataGridViewActed.AllowUserToDeleteRows = false;
            this.dataGridViewActed.AllowUserToResizeColumns = false;
            this.dataGridViewActed.AllowUserToResizeRows = false;
            this.dataGridViewActed.AutoGenerateColumns = false;
            this.dataGridViewActed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7});
            this.dataGridViewActed.DataSource = this.actedBindingSource;
            this.dataGridViewActed.Location = new System.Drawing.Point(273, 225);
            this.dataGridViewActed.MultiSelect = false;
            this.dataGridViewActed.Name = "dataGridViewActed";
            this.dataGridViewActed.ReadOnly = true;
            this.dataGridViewActed.RowHeadersVisible = false;
            this.dataGridViewActed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActed.Size = new System.Drawing.Size(257, 235);
            this.dataGridViewActed.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "birthdate";
            this.dataGridViewTextBoxColumn7.HeaderText = "birthdate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
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
            // movieSearchBindingSource
            // 
            this.movieSearchBindingSource.DataMember = "movieSearch";
            this.movieSearchBindingSource.DataSource = this.imdbcloneDataSet;
            // 
            // movieSearchTableAdapter
            // 
            this.movieSearchTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxSelectedMovie
            // 
            this.comboBoxSelectedMovie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSelectedMovie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSelectedMovie.DataSource = this.movieBindingSource;
            this.comboBoxSelectedMovie.DisplayMember = "title";
            this.comboBoxSelectedMovie.FormattingEnabled = true;
            this.comboBoxSelectedMovie.Location = new System.Drawing.Point(94, 12);
            this.comboBoxSelectedMovie.Name = "comboBoxSelectedMovie";
            this.comboBoxSelectedMovie.Size = new System.Drawing.Size(223, 21);
            this.comboBoxSelectedMovie.TabIndex = 12;
            this.comboBoxSelectedMovie.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectedMovie_SelectedIndexChanged);
            this.comboBoxSelectedMovie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxSelectedMovie_KeyDown);
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
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.movieSearchDataGridView.DataSource = this.movieSearchBindingSource;
            this.movieSearchDataGridView.Location = new System.Drawing.Point(10, 74);
            this.movieSearchDataGridView.MultiSelect = false;
            this.movieSearchDataGridView.Name = "movieSearchDataGridView";
            this.movieSearchDataGridView.ReadOnly = true;
            this.movieSearchDataGridView.RowHeadersVisible = false;
            this.movieSearchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movieSearchDataGridView.Size = new System.Drawing.Size(519, 117);
            this.movieSearchDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn3.HeaderText = "title";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "year";
            this.dataGridViewTextBoxColumn4.HeaderText = "year";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn5.HeaderText = "description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "rank";
            this.dataGridViewTextBoxColumn6.HeaderText = "rank";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // labelSelectMovie
            // 
            this.labelSelectMovie.AutoSize = true;
            this.labelSelectMovie.Location = new System.Drawing.Point(7, 58);
            this.labelSelectMovie.Name = "labelSelectMovie";
            this.labelSelectMovie.Size = new System.Drawing.Size(80, 13);
            this.labelSelectMovie.TabIndex = 13;
            this.labelSelectMovie.Text = "Select a movie:";
            // 
            // AddActorsToMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 509);
            this.Controls.Add(this.labelSelectMovie);
            this.Controls.Add(this.movieSearchDataGridView);
            this.Controls.Add(this.comboBoxSelectedMovie);
            this.Controls.Add(this.dataGridViewActed);
            this.Controls.Add(this.actorDataGridView);
            this.Controls.Add(label2);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.buttonRemoveSelectedActors);
            this.Controls.Add(this.buttonAddSelectedActors);
            this.Controls.Add(titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddActorsToMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Remove Actors to/from Movies";
            this.Load += new System.EventHandler(this.AddActorsToMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieSearchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private imdbcloneDataSet imdbcloneDataSet;
        private System.Windows.Forms.BindingSource actorBindingSource;
        private imdbcloneDataSetTableAdapters.actorTableAdapter actorTableAdapter;
        private imdbcloneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private imdbcloneDataSetTableAdapters.movieTableAdapter movieTableAdapter;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.Button buttonAddSelectedActors;
        private System.Windows.Forms.Button buttonRemoveSelectedActors;
        private System.Windows.Forms.DataGridView actorDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewActed;
        private System.Windows.Forms.BindingSource actedBindingSource;
        private imdbcloneDataSetTableAdapters.actedTableAdapter actedTableAdapter;
        private System.Windows.Forms.BindingSource movieSearchBindingSource;
        private imdbcloneDataSetTableAdapters.movieSearchTableAdapter movieSearchTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxSelectedMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridView movieSearchDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label labelSelectMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}