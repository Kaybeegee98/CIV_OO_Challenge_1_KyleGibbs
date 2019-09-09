using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge_Shapes_Library
{
    public abstract class Quadrilateral : Shape
    {
        public int Side1Length;
        public int Side2Length;
        public int Side3Length;
        public int Side4Length;

        public Quadrilateral(string colour, int side1Length, int side2Length, int side3Length, int side4Length) : base(colour)
        {
            Side1Length = side1Length;
            Side2Length = side2Length;
            Side3Length = side3Length;
            Side4Length = side4Length;
        }

        public int GetPerimeter()
        {
            int result;
            result = (Side1Length + Side2Length + Side3Length + Side4Length);
            return result;
        }
    }
}
