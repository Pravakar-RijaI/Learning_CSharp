using System;
using System.Collections.Generic;
using System.Collections;

namespace Classes
{
    public class BookRepo
    {
        public IEnumerable<Books> GetBooks()
        {
            return new List<Books>
                {
                new Books() { Title = "Plague", Price = 9 },
                new Books() { Title = "Morning Star", Price = 2 },
                new Books() { Title = "Do It Today", Price = 32 }
                };
        }
    }
}
