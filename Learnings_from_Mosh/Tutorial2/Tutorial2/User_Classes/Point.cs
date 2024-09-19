using System;
using System.Xml;

namespace Points
{
    internal class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point NewLocation)
        {
            X = NewLocation.X;
            Y = NewLocation.Y;
        }
    }
}
