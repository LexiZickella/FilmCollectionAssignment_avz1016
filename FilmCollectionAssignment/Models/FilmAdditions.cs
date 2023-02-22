using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollectionAssignment.Models
{
    public class FilmAdditions : DbContext
    {
        // Constructor
        public FilmAdditions (DbContextOptions<FilmAdditions> options) : base (options)
        {
            // leave blank for now
        }

        public DbSet<AddFilm> addFilms { get; set; } // adding a film table
        public DbSet<Category> Categories { get; set; } // categroy table

        
        protected override void OnModelCreating(ModelBuilder mb)
        {
            // separate table for Category and a drop down with possible selections
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Adventure"},
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Action"},
                new Category { CategoryId = 4, CategoryName = "Drama" },
                new Category { CategoryId = 5, CategoryName = "Thriller" },
                new Category { CategoryId = 6, CategoryName = "Romantic Comedy" },
                new Category { CategoryId = 7, CategoryName = "Children" },
                new Category { CategoryId = 8, CategoryName = "Horror" },
                new Category { CategoryId = 9, CategoryName = "Musical" },
                new Category { CategoryId = 10, CategoryName = "Documentary" },
                new Category { CategoryId = 11, CategoryName = "Western" },
                new Category { CategoryId = 12, CategoryName = "Black Comedy" },
                new Category { CategoryId = 13, CategoryName = "Other" }
                );

            // set data for the database (minimun 3)
            mb.Entity<AddFilm>().HasData(
                
                // Seeding the Data
                new AddFilm
                {
                    FilmId = 1,
                    Title = "The Dark Knight",
                    CategoryId = 3,
                    Year = 2008,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false
                },
                new AddFilm
                {
                    FilmId = 2,
                    Title = "La La Land",
                    CategoryId = 6,
                    Year = 2016,
                    Director = "Damien Chazelle",
                    Rating = "PG-13",
                    Edited = false
                },
                new AddFilm
                {
                    FilmId = 3,
                    Title = "Harry Potter and the Half-Blood Prince",
                    CategoryId = 1,
                    Year = 2009,
                    Director = "David Yates",
                    Rating = "PG",
                    Edited = false
                }
                );
        }
    }
}
