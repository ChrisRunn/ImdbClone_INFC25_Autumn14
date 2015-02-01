namespace IMDBCloneApplication
{
    partial class AddDirector
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.biographyTextBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.directorSearchComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.directorSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorSearchTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.directorSearchTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            birthdateLabel = new System.Windows.Forms.Label();
            biographyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorSearchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(28, 10);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Location = new System.Drawing.Point(13, 49);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(52, 13);
            birthdateLabel.TabIndex = 2;
            birthdateLabel.Text = "Birthdate:";
            // 
            // biographyLabel
            // 
            biographyLabel.AutoSize = true;
            biographyLabel.Location = new System.Drawing.Point(8, 88);
            biographyLabel.Name = "biographyLabel";
            biographyLabel.Size = new System.Drawing.Size(57, 13);
            biographyLabel.TabIndex = 4;
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
            this.tableAdapterManager.directedTableAdapter = null;
            this.tableAdapterManager.directorSearchTableAdapter = null;
            this.tableAdapterManager.directorTableAdapter = this.directorTableAdapter;
            this.tableAdapterManager.genreSearchTableAdapter = null;
            this.tableAdapterManager.genreTableAdapter = null;
            this.tableAdapterManager.moviegenreTableAdapter = null;
            this.tableAdapterManager.movieSearchTableAdapter = null;
            this.tableAdapterManager.movieTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = IMDBCloneApplication.imdbcloneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.directorBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(70, 7);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.directorBindingSource, "birthdate", true));
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(70, 45);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdateDateTimePicker.TabIndex = 3;
            // 
            // biographyTextBox
            // 
            this.biographyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.directorBindingSource, "biography", true));
            this.biographyTextBox.Location = new System.Drawing.Point(70, 85);
            this.biographyTextBox.Multiline = true;
            this.biographyTextBox.Name = "biographyTextBox";
            this.biographyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.biographyTextBox.Size = new System.Drawing.Size(454, 144);
            this.biographyTextBox.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(449, 235);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(368, 235);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(151, 235);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(286, 235);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(70, 235);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 10;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // directorSearchComboBox
            // 
            this.directorSearchComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.directorSearchComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.directorSearchComboBox.DataSource = this.directorBindingSource;
            this.directorSearchComboBox.DisplayMember = "name";
            this.directorSearchComboBox.FormattingEnabled = true;
            this.directorSearchComboBox.Location = new System.Drawing.Point(368, 6);
            this.directorSearchComboBox.Name = "directorSearchComboBox";
            this.directorSearchComboBox.Size = new System.Drawing.Size(156, 21);
            this.directorSearchComboBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search by name:";
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
            // AddDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directorSearchComboBox);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(biographyLabel);
            this.Controls.Add(this.biographyTextBox);
            this.Controls.Add(birthdateLabel);
            this.Controls.Add(this.birthdateDateTimePicker);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddDirector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a director to database";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddDirector_FormClosed);
            this.Load += new System.EventHandler(this.AddDirector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorSearchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private imdbcloneDataSet imdbcloneDataSet;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private imdbcloneDataSetTableAdapters.directorTableAdapter directorTableAdapter;
        private imdbcloneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.TextBox biographyTextBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.ComboBox directorSearchComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource directorSearchBindingSource;
        private imdbcloneDataSetTableAdapters.directorSearchTableAdapter directorSearchTableAdapter;
    }
}