using System;
using System.Windows.Forms;
using DAL;

namespace IMDBCloneApplication
{
    public partial class ActorForm : Form
    {
        Controller myController = new Controller();
        DAL.Controller controller = new DAL.Controller();

        //default constructor
        public ActorForm()
        {
            InitializeComponent();
        }

        //load tableadapters
        private void ActorForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.searchActorComboBox.DataSource = controller.GetAllActors();
                this.searchActorComboBox.SelectedItem = null;

                this.dataGridViewActors.DataSource = controller.GetAllActors();
                this.dataGridViewActors.Refresh();
                DisplayActorInfo();
            }
            catch (Exception ex)
            {
                //TODO
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //load data for selected actor
        /*
        private void ShowSelectedValue()
        {
            string searchSelectedValue = searchActorComboBox.Text;
            try
            {
                this.dataGridViewActors.DataSource = controller.GetActorsByName(searchSelectedValue);
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        */

        //reload tableadapters
        public void RefreshForm()
        {
            try
            {
                this.searchActorComboBox.DataSource = controller.GetAllActors();
                this.searchActorComboBox.SelectedItem = null;

                this.dataGridViewActors.DataSource = controller.GetAllActors();
                this.dataGridViewActors.Refresh();

                DisplayActorInfo();
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //show data for selected actor
        private void SearchActorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (searchActorComboBox.SelectedItem != null)
                {
                    if (!String.IsNullOrEmpty(searchActorComboBox.Text))
                    {
                        string searchSelectedValue = searchActorComboBox.Text;

                        this.dataGridViewActors.DataSource = controller.GetActorsByName(searchSelectedValue);
                    }
                    else
                    {
                        this.searchActorComboBox.DataSource = controller.GetAllActors();
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //show add actors form
        private void AddOrRemoveActorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddActor myAddActorFrame = new AddActor(this);
            myAddActorFrame.ShowDialog();
        }

        //show add actors to movies form
        private void AddremoveActorsTofromMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddActorsToMovies myAddActorsToMovies = new AddActorsToMovies();
            myAddActorsToMovies.ShowDialog();
        }

        //show data for selected actor
        private void SearchActorComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //string searchSelectedValue = searchActorComboBox.Text;

                    string searchSelectedValue = searchActorComboBox.Text;

                    this.dataGridViewActors.DataSource = controller.GetActorsByName(searchSelectedValue);
                    DisplayActorInfo();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //show data for selected actor for gridview selection
        private void DataGridViewActors_SelectionChanged(object sender, EventArgs e)
        {
            DisplayActorInfo();
        }

        private void dataGridViewActors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO TA BORT
        }

        private void DisplayActorInfo()
        {
            try
            {
                if (this.dataGridViewActors.SelectedRows.Count > 0)
                {
                    Actor a = (Actor) this.dataGridViewActors.SelectedRows[0].DataBoundItem;
                    this.actorNameTextBox.Text = a.name;
                    this.biographyTextBox.Text = a.biography;
                    this.birthdateDateTimePicker.Value = a.birthdate;

                    this.dataGridViewActed.DataSource = controller.GetAllMoviesForActor(a.name, a.birthdate);
                    this.dataGridViewActed.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
        }
    }
}
