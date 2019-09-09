using System;
using System.Collections.Generic;
using Challenge_Shapes_Library;

namespace ShapesProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq;
            Rectangle rec;

            int nothing = 0;

            while (nothing == 0) {
                string ans;
                int num;
                string colour;
                int side = 0;
                bool error = true;
                int side1 = 0;
                int side2 = 0;

                Console.Clear();
                Console.WriteLine("Welcome to the Shape Maker!!");
                Console.WriteLine("Make your shape choice!");
                Console.WriteLine("[1]  Square");
                Console.WriteLine("[2]  Rectangle");
                Console.WriteLine("[3] End Program");
                ans = Console.ReadLine();

                try
                {
                    num = int.Parse(ans);

                    if (num == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Please Enter Square's Colour: ");
                        colour = Console.ReadLine();
                        while (error == true)
                        {
                            Console.WriteLine("Please Enter the Side length: ");
                            ans = Console.ReadLine();

                            try
                            {
                                side = int.Parse(ans);
                                if (side <= 0)
                                {
                                    throw new NumberToSmallException();
                                }
                                error = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("{0} is not an integer!", ans);
                            }
                            catch (NumberToSmallException)
                            {
                                Console.WriteLine("The number must be above zero!");
                            }
                        }
                        error = true;

                        sq = new Square(colour, side);
                        Console.WriteLine("Your shape is a Square that is " + colour + " and that has a side length of " + side);
                        Console.WriteLine("It's area is " + sq.GetArea() + " and it's perimeter is " + sq.GetPerimeter());
                        Console.Write("Press any button to create more shapes...");
                        Console.ReadKey();
                    }

                    else if (num == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Please Enter Rectangle's Colour: ");
                        colour = Console.ReadLine();
                        while (error == true)
                        {
                            Console.WriteLine("Please Enter the first Side length: ");
                            ans = Console.ReadLine();

                            try
                            {
                                side1 = int.Parse(ans);
                                if (side1 <= 0)
                                {
                                    throw new NumberToSmallException();
                                }
                                error = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("{0} is not an integer!", ans);
                            }
                            catch (NumberToSmallException)
                            {
                                Console.WriteLine("The number must be above zero!");
                            }

                        }
                        error = true;

                        while (error == true)
                        {
                            Console.WriteLine("Please Enter the second Side length: ");
                            ans = Console.ReadLine();

                            try
                            {
                                side2 = int.Parse(ans);
                                if (side2 <= 0)
                                {
                                    throw new NumberToSmallException();
                                }
                                error = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("{0} is not an integer!", ans);
                            }
                            catch (NumberToSmallException)
                            {
                                Console.WriteLine("The number must be above zero!");
                            }
                        }

                        rec = new Rectangle (colour, side1, side2);
                        Console.WriteLine("Your shape is a Rectangle that is " + colour + ", that has a side length of " + side1 + " and " + side2);
                        Console.WriteLine("It's area is " + rec.GetArea() + " and it's perimeter is " + rec.GetPerimeter());
                        Console.Write("Press any button to create more shapes...");
                        Console.ReadKey();
                    }
                    else if (num == 3)
                    {
                        Environment.Exit(0);
                    }
                }
                catch { }
            }

        }
    }
}
