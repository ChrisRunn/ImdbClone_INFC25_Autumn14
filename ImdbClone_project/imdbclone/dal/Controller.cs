using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Controller
    {
        DAL _dal = new DAL();

        #region Actor
        public List<Actor> GetAllActors()
        {
            return _dal.GetAllActors();
        }

        public List<Actor> GetActorsByName(string name)
        {
            return _dal.GetActorsByName(name);
        }

        public void CreateActor(Actor a)
        {
            _dal.CreateActor(a);
        }
        
        public void UpdateActor(Actor a)
        {
            _dal.UpdateActor(a);
        }

        public Actor GetActorsByNameAndBirthDate(string name, DateTime dt)
        {
            return _dal.GetActorsByNameAndBirthDate(name, dt);
        }

       
         
        
         public void DeleteActor(Actor a)
        {
            _dal.DeleteActor(a);
        }

        public List<Movie> GetAllMoviesForActor(string name, DateTime birthDate)
        {
            return _dal.GetAllMoviesForActor(name, birthDate);
        }


        #endregion
        #region Director
        public List<Director> GetAllDirectors()
        {
            return _dal.GetAllDirectors();
        }

        public List<Director> GetDirectorByName(string name)
        {
            return _dal.GetDirectorByName(name);
        }

        public void CreateDirector(Director d)
        {
            _dal.CreateDirector(d);
        }

        public void DeleteDirector(Director d)
        {
            _dal.DeleteDirector(d);
        }
        
        
        /*
        public void UpdateDirector(Director d)
        {
            _dal.UpdateDirector(d);
        }
        
        public List <Movie> GetAllMoviesForDirector(DateTime birthDate, string name)
        {
            return _dal.GetAllMoviesForDirector(birthDate, name);
        }
        
        
         */

        #endregion
        #region Movie

        public List<Movie> GetAllMovies()
        {
            return _dal.GetAllMovies();
        }

        public List<Movie> GetMoviesByGenre(string genre)
        {
            return _dal.GetMoviesByGenre(genre);
        }

        public List<Movie> GetMovieByTitle(string title)
        {
            return _dal.GetMovieByTitle(title);
        }

        public void CreateMovie(Movie m)
        {
            _dal.CreateMovie(m);
        }

        public void UpdateMovie(Movie m)
        {
            _dal.UpdateMovie(m);
        }

        public Movie GetMovieByTitleAndYear(string title, int year)
        {
            return _dal.GetMovieByTitleAndYear(title, year);
        }
        /*
        public void CreateMovieGenre(Genre g, Movie m)
        {
            _dal.CreateMovieGenre(g, m);
        }
        */

        public List<Actor> GetAllActorsForMovie(string title, int year)
        {
            return _dal.GetAllActorsForMovie(title, year);
        }

        public List<Genre> GetAllGenresForMovie(string title, int year)
        {
            return _dal.GetAllGenresForMovie(title, year);
        }

        public void DeleteMovie(Movie m)
        {
            _dal.DeleteMovie(m);
        }

        public void AddDirectorToMovie(Movie m, Director d)
        {
            _dal.AddDirectorToMovie(m, d);
        }

        public void AddActorToMovie(Movie m, Actor a)
        {
            _dal.AddActorToMovie(m, a);
        }
        


        #endregion
        #region Genre
        public List<Genre> GetAllGenres()
        {
            return _dal.GetAllGenres();
        }

        public void CreateGenre(Genre g)
        {
            _dal.CreateGenre(g);
        }

        public void DeleteGenre(Genre g)
        {
            _dal.DeleteGenre(g);
        }

        #endregion

        /*

        public void CreateActed(Actor a, Movie m)
        {
            _dal.CreateActed(a, m);
        }

        public void CreateDirected(Director d, Movie m)
        {
            _dal.CreateDirected(d, m);
        }

        public void DeleteActed(Actor a, Movie m)
        {
            _dal.DeleteActed(a, m);
        }

        public void DeleteDirected(Director d, Movie m)
        {
            _dal.DeleteDirected(d, m);
        }


        public List<Acted> GetActedByNameOrTitle(string searchString)
        {
            return _dal.GetActedByNameOrTitle(searchString);
        }

        public List<Director> GetDirectedByNameOrTitle(string searchString)
        {
            return _dal.GetDirectedByNameOrTitle(searchString);
        }


        // Vad har vi denna för?
        public void DeleteMovieByGenre(Genre g)
        {
            _dal.DeleteMovieByGenre(g);
        }

        // BEHÖVS DENNA?
        public List<Genre> GetMovieGenreByGenreOrTitle(string searchString)
        {
            return _dal.GetMovieGenreByGenreOrTitle(searchString);
        }
        // Behöver vi denna?
        public List<Acted> GetActedByNÅGONTING(string name)
        {
            return _dal.GetActedByName(name);
        } 
*/
    }
}
