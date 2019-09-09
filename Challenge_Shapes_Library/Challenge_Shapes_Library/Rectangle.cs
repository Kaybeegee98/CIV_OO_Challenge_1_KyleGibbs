using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Shapes_Library
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(string colour, int side1Length, int side2Length) : base(colour, side1Length, side2Length, side1Length, side2Length)
        {
        }

        public int GetArea()
        {
            int result;
            result = (Side1Length * Side2Length);
            return result;
        }
    }
}
