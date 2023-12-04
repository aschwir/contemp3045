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
}
}