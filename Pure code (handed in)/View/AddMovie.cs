using System;
using System.Windows.Forms;
using DAL;

namespace IMDBCloneApplication
{
    public partial class AddMovie : Form
    {
        Controller myController = new Controller();
        DAL.Controller controller = new DAL.Controller();
        private MovieForm mainForm = null;

        public AddMovie(Form myCallingForm)
        {
            mainForm = myCallingForm as MovieForm;
            InitializeComponent();
        }


        //Button for saving changes
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                controller.UpdateMovie(ConvertToMovie());
                mainForm.RefreshForm();
            }
            catch (Exception ex)
            {
                //TODO
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Button for deleting selected movie from movie table
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you really want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    controller.DeleteMovie(ConvertToMovie());
                    mainForm.RefreshForm();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        //Creates new row in movie table
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                controller.CreateMovie(ConvertToMovie());
                mainForm.RefreshForm();
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //notify MovieForm that data has changed
        private void AddMovie_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.RefreshForm();
        }

        //check input, allow only integers
        private void YearTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int.Parse(yearTextBox.Text);
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //check input, allow only integers
        private void RankTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int.Parse(rankTextBox.Text);
            }
            catch (Exception ex)
            {
                string errorMessage = myController.HandleAllExceptions(ex);
                Console.WriteLine(errorMessage);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Movie ConvertToMovie()
        {
            Movie m = new Movie()
            {
                title = this.titleTextBox.Text,
                year = int.Parse(this.yearTextBox.Text)
            };

            if (!String.IsNullOrEmpty(this.descriptionTextBox.Text))
            {
                m.description = this.descriptionTextBox.Text;
            }
            else
            {
                m.description = null;
            }
            if (!String.IsNullOrEmpty(this.rankTextBox.Text))
            {
                m.rank = int.Parse(this.rankTextBox.Text);
            }
            else
            {
                m.rank = null;
            }
            return m;
        }

        private void MovieToTextBox(Movie m)
        {
            titleTextBox.Text = m.title;
            yearTextBox.Text = m.year.ToString();
            descriptionTextBox.Text = m.description;
            rankTextBox.Text = m.rank.ToString();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(this.yearTextBox.Text);

                if (!String.IsNullOrEmpty(this.titleTextBox.Text))
                {
                    MovieToTextBox(controller.GetMovieByTitleAndYear(this.titleTextBox.Text, year));
                }
                else
                {
                    MessageBox.Show("Felaktigt värde i fältet för titel eller år.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
