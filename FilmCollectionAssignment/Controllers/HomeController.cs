using FilmCollectionAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollectionAssignment.Controllers
{
    public class HomeController : Controller
    {

        private FilmAdditions faContext { get; set; }

        // Constructor
        public HomeController(FilmAdditions someName)
        {
            faContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Podcast ()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Film ()
        {
            ViewBag.Categories = faContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Film (AddFilm af)
        {
            // add to the file and save changes, for the database to work
            faContext.Add(af);
            faContext.SaveChanges();

            return View("Confirmation", af);
        }
        public IActionResult MovieList()
        {
            var newFilms = faContext.addFilms
                .Include(x => x.Category)
                .OrderBy(x => x.Category)
                .ToList();

            return View(newFilms);
        }

        // Edit Get and Post
        [HttpGet]
        public IActionResult Edit (int id)
        {
            ViewBag.Categories = faContext.Categories.ToList();

            var entry = faContext.addFilms.Single(x => x.FilmId == id);

            return View("Film", entry);
        }

        [HttpPost]
        public IActionResult Edit (AddFilm z)
        {
            faContext.Update(z);
            faContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        // delete Get and Post 
        [HttpGet]
        public IActionResult Delete (int id)
        {
            var entry = faContext.addFilms.Single(x => x.FilmId == id);

            return View(entry);
        }

        [HttpPost]
        public IActionResult Delete (AddFilm af)
        {
            faContext.addFilms.Remove(af);
            faContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}
