namespace IMDBCloneApplication
{
    partial class AddActor
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.actorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imdbcloneDataSet = new IMDBCloneApplication.imdbcloneDataSet();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.birthdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.biographyLabel = new System.Windows.Forms.Label();
            this.biographyTextBox = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.actorTableAdapter = new IMDBCloneApplication.imdbcloneDataSetTableAdapters.actorTableAdapter();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(26, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actorBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(69, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(169, 20);
            this.nameTextBox.TabIndex = 1;
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
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(12, 50);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(52, 13);
            this.birthdateLabel.TabIndex = 2;
            this.birthdateLabel.Text = "Birthdate:";
            // 
            // birthdateTimePicker
            // 
            this.birthdateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.actorBindingSource, "birthdate", true));
            this.birthdateTimePicker.Location = new System.Drawing.Point(69, 44);
            this.birthdateTimePicker.Name = "birthdateTimePicker";
            this.birthdateTimePicker.Size = new System.Drawing.Size(168, 20);
            this.birthdateTimePicker.TabIndex = 3;
            // 
            // biographyLabel
            // 
            this.biographyLabel.AutoSize = true;
            this.biographyLabel.Location = new System.Drawing.Point(7, 78);
            this.biographyLabel.Name = "biographyLabel";
            this.biographyLabel.Size = new System.Drawing.Size(57, 13);
            this.biographyLabel.TabIndex = 4;
            this.biographyLabel.Text = "Biography:";
            // 
            // biographyTextBox
            // 
            this.biographyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actorBindingSource, "biography", true));
            this.biographyTextBox.Location = new System.Drawing.Point(70, 78);
            this.biographyTextBox.Multiline = true;
            this.biographyTextBox.Name = "biographyTextBox";
            this.biographyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.biographyTextBox.Size = new System.Drawing.Size(407, 161);
            this.biographyTextBox.TabIndex = 5;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(380, 254);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(66, 25);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(220, 253);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(65, 26);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(306, 254);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(57, 25);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // actorTableAdapter
            // 
            this.actorTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(70, 254);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 289);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.biographyTextBox);
            this.Controls.Add(this.biographyLabel);
            this.Controls.Add(this.birthdateTimePicker);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddActor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add an actor to the database";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddActor_FormClosed);
            this.Load += new System.EventHandler(this.AddActor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdbcloneDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.DateTimePicker birthdateTimePicker;
        private System.Windows.Forms.Label biographyLabel;
        private System.Windows.Forms.TextBox biographyTextBox;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private imdbcloneDataSet imdbcloneDataSet;
        private System.Windows.Forms.BindingSource actorBindingSource;
        private imdbcloneDataSetTableAdapters.actorTableAdapter actorTableAdapter;
        private System.Windows.Forms.Button buttonSearch;
    }
}