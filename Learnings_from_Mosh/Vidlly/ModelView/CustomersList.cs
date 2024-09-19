using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidlly.Models;

namespace Vidlly.ModelView
{
    public class CustomersList
    {
        List<Customers> customers = new List<Customers>()
        {
            new Customers {Id = 1, Name = "Franz Kafka"},
            new Customers {Id = 2, Name = "Albert Camus"},
            new Customers {Id = 3, Name = "Ernest Hemingway"},
            new Customers {Id = 4, Name = "George Washington"}
        };
    }
}