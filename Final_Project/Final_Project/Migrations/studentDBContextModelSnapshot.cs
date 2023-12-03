﻿// <auto-generated />
using System;
using Final_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Final_Project.Migrations
{
    [DbContext(typeof(studentDBContext))]
    partial class studentDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Final_Project.Models.FavoriteFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cuisine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FavoriteFood");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 12, 3, 18, 32, 27, 503, DateTimeKind.Local).AddTicks(6072),
                            Cuisine = "Mexican",
                            Description = "Grilled meat and veggies in a flour shell",
                            Name = "Tacos"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 12, 3, 18, 32, 27, 503, DateTimeKind.Local).AddTicks(6121),
                            Cuisine = "French",
                            Description = "Delicious form of cut potatos",
                            Name = "French Fries"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 12, 3, 18, 32, 27, 503, DateTimeKind.Local).AddTicks(6124),
                            Cuisine = "Italian",
                            Description = "Pasta + chicken = bussin",
                            Name = "Chicken Alfredo"
                        });
                });

            modelBuilder.Entity("Final_Project.Models.Hobby", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hobby");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 12, 3, 18, 32, 27, 503, DateTimeKind.Local).AddTicks(6146),
                            Description = "Staying fit ",
                            Name = "Working out"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 12, 3, 18, 32, 27, 503, DateTimeKind.Local).AddTicks(6149),
                            Description = "Enjoying the way imagination runs wild",
                            Name = "Art"
                        });
                });

            modelBuilder.Entity("Final_Project.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateOnly>("birthdate")
                        .HasColumnType("date");

                    b.Property<string>("college_program")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("year_in_program")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            id = 1,
                            birthdate = new DateOnly(1980, 7, 19),
                            college_program = "Information Technology",
                            fName = "Andrew",
                            lName = "Schwirzinski",
                            year_in_program = "junior"
                        },
                        new
                        {
                            id = 2,
                            birthdate = new DateOnly(2002, 2, 27),
                            college_program = "Information Technology",
                            fName = "Kozimjon",
                            lName = "Kuchkorov",
                            year_in_program = "pre-junior"
                        },
                        new
                        {
                            id = 3,
                            birthdate = new DateOnly(2004, 9, 17),
                            college_program = "Information Technology",
                            fName = "Ji'Yahna",
                            lName = "Meade",
                            year_in_program = "Junior"
                        },
                        new
                        {
                            id = 4,
                            birthdate = new DateOnly(2003, 4, 6),
                            college_program = "Information Technology",
                            fName = "Abdoul",
                            lName = "Sow",
                            year_in_program = "Junior"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
