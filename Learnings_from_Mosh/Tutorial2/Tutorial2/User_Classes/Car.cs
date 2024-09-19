using System;
using OrderItem;
using System.Collections.Generic;

namespace Vechicle
{
    internal class Car
    {
        public string Name;
        public string Type;
        public List<string> Orders;

        public Car()
        {
            Name = "No Name";
            Type = "No Type";
             Orders = new List<string>();
        }

        public void Introduce()
        {
            Console.WriteLine(Name + " is a " + Type);
            foreach (string Order in Orders)
                Console.WriteLine(Order);
        }
    }
}
