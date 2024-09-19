using System;

namespace Business
{
    internal class Customer
    {
        private readonly byte CustomerId;
        public string Name;

        public Customer()
        {
            
        }

        public Customer(byte id)
        {
            this.CustomerId = id;
        }

        public Customer(byte id, string name)
        {
            this.CustomerId = id;
            this.Name = name;
        }
    }
}
