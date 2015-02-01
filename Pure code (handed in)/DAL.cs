using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class DAL
    {
        public List<Audit> GetAuditData()
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    //Get All Audit
                    List<Audit> list = context.usp_GetAuditData().ToList();

                    Console.WriteLine(list.Count);

                    return list;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region Movie

        public List<Movie> GetAllMovies()
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    //Get All Movies

                    return context.usp_GetAllMovies().ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Movie GetMovieByTitleAndYear(string title, int year)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    return context.usp_GetMovieByTitleAndYear(title, year).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Movie> GetMovieByTitle(string title)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    //Get Movie by title

                    return context.usp_GetMovieByTitle(title).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<Movie> GetMoviesByGenre(string genre)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {//Get Movie by genre

                    return context.usp_GetMoviesByGenre(genre).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void DeleteMovie(Movie m)
        {
            try
            {
                using (var context = new imdbcloneEntities()) //Delete Movie 
                {
                    context.Movie.Attach(m);
                    context.Movie.Remove(m);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CreateMovie(Movie m)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    context.Movie.Add(m);

                    m.Actor.ToList().ForEach(a => context.Actor.Attach((a)));

                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateMovie(Movie m)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    context.Movie.Attach(m);

                    context.Entry(m).State = EntityState.Modified;

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddActorToMovie(Movie m, Actor a)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    context.usp_CreateActed(a.name, a.birthdate, m.title, m.year);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddDirectorToMovie(Movie m, Director d)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    context.usp_CreateDirected(d.name, d.birthdate, m.title, m.year);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Actor> GetAllActorsForMovie(string title, int year)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    return context.usp_GetAllActorsForMovie(title, year).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Genre> GetAllGenresForMovie(string title, int year)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    return context.usp_GetAllGenresForMovie(title, year).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Actor

        public List<Actor> GetAllActors()
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {

                    return context.usp_GetAllActors().ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Actor> GetActorsByName(string name)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    return context.usp_GetActorByName(name).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CreateActor(Actor a)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    context.Actor.Add(a);

                    a.Movie.ToList().ForEach(m => context.Movie.Add(m));

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateActor(Actor a)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    context.Actor.Attach(a);

                    context.Entry(a).State = EntityState.Modified;

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Actor GetActorsByNameAndBirthDate(string name, DateTime dt)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    return context.usp_GetActorByNameAndBirthdate(name, dt).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Movie> GetAllMoviesForActor(string name, DateTime birthDate)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    return context.usp_GetAllMoviesForActor(name, birthDate).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void DeleteActor(Actor a)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    context.Actor.Attach(a);
                    context.Actor.Remove(a);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        #endregion

        #region Director

        public List<Director> GetAllDirectors()
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {//Get All Directors
                    return context.usp_GetAllDirectors().ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Movie> GetAllMoviesForDirector(Director d)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    return context.usp_GetAllMoviesForDirector(d.name, d.birthdate).ToList();
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public List<Director> GetDirectorByName(string name)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    //Get Directors by name
                    return context.usp_GetDirectorByName(name).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteDirector(Director d)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {

                    context.Director.Attach(d);
                    context.Director.Remove(d);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CreateDirector(Director d)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    context.Director.Add(d);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateDirector(Director d)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    context.Director.Attach(d);

                    context.Entry(d).State = EntityState.Modified;

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Director GetDirectorByNameAndBirthDate(Director d)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    return context.usp_GetDirectorByNameAndBirthdate(d.name, d.birthdate).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
        #region Genre

        public List<Genre> GetAllGenres()
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    return context.usp_GetAllGenres().ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void DeleteGenre(Genre g)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    context.Genre.Attach(g);
                    context.Genre.Remove(g);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CreateGenre(Genre g)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    context.Genre.Add(g);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Movie> GetAllMoviesByGenre(string g)
        {
            try
            {
                using (var context = new imdbcloneEntities())
                {
                    List<Movie> list = context.usp_GetAllMoviesByGenre(g).ToList();
                    return list;
                }
            }

            catch (Exception)
            {
                throw;
            }
        }


        #endregion Genre

    }
}



