using System;
using System.Windows.Forms;

namespace IMDBCloneApplication
{
    public partial class DirectorForm : Form
    {

        Controller myController = new Controller();

        public DirectorForm()
        {
            InitializeComponent();
        }

        //load table adapters
        private void DirectorForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.movieSearchTableAdapter.Fill(this.imdbcloneDataSet.movieSearch);
                this.directorSearchTableAdapter.Fill(this.imdbcloneDataSet.directorSearch);
                this.movieTableAdapter.Fill(this.imdbcloneDataSet.movie);
                this.directorTableAdapter.Fill(this.imdbcloneDataSet.director);

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
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    ShowSelectedDirector();
                    this.movieSearchTableAdapter.FillByDirectedMovie(this.imdbcloneDataSet.movieSearch, directorNameTextBox.Text, birthdateDateTimePicker.Text);
                }
                catch (Exception ex)
                {
                    string errorMessage = myController.HandleAllExceptions(ex);
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

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
                this.directorTableAdapter.Fill(this.imdbcloneDataSet.director);
                this.directorSearchTableAdapter.Fill(this.imdbcloneDataSet.directorSearch);
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
            if (!String.IsNullOrEmpty(searchDirectorComboBox.Text))
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
        }

        //show data for selected director
        private void DirectorGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(directorNameTextBox.Text) && (!String.IsNullOrEmpty(birthdateDateTimePicker.Text)))
            {
                try
                {
                    this.movieSearchTableAdapter.FillByDirectedMovie(this.imdbcloneDataSet.movieSearch, directorNameTextBox.Text, birthdateDateTimePicker.Text);
                }
                catch (Exception ex)
                {
                    string errorMessage = myController.HandleAllExceptions(ex);
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
