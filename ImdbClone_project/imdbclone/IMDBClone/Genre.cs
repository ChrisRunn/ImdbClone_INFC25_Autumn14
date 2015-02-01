using System;
using System.Windows.Forms;

namespace IMDBCloneApplication
{
    public partial class Genre : Form
    {
        Controller myController = new Controller();

        public Genre()
        {
            InitializeComponent();
        }

        private void Genre_Load(object sender, EventArgs e)
        {
            try
            {
                this.movieSearchTableAdapter.Fill(this.imdbcloneDataSet.movieSearch);
                this.movieTableAdapter.Fill(this.imdbcloneDataSet.movie);
                this.genreTableAdapter.Fill(this.imdbcloneDataSet.genre);
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //show movies by selected genre, if at least 1 genre is selected
        private void DataGridViewGenres_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewGenres.SelectedCells.Count > 0)
            {
                try
                {
                    this.movieSearchTableAdapter.FillByGenre(this.imdbcloneDataSet.movieSearch, this.dataGridViewGenres.SelectedCells[0].Value.ToString());
                }
                catch (Exception ex)
                {
                    string errorMessage = myController.HandleAllExceptions(ex);
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //Refresh table adapters
        public void RefreshForm()
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

        //Opens add genre form
        private void AddRemoveOrEditGenresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGenre myAddGenreForm = new AddGenre(this);
            myAddGenreForm.ShowDialog();
        }

        //Opens add remove movie form
        private void AddremoveMoviesTofromGenresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMoviesToGenres myAddMoviesToGenres = new AddMoviesToGenres();
            myAddMoviesToGenres.ShowDialog();
        }
    }
}
