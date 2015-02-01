using System;
using System.Windows.Forms;
using DAL;

namespace IMDBCloneApplication
{
    public partial class DirectorForm : Form
    {
        MainForm startForm = new MainForm();
        Controller myController = new Controller();
        DAL.Controller controller = new DAL.Controller();


        public DirectorForm()
        {
            InitializeComponent();
        }

        //load table adapters
        private void DirectorForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.searchDirectorComboBox.DataSource = controller.GetAllDirectors();
                this.searchDirectorComboBox.SelectedItem = null;

                this.directorGridView.DataSource = controller.GetAllDirectors();
                this.directorGridView.Refresh();
                DisplayDirectorInfo();

            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //method to only show the selected value in the directorGridview
        private void ShowSelectedDirector()
        {
            string searchSelectedValue = searchDirectorComboBox.Text;
            try
            {
                this.directorSearchTableAdapter.FillByDirectorNameSimilar(this.imdbcloneDataSet.directorSearch, searchSelectedValue);
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //method to execute search when user presses ENTER key and enters an incomplete search term thus executing LIKE SQL query
        private void SearchDirectorComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    string searchSelectedValue = searchDirectorComboBox.Text;

                    this.directorGridView.DataSource = controller.GetDirectorByName(searchSelectedValue);
                    DisplayDirectorInfo();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        

        //show add directors form
        private void AddOrRemoveDirectorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDirector myAddDirectorFrame = new AddDirector(this);
            myAddDirectorFrame.ShowDialog();
        }

        //reload tableadapters
        public void RefreshForm()
        {
            try
            {
                this.searchDirectorComboBox.DataSource = controller.GetAllDirectors();
                this.searchDirectorComboBox.SelectedItem = null;

                this.directorGridView.DataSource = controller.GetAllDirectors();
                this.directorGridView.Refresh();

                DisplayDirectorInfo();

            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //method to search by selected director in the combobox
        private void SearchDirectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (searchDirectorComboBox.SelectedItem != null)
                {
                    if (!String.IsNullOrEmpty(searchDirectorComboBox.Text))
                    {
                        string searchSelectedValue = searchDirectorComboBox.Text;

                        this.directorGridView.DataSource = controller.GetDirectorByName(searchSelectedValue);
                    }
                    else
                    {
                        this.searchDirectorComboBox.DataSource = controller.GetAllDirectors();
                    }
                }
                
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        //show data for selected director
        private void DirectorGridView_SelectionChanged(object sender, EventArgs e)
        {
            DisplayDirectorInfo();
        }

        private void DisplayDirectorInfo()
    {
        try
        {
            if (this.directorGridView.SelectedRows.Count > 0)
            {
                Director d = (Director)this.directorGridView.SelectedRows[0].DataBoundItem;
                this.directorNameTextBox.Text = d.name;
                this.biographyTextBox.Text = d.biography;
                this.birthdateDateTimePicker.Value = d.birthdate;

                this.movieGridView.DataSource = controller.GetAllMoviesForDirector(d);
                this.movieGridView.ClearSelection();
            }
        }
        catch (Exception ex)
        {
            string errorMessage = myController.HandleAllExceptions(ex);
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

        //show add directors to movies form
        private void AddremoveDirectorsTofromMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDirectorsToMovies myAddDirectorsToMovies = new AddDirectorsToMovies();
            myAddDirectorsToMovies.ShowDialog();
        }

    }
}
