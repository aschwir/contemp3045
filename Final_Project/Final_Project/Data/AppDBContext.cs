using Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<FavoriteFood> FavoriteFood { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder builder)
        {




            builder.Entity<Hobby>().HasData(
                new Hobby { id = 2, Name = "Art", Description = "Enjoying the way imagination runs wild", CreatedAt = DateTime.Now }

            );

            builder.Entity<FavoriteFood>().HasData(
                new FavoriteFood { Id = 2, Name = "French Fries", Cuisine = "French", Description = "Delicious form of cut potatos", CreatedAt = DateTime.Now }

            );
        }

    }
}
