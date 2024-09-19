using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie { Id = 12, Title = "Shawshank Redemption" };
            var customers = new List<Customer> 
            { new Customer {Id = 32, Name = "Rajesh Dai" },
              new Customer {Id = 43, Name = "Shahrukh Khan" }, 
              new Customer {Id = 7, Name = "Brad Pitt" } };

            var randomViewModel = new RandomViewModel
            {
                Movie = movie,
                Customers = customers
            };

            /*ViewBag.Movie = movie;
            ViewBag.Customer = customer;*/

            return View(randomViewModel);
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});

        }

        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        public ActionResult Index(int? pageNo, string sortBy)
        {
            if (pageNo == null)
                pageNo = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content($"Page No :{pageNo}\nSort By:{sortBy}.");
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content($"{year}/{month}");
        }

    }
}