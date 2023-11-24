using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Versioning;


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
                new Student {id= 1, fName = "Andrew", lName = "Schwirzinski", birthdate = new DateTime(1980 / 07 / 19), college_program = "Information Technology", year_in_program = "junior" }
              );
        }

        public DbSet<Student> Students { get; set; }
    }
}
