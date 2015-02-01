using System;
using System.Windows.Forms;
using DAL;
using System.Collections.Generic;
using System.Linq;

namespace IMDBCloneApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {




            DAL.Controller c = new DAL.Controller();
            /*
            Movie m = c.GetMovieByTitleAndYear("ABC", 2014);

           
            


            m.Actor = c.GetAllActors().ToList();
          

            c.UpdateMovie(m);

            */

            /*
            Actor b = c.GetActorsByName("HEJ").FirstOrDefault();

            List<Movie> list = c.GetMovieByTitle("The Lord of the Rings").ToList();

            list.ForEach(x => Console.WriteLine(x.title));
            list.ForEach(x => x.Actor.Add(b));

            b.Movie = list;
            b.biography = "Deta funkar kanske";

            c.UpdateActor(b);

            Console.WriteLine("End");
            Console.ReadLine();
            */
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            

        }
    }
}
