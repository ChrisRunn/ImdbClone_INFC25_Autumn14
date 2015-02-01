using System;
using System.Windows.Forms;

namespace IMDBCloneApplication
{
    public partial class AddDirector : Form
    {
        Controller myController = new Controller();
        private DirectorForm mainForm = null;

        //custom constructor
        public AddDirector(Form myCallingForm)
        {
            mainForm = myCallingForm as DirectorForm;
            InitializeComponent();
        }

        //load tableadapters for directors
        private void AddDirector_Load(object sender, EventArgs e)
        {
            try
            {
                this.directorTableAdapter.Fill(this.imdbcloneDataSet.director);
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //add new record
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //creates a new empty DirectorRow
            try
            {
                this.directorBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            //sets DateTime to current date
            String myDate = DateTime.Now.ToString();
            birthdateDateTimePicker.Text = myDate;
        }

        //save changes
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.directorBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.imdbcloneDataSet);
                MessageBox.Show("Changes saved", "Saved changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                //code for Yes
                try
                {
                    this.directorBindingSource.RemoveCurrent();
                    this.Validate();
                    this.directorBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.imdbcloneDataSet);
                }
                catch (Exception ex)
                {
                    string errorMessage = myController.HandleAllExceptions(ex);
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //show next record
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            try
            {
                this.directorBindingSource.MoveNext();

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
                this.directorBindingSource.MovePrevious();

            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        //notify Director form that data has changed
        public void AddDirector_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.RefreshForm();
        }
    }
}
