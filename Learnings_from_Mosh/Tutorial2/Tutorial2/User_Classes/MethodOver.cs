using System;

namespace MethodOverride
{
    public class Shapes
    {
        public string name { get; set; }
        public string color { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shapes.");

        }

    }

    public class Circle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }

    public class Rectangle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
    }
}
