using Final_Project.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class HobbiesController : ControllerBase
    {
        private readonly ILogger<HobbiesController> _logger;
        private readonly IHobbyContextDAO _context;

        public HobbiesController(ILogger<HobbiesController> logger, IHobbyContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.GetHobbies());
        }

    }
}
