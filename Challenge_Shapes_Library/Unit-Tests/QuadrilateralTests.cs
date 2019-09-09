using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using Challenge_Shapes_Library;
// remember to reference and import your shape library

namespace Quadrilateral_Tests
{
    [TestFixture]
    public class Tests
    {
        Square sq1 { get; set; }
        Rectangle rec1 { get; set; }

        Square sq2 { get; set; }
        Rectangle rec2 { get; set; }

        Square custsq { get; set; }
        Rectangle custrec { get; set; }

        [SetUp]
        public void Init()
        {
            sq1 = new Square("Blue", 4);
            rec1 = new Rectangle("Red", 4, 3);

            sq2 = new Square("Blue", 6);
            rec2 = new Rectangle("Red", 5, 4);
        }

        [Test]
        public void SquareTests()
        {
            int area = 16;
            int perimeter = 16;

            Assert.AreEqual(area, sq1.GetArea());
            Assert.AreEqual(perimeter, sq1.GetPerimeter());

            area = 36;
            perimeter = 24;

            Assert.AreEqual(area, sq2.GetArea());
            Assert.AreEqual(perimeter, sq2.GetPerimeter());

        }

        [TestCase(5, 25, 20)]
        [TestCase(15, 225, 60)]
        [TestCase(7, 49, 28)]
        public void CustomSquareTests(int side, int area, int perimeter)
        {
            custsq = new Square("blue", side);
            Assert.AreEqual(area, custsq.GetArea());
            Assert.AreEqual(perimeter, custsq.GetPerimeter());
        }

        [Test]
        public void RectangleTests()
        {
            int area = 12;
            int perimeter = 14;

            Assert.AreEqual(area, rec1.GetArea());
            Assert.AreEqual(perimeter, rec1.GetPerimeter());

            area = 20;
            perimeter = 18;

            Assert.AreEqual(area, rec2.GetArea());
            Assert.AreEqual(perimeter, rec2.GetPerimeter());

        }

        [TestCase(5, 10, 50, 30)]
        [TestCase(4, 6, 24, 20)]
        [TestCase(9, 7, 63, 32)]
        public void CustomRectangleTests(int side1, int side2, int area, int perimeter)
        {
            custrec = new Rectangle("blue", side1, side2);

            Assert.AreEqual(area, custrec.GetArea());
            Assert.AreEqual(perimeter, custrec.GetPerimeter());
        }

    }
}