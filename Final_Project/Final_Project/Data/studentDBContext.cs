using Final_Project.Models;
using Microsoft.EntityFrameworkCore;





namespace Final_Project.Data
{
    public class studentDBContext : DbContext
    {

        //constructor for context
        public studentDBContext(DbContextOptions<studentDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>().HasData(
                new Student {id= 1, fName = "Andrew", lName = "Schwirzinski", birthdate = new DateOnly(1980,07,19), college_program = "Information Technology", year_in_program = "junior" },
                new Student { id = 2, fName = "Kozimjon", lName = "Kuchkorov", birthdate = new DateOnly(2002, 02, 27), college_program = "Information Technology", year_in_program = "pre-junior" },
                new Student { id = 3, fName = "Ji'Yahna", lName = "Meade", birthdate=new DateOnly(2004, 09, 17), college_program = "Information Technology", year_in_program = "Junior"},
                new Student { id = 4, fName = "Abdoul", lName = "Sow", birthdate=new DateOnly(2003, 04, 06), college_program = "Information Technology", year_in_program = "Junior"}

              );

            builder.Entity<FavoriteFood>().HasData(
                new FavoriteFood { Id = 1, Name = "Tacos", Cuisine = "Mexican", Description = "Grilled meat and veggies in a flour shell", CreatedAt = DateTime.Now },
                new FavoriteFood { Id = 2, Name = "French Fries", Cuisine = "French", Description = "Delicious form of cut potatos", CreatedAt = DateTime.Now },
                new FavoriteFood { Id = 4, Name = "Chicken Alfredo", Cuisine = "Italian", Description = "Pasta + chicken = bussin", CreatedAt = DateTime.Now }
            

        );

            builder.Entity<Hobby>().HasData(
<<<<<<< HEAD
            new Hobby { Id = 1, Name = "Working out", Description = "Staying fit ", CreatedAt = DateTime.Now },
            new Hobby { Id = 2, Name = "Art", Description = "Enjoying the way imagination runs wild", CreatedAt = DateTime.Now }
=======
             new Hobby { Id = 1, CreatedAt =DateTime.Now,  Name = "Working out", Description = "Staying fit " },
            new Hobby { Id = 2,  CreatedAt= DateTime.Now, Name = "Art", Description = "Enjoying the way imagination runs wild" }
>>>>>>> 15824e446cd2d7b6183870406b7457442e585737

    );

        }

        public DbSet<Student> Students { get; set; }
<<<<<<< HEAD
        public DbSet<Hobby> Hobby { get; set; }
=======
       public DbSet<Hobby> Hobbies { get; set; }
>>>>>>> 15824e446cd2d7b6183870406b7457442e585737
        public DbSet<FavoriteFood> FavoriteFood { get; set; }
    }
}
