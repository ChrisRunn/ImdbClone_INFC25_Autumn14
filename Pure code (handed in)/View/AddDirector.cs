using System;
using System.Windows.Forms;
using DAL;

namespace IMDBCloneApplication
{
    public partial class AddDirector : Form
    {
        Controller myController = new Controller();
        private DAL.Controller controller = new DAL.Controller();
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

            // TODO REMOVE?
            try
            {
                //this.directorTableAdapter.Fill(this.imdbcloneDataSet.director);
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
                controller.CreateDirector(ConvertToDirector());
                mainForm.RefreshForm();
                ClearAll();
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
                controller.UpdateDirector(ConvertToDirector());
                mainForm.RefreshForm();
                ClearAll();
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
            try
            {
                DialogResult result = MessageBox.Show("Do you really want to delete?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    //code for Yes
                    controller.DeleteDirector(ConvertToDirector());
                    mainForm.RefreshForm();

                    ClearAll();
                }
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

        private Director ConvertToDirector()
        {
            Director d = new Director()
            {
                name = this.nameTextBox.Text,
                birthdate = birthdateDateTimePicker.Value.Date
            };
            try
            {
                if (!String.IsNullOrEmpty(this.biographyTextBox.Text))
                {
                    d.biography = this.biographyTextBox.Text;
                }
                else
                {
                    d.biography = null;
                }
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return d;
        }

        public void ClearAll()
        {
            nameTextBox.Text = null;
            birthdateDateTimePicker.Value = DateTime.Now;
            biographyTextBox.Text = null;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(this.nameTextBox.Text))
                {
                    DirectorToTextBox(controller.GetDirectorByNameAndBirthDate(ConvertToDirector()));
                }
                else
                {
                    MessageBox.Show("Inget namn, eller felaktigt namn, i textrutan för namn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DirectorToTextBox(Director d)
        {
            nameTextBox.Text = d.name;
            birthdateDateTimePicker.Value = d.birthdate;
            biographyTextBox.Text = d.biography;

        }
    }
}
