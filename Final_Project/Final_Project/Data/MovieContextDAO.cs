using Final_Project.Interfaces;
using Final_Project.Models;

namespace Final_Project.Data
{
    public class MovieContextDAO : IMovieContextDAO
    {
        private studentDBContext _context;

        public MovieContextDAO(studentDBContext context)
        {
            _context = context;
        }

        public List<Movie> getMovie()
     { 
        return _context.Movie.ToList();
     }

        public Movie getMovieById(int id)
        {
            return _context.Movie.Find(id);
        }

        public Movie AddMovie(Movie movie)
        {
            _context.Movie.Add(movie);
            _context.SaveChanges();
            return movie;
        }

        public Movie UpdateMovie(int id, Movie updatedMovie)
        {
            var existingMovie = _context.Movie.Find(id);

            if (existingMovie != null)
            {
                existingMovie.Title = updatedMovie.Title;
                existingMovie.Plot = updatedMovie.Plot;
                existingMovie.DateCreated = updatedMovie.DateCreated;

                _context.Movie.Update(existingMovie);
                _context.SaveChanges();
            }

            return existingMovie;
        }
        public Movie DeleteMovie(int id)
        {
            var movie = _context.Movie.Find(id);
            if (movie != null)
            {
                _context.Movie.Remove(movie);
                _context.SaveChanges();
            }
            return movie;
        }
    }
}