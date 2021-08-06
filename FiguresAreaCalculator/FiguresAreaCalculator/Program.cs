using System;
using System.Collections.Generic;
using AreaOfFigures;

namespace FiguresAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Круг
            Side[] circle = new Side[1];
            circle[0] = new Side();
            circle[0].side = 1;

            Console.WriteLine("Площадь круга: " + CalculateArea(circle));
            #endregion

            #region Треугольник
            Side[] triangle = new Side[3];
            triangle[0].side = 4;
            triangle[0].angle = 90;
            triangle[1].side = 5;
            triangle[1].angle = 36.87;
            triangle[2].side = 3;
            triangle[2].angle = 53.13;

            Console.WriteLine("Площадь треугольника:" + CalculateArea(triangle)); 
            #endregion

            Console.ReadLine();
        }

        public static double CalculateArea(Side[] sides)
        {
            try
            {
                return AreaCalculator.FigureAreaCalculating(sides);
            }
            catch (FigureCreationException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            catch (FigureDefinitionException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
