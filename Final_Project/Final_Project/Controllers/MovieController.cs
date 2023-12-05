using Final_Project.Interfaces;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class MovieController : ControllerBase
    {
        private readonly ILogger<MovieController> _logger;
        private readonly IMovieContextDAO _context;

        public MovieController(ILogger<MovieController> logger, IMovieContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.getMovie());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var movie = _context.getMovieById(id);

            if (movie == null)
            {
                return NotFound(); // 404 Not Found
            }

            return Ok(movie);
        }

        [HttpPost]
        public IActionResult Add(Movie movie)
        {
            var addedMovie = _context.AddMovie(movie);

            if (addedMovie == null)
            {
                return Conflict("Movie with the same name already exists."); // 409 Conflict
            }

            return CreatedAtAction(nameof(GetById), new { id = addedMovie.id }, addedMovie);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Movie updatedMovie)
        {
            var changedMovie = _context.UpdateMovie(id, updatedMovie);

            if (changedMovie == null)
            {
                return NotFound(); // 404 Not Found
            }

            return Ok(changedMovie);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deletedMovie = _context.DeleteMovie(id);

            if (deletedMovie == null)
            {
                return NotFound(); // 404 Not Found
            }

            return Ok(deletedMovie);

        }
    }
}
