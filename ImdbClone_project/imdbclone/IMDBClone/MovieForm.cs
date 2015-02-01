using System;
using System.Windows.Forms;
using DAL;

namespace IMDBCloneApplication
{
    public partial class MovieForm : Form
    {
        Controller myController = new Controller();
        DAL.Controller controller = new DAL.Controller();

        //default constructor
        public MovieForm()
        {
            InitializeComponent();
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.comboBoxSearchByTitle.DataSource = controller.GetAllMovies();
                this.comboBoxSearchByTitle.SelectedItem = null;

                this.dataGridViewMovies.DataSource = controller.GetAllMovies();
                this.dataGridViewMovies.Refresh();

                DisplayActorsAndGenre();
            }
            catch (Exception ex)
            {

                //TODO
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //show Add Movie form
        private void AdddeleteMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMovie myAddMovieFrame = new AddMovie(this);
            myAddMovieFrame.ShowDialog();
        }

        //method which reloads data for datagridviews

        public void RefreshForm()
        {
            try
            {
                this.comboBoxSearchByTitle.DataSource = controller.GetAllMovies();
                this.comboBoxSearchByTitle.Refresh();

                this.dataGridViewMovies.DataSource = controller.GetAllMovies();
                this.dataGridViewMovies.Refresh();

                DisplayActorsAndGenre();
            }
            catch (Exception ex)
            {
                //TODO
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //method to search by selected title in the combobox
        private void ComboBoxSearchByTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSearchByTitle.SelectedItem != null)
                {
                    if (!String.IsNullOrEmpty(comboBoxSearchByTitle.Text))
                    {
                        string searchSelectedValue = comboBoxSearchByTitle.Text;
                        this.dataGridViewMovies.DataSource = controller.GetMovieByTitle(searchSelectedValue);
                    }
                    else
                    {
                        this.comboBoxSearchByTitle.DataSource = controller.GetAllMovies();
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //method to execute search when user presses ENTER key and enters an incomplete search term thus executing LIKE SQL query
        private void ComboBoxSearchByTitle_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string searchSelectedValue = comboBoxSearchByTitle.Text;

                    this.dataGridViewMovies.DataSource = controller.GetMovieByTitle(searchSelectedValue);
                    DisplayActorsAndGenre();
                }
            }
            catch (Exception ex)
            {

                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //display related data after selection changes in gridview movies
        private void DataGridViewMovies_SelectionChanged(object sender, EventArgs e)
        {
            DisplayActorsAndGenre();
        }

        //show actors and genres for selected movie
        private void DisplayActorsAndGenre()
        {

            try
            {
                if (this.dataGridViewMovies.SelectedRows.Count > 0)
                {

                    Movie m = (Movie)this.dataGridViewMovies.SelectedRows[0].DataBoundItem;
                    this.titleTextBox.Text = m.title;
                    this.yearTextBox.Text = m.year.ToString();
                    this.descriptionTextBox.Text = m.description;
                    this.rankTextBox.Text = m.rank.ToString();


                    this.dataGridViewActors.DataSource = controller.GetAllActorsForMovie(m.title, m.year);
                    this.dataGridViewActors.ClearSelection();

                    this.dataGridViewGenre.DataSource = controller.GetAllGenresForMovie(m.title, m.year);
                    this.dataGridViewGenre.ClearSelection();
                }
                else
                {
                    imdbcloneDataSet.actorSearch.Clear(); //clear actorsearch datatable
                    imdbcloneDataSet.genreSearch.Clear(); //clear genresearch datatable
                }
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO Remove
        }
    }
}
