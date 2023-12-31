﻿using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;





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
                new Student { id= 1, fName = "Andrew", lName = "Schwirzinski", birthdate = new DateOnly(1980,07,19), college_program = "Information Technology", year_in_program = "junior" },
                new Student { id = 2, fName = "Kozimjon", lName = "Kuchkorov", birthdate = new DateOnly(2002, 02, 27), college_program = "Information Technology", year_in_program = "pre-junior" },
                new Student { id = 3, fName = "Ji'Yahna", lName = "Meade", birthdate=new DateOnly(2004, 09, 17), college_program = "Information Technology", year_in_program = "Junior"},
                new Student { id = 4, fName = "Abdoul", lName = "Sow", birthdate=new DateOnly(2003, 04, 06), college_program = "Information Technology", year_in_program = "Junior"}

              );

            builder.Entity<FavoriteFood>().HasData(
                new FavoriteFood { Id = 1, Name = "Tacos", Cuisine = "Mexican", Description = "Grilled meat and veggies in a flour shell", CreatedAt = DateTime.Now },
                new FavoriteFood { Id = 3, Name = "French Fries", Cuisine = "French", Description = "Delicious form of cut potatos", CreatedAt = DateTime.Now },
                 new FavoriteFood { Id = 2, Name = "Kebab", Cuisine = "Turkish", Description = "Grilled meat", CreatedAt = DateTime.Now },
                new FavoriteFood { Id = 4, Name = "Chicken Alfredo", Cuisine = "Italian", Description = "Pasta + chicken = bussin", CreatedAt = DateTime.Now }
            

        );

            builder.Entity<Hobby>().HasData(

            new Hobby { Id = 1, Name = "Working out", Description = "Staying fit ", CreatedAt = DateTime.Now, FavoritePlaceToDoActivity = "Gym" },

            new Hobby { Id = 2, Name = "Art", Description = "Enjoying the way imagination runs wild", CreatedAt = DateTime.Now, FavoritePlaceToDoActivity ="Home" },

            new Hobby { Id = 3, Name = "Drawing", Description = "Designing car models", CreatedAt = DateTime.Now, FavoritePlaceToDoActivity = "Anywhere has desk" },

            new Hobby { Id = 4, Name = "Gaming", Description = "Playing the game, specifically PS5", CreatedAt = DateTime.Now, FavoritePlaceToDoActivity = "Home" }
            

    );

            builder.Entity<Movie>().HasData(


                new Movie { id = 1, Title = "Stepbrothers", Plot = " Stepbrothers need to learn to like each other and become adults", DateCreated = DateTime.Now, ReleaseDate = new DateOnly(2005, 07, 25) },
                new Movie { id = 4, Title = "Avengers", Plot = "Earth's Mightest Heroes", DateCreated = DateTime.Now, ReleaseDate = new DateOnly(2012, 05, 4) },
                 new Movie { id = 2, Title = "James Bond Movies", Plot = "Action movie about British agent 007", DateCreated = DateTime.Now, ReleaseDate = new DateOnly(2006, 11, 16) },
                new Movie { id = 3, Title = "The Call", Plot = "Horror movie about girl being connected my a phone in the same house decades apart, one is a serial killer. If the serial killer does something in the past it changes the present", DateCreated = DateTime.Now, ReleaseDate = new DateOnly(2020, 11, 27)}
                ) ;


        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Hobby> Hobby { get; set; }

        public DbSet<FavoriteFood> FavoriteFood { get; set; }

        public DbSet<Movie> Movie { get; set; }

    }
}
