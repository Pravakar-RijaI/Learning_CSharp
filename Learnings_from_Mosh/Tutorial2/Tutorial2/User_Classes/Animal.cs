using System;

namespace Kingdom
{
    internal class Animal
    {
        private string Name;
        private byte LegNum;

        public Animal()
        {
            this.Name = "";
            this.LegNum = 0;
        }
        public Animal(string name, byte legNum)
        {
            this.Name = name;
            this.LegNum = legNum;
        }
        
        public void Introduce()
        {
            Console.WriteLine("Iam a {0} with {1} Legs.",Name,LegNum);
        }

        public static   Animal Parse (string str, byte leg)
        {
            Animal A1 = new Animal();
            A1.Name = str;
            A1.LegNum = leg;
            return A1;
        }
    }
}
