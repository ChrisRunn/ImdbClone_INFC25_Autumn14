using System;
using System.Windows.Forms;

namespace IMDBCloneApplication
{
    public partial class AddMoviesToGenres : Form
    {
        Controller myController = new Controller();
        public AddMoviesToGenres()
        {
            InitializeComponent();
        }

        //load tableadapters
        private void AddMoviesToGenres_Load(object sender, EventArgs e)
        {
            try
            {
                this.genreSearchTableAdapter.Fill(this.imdbcloneDataSet.genreSearch);
                this.movieSearchTableAdapter.Fill(this.imdbcloneDataSet.movieSearch);
                this.moviegenreTableAdapter.Fill(this.imdbcloneDataSet.moviegenre);
                this.movieTableAdapter.Fill(this.imdbcloneDataSet.movie);
                this.genreTableAdapter.Fill(this.imdbcloneDataSet.genre);
                DisplayMovies();
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //show movies associated in selected genre by title and year if a movie result is found   TODO!
        private void DisplayMovies()
        {
            if (this.dataGridViewGenreSearch.SelectedRows.Count > 0)
            {
                try
                {
                    String selectedGenreName = dataGridViewGenreSearch.SelectedRows[0].Cells[0].Value.ToString();
                    this.movieSearchTableAdapter.FillByGenre(this.imdbcloneDataSet.movieSearch, selectedGenreName);
                }
                catch (Exception ex)
                {
                    string errorMessage = myController.HandleAllExceptions(ex);
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                imdbcloneDataSet.moviegenre.Clear(); //clear acted datatable
            }

        }

        //add selected movie to moviegenres table
        private void ButtonAddSlectedMovies_Click(object sender, EventArgs e)
        {

            if (moviesDataGridView.SelectedRows.Count > 0 && dataGridViewGenreSearch.SelectedRows.Count > 0)
            {
                String selectedGenre = dataGridViewGenreSearch.SelectedRows[0].Cells[0].Value.ToString();
                String selectedMovieTitle = moviesDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                int selectedMovieYear = (int)moviesDataGridView.SelectedRows[0].Cells[1].Value;

                try
                {
                    this.moviegenreTableAdapter.Insert(selectedGenre, selectedMovieTitle, selectedMovieYear);
                    this.moviegenreTableAdapter.Update(this.imdbcloneDataSet);
                    DisplayMovies();
                    MessageBox.Show("An movie has been added to the selected genre.", "Changes saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    string errorMessage = myController.HandleAllExceptions(ex);
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You must select a movie and genre first.");
            }
        }

        //remove selected movie from genres
        private void ButtonRemoveSelectedMovies_Click(object sender, EventArgs e)
        {
            if (dataGridViewMovieGenre.SelectedRows.Count > 0)
            {
                String selectedGenre = dataGridViewGenreSearch.SelectedRows[0].Cells[0].Value.ToString();
                String selectedMovieTitle = dataGridViewMovieGenre.SelectedRows[0].Cells[0].Value.ToString();
                int selectedMovieYear = (int)dataGridViewMovieGenre.SelectedRows[0].Cells[1].Value;

                try
                {
                    this.moviegenreTableAdapter.Delete(selectedGenre, selectedMovieTitle, selectedMovieYear);
                    this.moviegenreTableAdapter.Update(this.imdbcloneDataSet);
                    DisplayMovies();
                    MessageBox.Show("A movie has been removed from selected genre.", "Changes saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //show data for selected genre
        private void DataGridViewGenreSearch_SelectionChanged(object sender, EventArgs e)
        {
            DisplayMovies();
        }
    }
}
