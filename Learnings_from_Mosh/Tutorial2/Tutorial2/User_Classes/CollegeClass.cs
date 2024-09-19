using System;
namespace CollegeProgram
{
    public class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        private string Introduce { get; set; }
        public void Food()
        {
            Introduce = Name + " is a " + Description + " animal.";
            Console.WriteLine(Introduce);
            if (Description == "domestic")
                Console.WriteLine("It is Cute.");
            else
                Console.WriteLine("It is Fierce.");
        }
    }
}