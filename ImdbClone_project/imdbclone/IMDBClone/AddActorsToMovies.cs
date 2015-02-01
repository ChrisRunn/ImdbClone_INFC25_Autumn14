using System;
using System.Windows.Forms;
using DAL;

namespace IMDBCloneApplication
{
    public partial class AddActorsToMovies : Form
    {
        DAL.Controller controller = new DAL.Controller();
        Controller myController = new Controller();
        public AddActorsToMovies()
        {
            InitializeComponent();
            

        }

        private void AddActorsToMovies_Load(object sender, EventArgs e)
        {
            try
            {
                this.movieSearchDataGridView.DataSource = controller.GetAllMovies();
                this.movieSearchDataGridView.Refresh();

                this.actorDataGridView.DataSource = controller.GetAllActors();
                this.actorDataGridView.Refresh();
                DisplayActors();
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //add selected actor(s) to acted table
        private void ButtonAddSelectedActors_Click(object sender, EventArgs e)
        {

            //get selected actor and birthdate, movie title and movie year
            if (actorDataGridView.SelectedRows.Count > 0 && this.movieSearchDataGridView.SelectedRows.Count > 0)
            {


                Movie m = ConvertToMovie();
                Actor a = ConvertToActor();
             

                try
                {
                    controller.AddActorToMovie(m, a);
                    DisplayActors();
                    MessageBox.Show("An actor has been added to the selected movie.", "Changes saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DisplayActors();
        }

        //show actors acted in selected movie by title and year if a movie result is found
        private void DisplayActors()
        {
            if (this.movieSearchDataGridView.SelectedRows.Count > 0)
            {
                try
                {
                   // String selectedMovieTitle = movieSearchDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                 //   int selectedMovieYear = (int)movieSearchDataGridView.SelectedRows[0].Cells[1].Value;

                    Movie m = ConvertToMovie();

                    this.dataGridViewActed.DataSource = controller.GetAllActorsForMovie(m.title,
                        m.year);
                }
                catch (Exception ex)
                {
                    string errorMessage = myController.HandleAllExceptions(ex);
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                imdbcloneDataSet.acted.Clear(); //clear acted datatable
            }
        }

        //method which detected ENTER keypress and executes search function
        private void ComboBoxSelectedMovie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchSelectedValue = comboBoxSelectedMovie.Text;
                try
                {
                    this.movieSearchDataGridView.DataSource = controller.GetMovieByTitle(searchSelectedValue);
                    this.movieSearchDataGridView.Refresh();
                }
                catch (Exception ex)
                {
                    string errorMessage = myController.HandleAllExceptions(ex);
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DisplayActors();
            }
        }

        //remove selected actor from ACTED table
        private void ButtonRemove_Click(object sender, EventArgs e)
        {

            //get selected actor and birthdate, movie title and movie year
            if (dataGridViewActed.SelectedRows.Count > 0)
            {

                Actor a = new Actor()
                {
                    name = dataGridViewActed.SelectedRows[0].Cells[0].Value.ToString(),
                    birthdate = (DateTime) dataGridViewActed.SelectedRows[0].Cells[0].Value
                };
                Movie m = ConvertToMovie();

                try
                {
                    controller.UpdateMovie(m);
                    DisplayActors();
                    MessageBox.Show("An actor has been removed from selected movie.", "Changes saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    string errorMessage = myController.HandleAllExceptions(ex);
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You must select an actor first.");
            }
        }
        //shows actors for selected movie
        private void MovieSearchDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DisplayActors();
        }

        private void movieSearchDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO TA BORT
        }

        private Actor ConvertToActor()
        {
            Actor a = new Actor()
            {
                name = actorDataGridView.SelectedRows[0].Cells[0].Value.ToString(),
                birthdate = (DateTime)actorDataGridView.SelectedRows[0].Cells[1].Value
            };
            return a;
        }

        private Movie ConvertToMovie()
        { 
            Movie m = new Movie()
            {
                title = movieSearchDataGridView.SelectedRows[0].Cells[0].Value.ToString(),
                year = (int)movieSearchDataGridView.SelectedRows[0].Cells[1].Value
            };
            return m;
        }

    }
}
