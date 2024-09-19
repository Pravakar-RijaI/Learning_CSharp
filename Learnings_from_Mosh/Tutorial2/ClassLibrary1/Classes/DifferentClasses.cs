using System;

namespace ClassLibrary.DifferentClasses
{
    public class BaseClass
    {
        private int Id = 34;
        public string name { get; set; }
        public byte height { get; set; }

        public void Introduce()
        {
            Console.WriteLine(this.name + " is of " + this.height + " ft.");
            Console.WriteLine(this.Id);
        }

    }

    public class DerivedClass : BaseClass
    {
        public string NwaranName { get; set; }

        public void Nwaran()
        {
            Console.WriteLine("Your Nwaran Ko Name is " + this.NwaranName);
        }
    }
}
