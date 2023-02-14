using FilmCollectionAssignment.Models;
using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<HomeController> _logger;
        private FilmAdditions blahContext { get; set; }

        // Constructor
        public HomeController(ILogger<HomeController> logger, FilmAdditions someName)
        {
            _logger = logger;
            blahContext = someName;
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
            return View();
        }

        [HttpPost]
        public IActionResult Film (AddFilm af)
        {
            // add to the file and save changes, for the database to work
            blahContext.Add(af);
            blahContext.SaveChanges();

            return View("Confirmation", af);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
