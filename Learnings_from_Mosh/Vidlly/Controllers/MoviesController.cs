using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidlly.Models;

namespace Vidlly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            List<Movies> movies = new List<Movies>
        {
            new Movies {Id = 1, Title = "Godfather - I"},
            new Movies {Id = 2, Title = "Shawshank Redemption"},
            new Movies {Id = 3, Title = "Bucket List"},
            new Movies {Id = 4, Title = "Kabir Singh"}
        };
            
            ViewBag.Movies = movies;
            return View();
        }
    }
}