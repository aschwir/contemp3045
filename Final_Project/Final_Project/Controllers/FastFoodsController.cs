using Microsoft.AspNetCore.Mvc;
using Final_Project.Interfaces;
using Final_Project.Models;
using Microsoft.Extensions.Logging;
using System;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FastFoodsController : ControllerBase
    {
        private readonly ILogger<FastFoodsController> _logger;
        private readonly IFastFoodContextDAO _context;

        public FastFoodsController(ILogger<FastFoodsController> logger, IFastFoodContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.getAllFavoriteFoods());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var food = _context.getFavoriteFoodById(id);

            if (food == null)
            {
                return NotFound(); // 404 Not Found
            }

            return Ok(food);
        }

        [HttpPost]
        public IActionResult Add(FavoriteFood food)
        {
            var addedFood = _context.AddFavoriteFood(food);

            if (addedFood == null)
            {
                return Conflict("Food with the same name already exists."); // 409 Conflict
            }

            return CreatedAtAction(nameof(GetById), new { id = addedFood.Id }, addedFood);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, FavoriteFood updatedFood)
        {
            var food = _context.UpdateFavoriteFood(id, updatedFood);

            if (food == null)
            {
                return NotFound(); // 404 Not Found
            }

            return Ok(food);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var food = _context.DeleteFavoriteFood(id);

            if (food == null)
            {
                return NotFound(); // 404 Not Found
            }

            return Ok(food);
        }
    }
}
