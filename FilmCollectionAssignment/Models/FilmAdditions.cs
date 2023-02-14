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

        public DbSet<AddFilm> addFilms { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            // set data for the database (minimun 3)
            mb.Entity<AddFilm>().HasData(
                
                new AddFilm
                {
                    FilmId = 1,
                    Title = "The Dark Knight",
                    Category = "Action/Adventure",
                    Year = 2008,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false
                },
                new AddFilm
                {
                    FilmId = 2,
                    Title = "la La Land",
                    Category = "RomCom",
                    Year = 2016,
                    Director = "Damien Chazelle",
                    Rating = "PG-13",
                    Edited = false
                },
                new AddFilm
                {
                    FilmId = 3,
                    Title = "Harry Potter and the Half-Blood Prince",
                    Category = "Action/Adventure",
                    Year = 2009,
                    Director = "David Yates",
                    Rating = "PG",
                    Edited = false
                }
                );
        }
    }
}
