namespace IMDBCloneApplication
{
    partial class AddGenre
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
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imdbcloneDataSet = new IMDBCloneApplication.imdbcloneDataSet();
            this.genreTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.genreTableAdapter();
            this.searchByGenreLabel = new System.Windows.Forms.Label();
            this.comboBoxGenreSearch = new System.Windows.Forms.ComboBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(9, 27);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(82, 13);
            this.genreLabel.TabIndex = 0;
            this.genreLabel.Text = "Selected genre:";
            // 
            // genreTextBox
            // 
            this.genreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genreBindingSource, "name", true));
            this.genreTextBox.Location = new System.Drawing.Point(12, 43);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(240, 20);
            this.genreTextBox.TabIndex = 1;
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
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // searchByGenreLabel
            // 
            this.searchByGenreLabel.AutoSize = true;
            this.searchByGenreLabel.Location = new System.Drawing.Point(255, 27);
            this.searchByGenreLabel.Name = "searchByGenreLabel";
            this.searchByGenreLabel.Size = new System.Drawing.Size(69, 13);
            this.searchByGenreLabel.TabIndex = 2;
            this.searchByGenreLabel.Text = "Find a genre:";
            // 
            // comboBoxGenreSearch
            // 
            this.comboBoxGenreSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxGenreSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGenreSearch.DataSource = this.genreBindingSource;
            this.comboBoxGenreSearch.DisplayMember = "name";
            this.comboBoxGenreSearch.FormattingEnabled = true;
            this.comboBoxGenreSearch.Location = new System.Drawing.Point(258, 42);
            this.comboBoxGenreSearch.Name = "comboBoxGenreSearch";
            this.comboBoxGenreSearch.Size = new System.Drawing.Size(221, 21);
            this.comboBoxGenreSearch.TabIndex = 3;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(12, 92);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(66, 21);
            this.buttonPrevious.TabIndex = 4;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(84, 92);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(70, 21);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(215, 92);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(74, 21);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(338, 92);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(73, 21);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(417, 92);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(63, 21);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // AddGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 124);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.comboBoxGenreSearch);
            this.Controls.Add(this.searchByGenreLabel);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.genreLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add, edit or delete genres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddGenre_FormClosed);
            this.Load += new System.EventHandler(this.AddGenre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox genreTextBox;
        private imdbcloneDataSet imdbcloneDataSet;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private imdbcloneDataSetTableAdapters.genreTableAdapter genreTableAdapter;
        private System.Windows.Forms.Label searchByGenreLabel;
        private System.Windows.Forms.ComboBox comboBoxGenreSearch;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
    }
}