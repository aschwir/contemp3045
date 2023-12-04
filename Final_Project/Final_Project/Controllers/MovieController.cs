using Final_Project.Interfaces;
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

    }
}
