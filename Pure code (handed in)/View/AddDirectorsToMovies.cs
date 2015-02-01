using System;
using System.Windows.Forms;

namespace IMDBCloneApplication
{
    public partial class AddDirectorsToMovies : Form
    {
        Controller myController = new Controller();

        public AddDirectorsToMovies()
        {
            InitializeComponent();
        }

        //fill
        private void AddDirectorsTo_Movies_Load(object sender, EventArgs e)
        {
            try
            {
                
                this.movieSearchTableAdapter.Fill(this.imdbcloneDataSet.movieSearch);
                this.directedTableAdapter.Fill(this.imdbcloneDataSet.directed);
                this.movieTableAdapter.Fill(this.imdbcloneDataSet.movie);
                this.directorTableAdapter.Fill(this.imdbcloneDataSet.director);
                DisplayDirectors();
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //add selected director to directed table
        private void ButtonAddSelectedDirector_Click(object sender, EventArgs e)
        {
            //get selected director and birthdate, movie title and movie year
            if (directorDataGridView.SelectedRows.Count > 0 && this.movieSearchDataGridView.SelectedRows.Count > 0)
            {
                String selectedActor = directorDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                DateTime selectedActorBirthdate = (DateTime)directorDataGridView.SelectedRows[0].Cells[1].Value;
                String selectedMovieTitle = movieSearchDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                int selectedMovieYear = (int)movieSearchDataGridView.SelectedRows[0].Cells[1].Value;

                try
                {
                    this.directedTableAdapter.Insert(selectedActor, selectedActorBirthdate, selectedMovieTitle, selectedMovieYear);
                    this.directedTableAdapter.Update(this.imdbcloneDataSet);
                    DisplayDirectors();
                    MessageBox.Show("A director has been added to the selected movie.", "Changes saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    string errorMessage = myController.HandleAllExceptions(ex);
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You must select a movie first.");
            }


        }


        //show directors that directed a selected movie by title and year if a movie result is found
        private void DisplayDirectors()
        {
            if (this.movieSearchDataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    String selectedMovieTitle = movieSearchDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    int selectedMovieYear = (int)movieSearchDataGridView.SelectedRows[0].Cells[1].Value;
                    this.directedTableAdapter.FillByTitleAndYear(this.imdbcloneDataSet.directed, selectedMovieTitle, selectedMovieYear);
                }
                catch (Exception ex)
                {
                    string errorMessage = myController.HandleAllExceptions(ex);
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                imdbcloneDataSet.directed.Clear(); //clear directed datatable
            }
        }

        //show movies for search term or selected title
        private void ComboBoxSelectedMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.movieSearchTableAdapter.FillByTitleSimilar(this.imdbcloneDataSet.movieSearch, comboBoxSelectedMovie.Text);

            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DisplayDirectors();
        }

        //method which detected ENTER keypress and executes search function
        private void ComboBoxSelectedMovie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchSelectedValue = comboBoxSelectedMovie.Text;
                try
                {
                    this.movieSearchTableAdapter.FillByTitleSimilar(this.imdbcloneDataSet.movieSearch, comboBoxSelectedMovie.Text);

                }
                catch (Exception ex)
                {
                    string errorMessage = myController.HandleAllExceptions(ex);
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DisplayDirectors();
            }
        }

        //remove selected director from a movie
        private void ButtonRemoveSelectedDirector_Click(object sender, EventArgs e)
        {
            //get selected actor and birthdate, movie title and movie year
            if (directedDataGridView.SelectedRows.Count > 0)
            {
                String selectedDirector = directedDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                DateTime selectedDirectorBirthdate = (DateTime)directedDataGridView.SelectedRows[0].Cells[1].Value;
                String selectedMovieTitle = movieSearchDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                int selectedMovieYear = (int)movieSearchDataGridView.SelectedRows[0].Cells[1].Value;

                try
                {
                    this.directedTableAdapter.Delete(selectedDirector, selectedDirectorBirthdate, selectedMovieTitle, selectedMovieYear);
                    this.directedTableAdapter.Update(this.imdbcloneDataSet);
                    DisplayDirectors();
                    MessageBox.Show("A director has been removed from selected movie.", "Changes saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    string errorMessage = myController.HandleAllExceptions(ex);
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("You must select a director first.");
            }
        }

        //display data for selected director
        private void MovieSearchDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DisplayDirectors();
        }



    }
}
