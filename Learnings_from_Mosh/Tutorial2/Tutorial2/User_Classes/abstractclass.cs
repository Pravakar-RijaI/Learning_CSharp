using System;


namespace Tutorial2.User_Classes
{
    public interface IAbstractClass
    {
        //string Name { get; set; }

        void Draw();
    }

    public class DerivedClass : IAbstractClass
    {
        public void Draw()
        {
            Console.WriteLine("Draw this shit..");
        }
    }
}
