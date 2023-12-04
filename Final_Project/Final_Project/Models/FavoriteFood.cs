using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<FavoriteFood> FavoriteFoods { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    if (!optionsBuilder.IsConfigured)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlServer"));
    }
}

    public class FavoriteFood
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cuisine { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class FavoriteFoodService
    {
        private readonly ApplicationDbContext _context;

        public FavoriteFoodService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Create
        public void AddFavoriteFood(FavoriteFood favoriteFood)
        {
            favoriteFood.CreatedAt = DateTime.Now;
            _context.FavoriteFoods.Add(favoriteFood);
            _context.SaveChanges();
        }

        // Read
        public List<FavoriteFood> GetFavoriteFoods()
        {
            return _context.FavoriteFoods.ToList();
        }

        // Update
        public void UpdateFavoriteFood(FavoriteFood favoriteFood)
        {
            var existingFood = _context.FavoriteFoods.Find(favoriteFood.Id);
            if (existingFood != null)
            {
                existingFood.Name = favoriteFood.Name;
                existingFood.Cuisine = favoriteFood.Cuisine;
                existingFood.Description = favoriteFood.Description;

                _context.SaveChanges();
            }
        }

        // Delete
        public void DeleteFavoriteFood(int id)
        {
            var favoriteFood = _context.FavoriteFoods.Find(id);
            if (favoriteFood != null)
            {
                _context.FavoriteFoods.Remove(favoriteFood);
                _context.SaveChanges();
            }
        }
    }
}
