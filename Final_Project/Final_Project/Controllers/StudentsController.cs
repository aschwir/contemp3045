using Microsoft.AspNetCore.Mvc;
using Final_Project.Interfaces;
using Final_Project.Models;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class StudentsController : ControllerBase
    {
        private readonly ILogger<StudentsController> _logger;
        private readonly IStudentsContextDAO _context;

        public StudentsController(ILogger<StudentsController> logger, IStudentsContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
           return Ok(_context.GetAllStudents());
        }
    }
}
