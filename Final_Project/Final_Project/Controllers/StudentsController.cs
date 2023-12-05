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
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            try
            {
                var student = _context.GetStudentById(id);

                if (student == null)
                {
                    return NotFound("Student not found");
                }

                return Ok(student);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error retrieving student by ID: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] Student student)
        {
            try
            {
                var createdStudentId = _context.AddStudent(student);

                if (createdStudentId == -1)
                {
                    return BadRequest("Student with the same name already exists");
                }

                return CreatedAtAction(nameof(GetStudentById), new { id = createdStudentId }, student);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error creating student: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] Student updatedStudent)
        {
            try
            {
                var result = _context.UpdateStudent(id, updatedStudent);

                if (result == -1)
                {
                    return NotFound("Student not found");
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error updating student: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                var result = _context.RemoveStudentById(id);

                if (result == -1)
                {
                    return NotFound("Student not found");
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error deleting student: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
