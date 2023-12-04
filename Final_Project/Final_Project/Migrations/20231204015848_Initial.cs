﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cuisine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteFood", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hobby",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobby", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthdate = table.Column<DateOnly>(type: "date", nullable: false),
                    college_program = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    year_in_program = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "FavoriteFood",
                columns: new[] { "Id", "CreatedAt", "Cuisine", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 3, 20, 58, 47, 796, DateTimeKind.Local).AddTicks(2049), "Mexican", "Grilled meat and veggies in a flour shell", "Tacos" },
                    { 2, new DateTime(2023, 12, 3, 20, 58, 47, 796, DateTimeKind.Local).AddTicks(2098), "French", "Delicious form of cut potatos", "French Fries" },
                    { 4, new DateTime(2023, 12, 3, 20, 58, 47, 796, DateTimeKind.Local).AddTicks(2100), "Italian", "Pasta + chicken = bussin", "Chicken Alfredo" }
                });

            migrationBuilder.InsertData(
                table: "Hobby",
                columns: new[] { "Id", "CreatedAt", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 3, 20, 58, 47, 796, DateTimeKind.Local).AddTicks(2126), "Staying fit ", "Working out" },
                    { 2, new DateTime(2023, 12, 3, 20, 58, 47, 796, DateTimeKind.Local).AddTicks(2129), "Enjoying the way imagination runs wild", "Art" }
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "id", "DateCreated", "Plot", "Title" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 20, 58, 47, 796, DateTimeKind.Local).AddTicks(2153), "Two step brother need to learn to like each other an become adults", "Stepbrothers" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "id", "birthdate", "college_program", "fName", "lName", "year_in_program" },
                values: new object[,]
                {
                    { 1, new DateOnly(1980, 7, 19), "Information Technology", "Andrew", "Schwirzinski", "junior" },
                    { 2, new DateOnly(2002, 2, 27), "Information Technology", "Kozimjon", "Kuchkorov", "pre-junior" },
                    { 3, new DateOnly(2004, 9, 17), "Information Technology", "Ji'Yahna", "Meade", "Junior" },
                    { 4, new DateOnly(2003, 4, 6), "Information Technology", "Abdoul", "Sow", "Junior" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteFood");

            migrationBuilder.DropTable(
                name: "Hobby");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
