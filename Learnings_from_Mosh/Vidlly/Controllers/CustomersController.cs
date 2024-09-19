using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidlly.Models;

namespace Vidlly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers

        public ActionResult Index()
        {
            var customers = GetCustomers();
            
            return View(customers);

        }
        
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customers> GetCustomers()
        {
            return new List<Customers>()
        {
            new Customers {Id = 1, Name = "Franz Kafka"},
            new Customers {Id = 2, Name = "Albert Camus"},
            new Customers {Id = 3, Name = "Ernest Hemingway"},
            new Customers {Id = 4, Name = "George Washington"}
        };
        }
}
}