using Final_Project.Models;

namespace Final_Project.Interfaces
{
    public interface IMovieContextDAO
    {
        List<Movie> getMovie();
        Movie getMovieById(int id);
        Movie AddMovie(Movie movie);
        Movie UpdateMovie(int id, Movie updatedMovie);
        Movie DeleteMovie(int id);
    }

}

