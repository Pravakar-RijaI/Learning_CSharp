using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Classes
{
    public class BookCollection
    {
        public List<Books> GetBooks()
        {
            return new List<Books> {
            new Books()
            {   Title = "Old Man And The Sea",
                Price = 99
            },
            new Books()
            {
                Title = "The Stranger",
                Price = 34
            },
            new Books()
            {
                Title = "Metamorphosis",
                Price = 22
            }

        };
            }

        //Func<List<Books>, List<Books>> BooksCheaperthan50 = BookCollection => (Books => Books.Price < 50));
        
        
    }
    
}
