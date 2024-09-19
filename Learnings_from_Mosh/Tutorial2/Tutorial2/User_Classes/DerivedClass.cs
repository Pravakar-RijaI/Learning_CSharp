using System;

namespace OOPConcept
{
    internal class DerivedClass : BaseClass
    {
        public int DerivedId { get; set; }

        public void Introduce()
        {
            Console.WriteLine(Name + " is of ID" + DerivedId
                );
        }
    }
}
