using System;
using System.Windows.Forms;

namespace IMDBCloneApplication
{
    public partial class AddGenre : Form
    {
        Controller myController = new Controller();
        private Genre mainForm = null;

        //custom constructor 
        public AddGenre(Form myCallingForm)
        {
            mainForm = myCallingForm as Genre;
            InitializeComponent();
        }

        //load tableadapter
        private void AddGenre_Load(object sender, EventArgs e)
        {
            try
            {
                this.genreTableAdapter.Fill(this.imdbcloneDataSet.genre);

            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //show previous record
        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                this.genreBindingSource.MovePrevious();

            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //show next record
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            try
            {
                this.genreBindingSource.MoveNext();

            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //delete current record
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //code for Yes
                    this.genreBindingSource.RemoveCurrent();
                    this.Validate();
                    this.genreBindingSource.EndEdit();
                    this.genreTableAdapter.Update(this.imdbcloneDataSet);
                }
                catch (Exception ex)
                {
                    string errorMessage = myController.HandleAllExceptions(ex);
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        //add new record
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //creates a new empty GenreRow
            try
            {
                this.genreBindingSource.AddNew();

            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //save changes
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.genreBindingSource.EndEdit();
                this.genreTableAdapter.Update(this.imdbcloneDataSet);
                MessageBox.Show("Changes saved", "Saved changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //notify Genre form that data has changed
        private void AddGenre_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.RefreshForm();
        }
    }
}
