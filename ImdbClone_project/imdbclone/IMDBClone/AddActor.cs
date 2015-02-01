using System;
using System.Windows.Forms;
using DAL;

namespace IMDBCloneApplication
{
    public partial class AddActor : Form
    {
        Controller myController = new Controller();
        private DAL.Controller controller = new DAL.Controller();
        private ActorForm mainForm = null;

        //custom constructor
        public AddActor(Form myCallingForm)
        {
            mainForm = myCallingForm as ActorForm;
            InitializeComponent();
        }

        //load tableadapter for actors
        private void AddActor_Load(object sender, EventArgs e)
        {

            // TODO REMOVE?
            try
            {
                //this.actorTableAdapter.Fill(this.imdbcloneDataSet.actor);
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
                DialogResult result = MessageBox.Show("Do you really want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    //code for Yes
                    controller.DeleteActor(ConvertToActor());
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

        //add new record
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                controller.CreateActor(ConvertToActor());
                mainForm.RefreshForm();
                ClearAll();
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
                controller.UpdateActor(ConvertToActor());
                mainForm.RefreshForm();
                ClearAll();
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //notify Actor form that data has changed
        private void AddActor_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.RefreshForm();
        }

        private Actor ConvertToActor()
        {
            Actor a = new Actor()
            {
                name = this.nameTextBox.Text,
                birthdate = birthdateTimePicker.Value.Date
            };
            try
            {           
                if (!String.IsNullOrEmpty(this.biographyTextBox.Text))
                {
                    a.biography = this.biographyTextBox.Text;
                }
                else
                {
                    a.biography = null;
                }
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(this.nameTextBox.Text))
                {
                    ActorToTextBox(controller.GetActorsByNameAndBirthDate(this.nameTextBox.Text, birthdateTimePicker.Value.Date));
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

        private void ActorToTextBox(Actor a)
        {
            nameTextBox.Text = a.name;
            birthdateTimePicker.Value = a.birthdate;
            biographyTextBox.Text = a.biography;

        }

        public void ClearAll()
        {
            nameTextBox.Text = null;
            birthdateTimePicker.Value = DateTime.Now;
            biographyTextBox.Text = null; 
        }
    }
}
