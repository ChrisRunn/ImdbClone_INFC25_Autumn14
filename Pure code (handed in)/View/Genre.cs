using System;
using System.Windows.Forms;

namespace IMDBCloneApplication
{
    public partial class Genre : Form
    {

        Controller myController = new Controller();
        private DAL.Controller controller = new DAL.Controller();
        private ActorForm mainForm = null;

        public Genre()
        {
            InitializeComponent();
        }

        private void Genre_Load(object sender, EventArgs e)
        {
            try
            {

                this.dataGridViewGenres.DataSource = controller.GetAllGenres();
                this.dataGridViewGenres.Refresh();
                DisplayGenreInfo();
    
            }
            catch (Exception ex)
            {
                //TODO
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //show movies by selected genre, if at least 1 genre is selected
        private void DataGridViewGenres_SelectionChanged(object sender, EventArgs e)
        {
            DisplayGenreInfo();
        }
        //Refresh table adapters
        public void RefreshForm()
        {
            try
            {
                this.dataGridViewGenres.DataSource = controller.GetAllGenres();
                this.dataGridViewGenres.Refresh();
                DisplayGenreInfo();
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

        private void DisplayGenreInfo()
        {
            try
            {
                
               

                    Genre g = (Genre) this.dataGridViewGenres.SelectedRows[0].DataBoundItem;
                  
                    this.dataGridViewMoviesByGenre.DataSource = controller.GetAllMoviesByGenre(g.Name);
                    this.dataGridViewMoviesByGenre.ClearSelection();
               
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewMoviesByGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
