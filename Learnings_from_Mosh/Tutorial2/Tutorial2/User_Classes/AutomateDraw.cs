using System;
using System.Collections.Generic;


namespace MethodOverride
{
    public class Canvas
    {
        public static void DrawShapes(List<Shapes> shapes)
            {
                foreach(var shape in shapes)
            {
                shape.Draw();
            }
            }
    }
}
