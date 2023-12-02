using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HobbiesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public HobbiesController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetHobbies(int? id)
        {
            var query = _context.Hobbies.AsQueryable();

            if (id != null && id > 0)
            {
                var hobby = query.FirstOrDefault(h => h.id == id);
                return Ok(hobby);
            }
            else
            {
                var hobbies = query.Take(5).ToList();
                return Ok(hobbies);
            }
        }
        [HttpPost]
        public IActionResult CreateHobby([FromBody] Hobby hobby)
        {
            if (hobby == null)
            {
                return BadRequest("Hobby object is null");
            }

            _context.Hobbies.Add(hobby);
            _context.SaveChanges();

            return CreatedAtRoute(nameof(GetHobbies), new { id = hobby.id }, hobby);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateHobby(int id, [FromBody] Hobby hobby)
        {
            if (hobby == null || id != hobby.id)
            {
                return BadRequest("Invalid request");
            }

            var existingHobby = _context.Hobbies.Find(id);

            if (existingHobby == null)
            {
                return NotFound("Hobby not found");
            }

            existingHobby.Name = hobby.Name;
            existingHobby.Description = hobby.Description;

            _context.SaveChanges();

            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteHobby(int id)
        {
            var hobby = _context.Hobbies.Find(id);
            if (hobby == null)
            {
                return NotFound("Hobby not Found");
            }

            _context.Hobbies.Remove(hobby);
            _context.SaveChanges();

            return NoContent();
        }





    }


}
