using System;
using System.Collections.Generic;

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
        
        public List<Movie> GetAllMoviesForDirector(Director d)
        {
            return _dal.GetAllMoviesForDirector(d);
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

        public void UpdateDirector(Director d)
        {
            _dal.UpdateDirector(d);
        }

        public Director GetDirectorByNameAndBirthDate(Director d)
        {
            return _dal.GetDirectorByNameAndBirthDate(d);
        }

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

        public List<Audit> GetAuditData()
        {
            return _dal.GetAuditData();
        }

        public List<Movie> GetAllMoviesByGenre(string g)
        {
            return _dal.GetAllMoviesByGenre(g);
        }
    }
}
