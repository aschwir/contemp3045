using Final_Project.Interfaces;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

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
            try
            {
                var hobbies = _context.GetHobbies();
                return Ok(hobbies);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error retrieving hobbies: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var hobby = _context.GethobbyById(id);

                if (hobby == null)
                {
                    return NotFound("Hobby not found");
                }

                return Ok(hobby);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error retrieving hobby by ID: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] Hobby hobby)
        {
            try
            {
                var createdHobby = _context.AddHobby(hobby);
                return CreatedAtAction(nameof(GetById), new { id = createdHobby.Id }, createdHobby);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error creating hobby: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Hobby updatedHobby)
        {
            try
            {
                var modifiedHobby = _context.UpdateHobby(id, updatedHobby);
                return Ok(modifiedHobby);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error updating hobby: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var deletedHobby = _context.DeleteHobby(id);

                if (deletedHobby == null)
                {
                    return NotFound("Hobby not found");
                }

                return Ok(deletedHobby);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error deleting hobby: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
