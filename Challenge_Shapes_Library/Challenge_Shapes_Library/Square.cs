using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Shapes_Library
{
    public class Square : Quadrilateral
    {
        public Square(string colour, int side1Length) : base(colour, side1Length, side1Length, side1Length, side1Length)
        {
        }

        public int GetArea()
        {
            int result;
            result = (Side1Length * Side1Length);
            return result;
        }
    }
}
