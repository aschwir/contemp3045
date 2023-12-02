using Final_Project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Final_Project.Data;
using Final_Project.Models;
using System.Collections.Generic;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteFoodsController : ControllerBase
    {
        private readonly AppDBContext _Context;

        public FavoriteFoodsController(AppDBContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public IActionResult GetFavoriteFoods(int? id)
        {
            var query = _Context.FavoriteFood.AsQueryable();

            if (id != null && id > 0)
            {
                var favoritefood = query.FirstOrDefault(ff => ff.Id == id);
                return Ok(favoritefood);
            }
            else
            {
                var FavoriteFoods = query.Take(5).ToList();
                return Ok(FavoriteFoods);
            }

        }

        [HttpPost]
        public IActionResult CreateFavoriteFood([FromBody] FavoriteFood favoriteFood)
        {
            if (favoriteFood == null)
            {
                return BadRequest("FavoriteFood object is null");
            }

            _Context.FavoriteFood.Add(favoriteFood);
            _Context.SaveChanges();

            return CreatedAtRoute(nameof(GetFavoriteFoods), new { id = favoriteFood.Id }, favoriteFood);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFavoriteFood(int id, [FromBody] FavoriteFood favoriteFood)
        {
            if (favoriteFood == null || id != favoriteFood.Id)
            {
                return BadRequest("Invalid request");
            }
            var existingFavoriteFood = _Context.FavoriteFood.Find(id);
            if (existingFavoriteFood == null)
            {
                return NotFound("FavoriteFood is not Found");
            }

            existingFavoriteFood.Name = favoriteFood.Name;
            existingFavoriteFood.Cuisine = favoriteFood.Cuisine;
            existingFavoriteFood.Description = favoriteFood.Description;

            _Context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFavoriteFood(int id)
        {
            var favoriteFood = _Context.FavoriteFood.Find(id);
            if (favoriteFood == null)
            {
                return NotFound("FavoriteFood not found");
            }

            _Context.FavoriteFood.Remove(favoriteFood);
            _Context.SaveChanges();

            return NoContent();
        }


    }





}
