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
                new Student { id = 1, fName = "Kozimjon", lName = "Kuchkorov", birthdate = new DateOnly(2002, 02, 27), college_program = "Information Technology", year_in_program = "pre-junior" }
              );
        }

        public DbSet<Student> Students { get; set; }
    }
}
