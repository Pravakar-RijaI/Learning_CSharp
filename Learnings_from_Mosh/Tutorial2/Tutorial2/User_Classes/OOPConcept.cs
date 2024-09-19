using System;

namespace OOPConcept
{
    internal class BaseClass
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public void Description()
        {
            Console.WriteLine(Name + " is of " + " type " + Type + " and color " + Color);
        }

    }
}
