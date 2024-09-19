using System;

namespace People
{
    internal class Person
    {
        private readonly string FirstName;
        private readonly string LastName;

        internal Person ()
        {
            FirstName = "No";
            LastName = "Name";
        }
        internal Person (string firstName)
            {
            FirstName = firstName;
            }
        
        internal Person (string firstName, string lastName)
            {
            FirstName = firstName;
            LastName = lastName;
            }
        
        public void Introduce ()
        {
            Console.WriteLine("Iam {0} {1} and I'm hungry.", FirstName, LastName);
        }
    }
}
