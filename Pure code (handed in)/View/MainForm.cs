using System;
using System.ComponentModel;
using System.Windows.Forms;
using DAL;

namespace IMDBCloneApplication
{
    public partial class MainForm : Form
    {
        private DAL.Controller controller = new DAL.Controller();
        public MainForm()
        {
            InitializeComponent();
        }

        //show movies form
        private void MovieFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieForm myMovieForm = new MovieForm();
            myMovieForm.ShowDialog();
        }

        //show directors form
        private void DirectorFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectorForm myDirectorForm = new DirectorForm();
            myDirectorForm.ShowDialog();
        }

        //show actors form
        private void ActorFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActorForm myActorForm = new ActorForm();
            myActorForm.ShowDialog();
        }        

        //show genres form
        private void GenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genre myGenreForm = new Genre();
            myGenreForm.ShowDialog();
        }

        //show about dialog
        private void AboutIMDBCloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grupp ## är: Sebastian Glad, Anton Hollerup, Daniel Lindén & Christian Runnström");
        }

        //exit application
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //generic MouseLeave event
        private void ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Welcome. Please make a selection in the File menu.";
        }

        //generic MouseEnter event
        private void ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            switch (sender.ToString())
            {
                case "Movies":
                    toolStripStatusLabel.Text = "Show Movie Search Window.";
                    break;
                case "Directors":
                    toolStripStatusLabel.Text = "Show Director Search Window.";
                    break;
                case "Actors":
                    toolStripStatusLabel.Text = "Show Actor Search Window.";
                    break;
                case "Genre":
                    toolStripStatusLabel.Text = "Show Genre Search Window.";
                    break;
                case "Exit":
                    toolStripStatusLabel.Text = "Close this application.";
                    break;
                default:
                    break;
            }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imdbcloneDataSet11.Audit' table. You can move, or remove it, as needed.
            //this.auditTableAdapter.Fill(this.imdbcloneDataSet11.Audit);
            RefreshAuditDGV();


        }

        public void RefreshAuditDGV()
        {



           BindingList<Audit> blist = new BindingList<Audit>(controller.GetAuditData());
            
            dgvAudit2.DataSource = blist;
           
            dgvAudit2.Update();
            dgvAudit2.Refresh();
        }
    }
}
