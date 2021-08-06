using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfFigures
{
    abstract public class Figure
    {
        public double Area;

        public Side[] Sides;

        public double Perimeter;

        abstract public double CalculateArea();

        public Figure(Side[]sides)
        {
            if (sides == null)
                throw new NullReferenceException();
            
            Sides = sides;

            for (int i = 0; i < sides.Length; i++)
            {
                Perimeter += sides[i].side;
            }
        }
        
    }

    /// <summary>
    /// Структура, описывающая сторону и один прилежащий к ней угол
    /// </summary>
    public struct Side
    {
        public double side;
        public double angle;
    }

    public class FigureCreationException : Exception
    {
        public FigureCreationException(string message)
            : base(message) { }
    }


}
