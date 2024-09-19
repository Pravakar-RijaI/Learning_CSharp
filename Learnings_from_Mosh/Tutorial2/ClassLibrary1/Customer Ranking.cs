using System;

namespace ClassLibrary1
{
    public class CustomerRank
    {
        private readonly int _id;

        public CustomerRank(int id)
        {
            _id = id;
            Console.WriteLine("Base Class Constructor");
        }

        public void Introduce()
        {
            Console.WriteLine("Base Class Function");

        }
    }

    public class BusinessRank : CustomerRank
    {
        public BusinessRank(int id)
            : base(id)
        {
            Console.WriteLine("Derived Class Constructor");
        }
       public new void Introduce()
        {
            Console.WriteLine("Derived Class Function.");
        }
    }
}
