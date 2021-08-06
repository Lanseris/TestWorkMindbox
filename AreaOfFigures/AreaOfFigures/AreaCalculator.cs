using System;
using System.Collections.Generic;
using System.Linq;
using AreaOfFigures.Figures;

namespace AreaOfFigures
{
    public static class AreaCalculator
    {
        /// <summary>
        /// Определяет фигуру по количеству сторон и возвращает её площадь
        /// Если метод не может определить фигуру, выбрасывает FigureDefinitionException
        /// </summary>
        /// <param name="sides">Стороны фигуры</param>
        /// <returns></returns>
        public static double FigureAreaCalculating(Side[] sides)
        {
            switch (sides.Length)
            {
                case 0:
                    throw new FigureDefinitionException("Can't define figure with 0 sides.");
                case 1: //круг
                    Circle circle;
                    circle = new Circle(sides);

                    return circle.CalculateArea();

                case 3: //треугольник
                    Triangle triangle;
                    triangle = new Triangle(sides);

                    return triangle.CalculateArea();

                default:
                    throw new FigureDefinitionException("Can't define figure with "+ sides.Length +" sides.");
            }
        }


    }

    public class FigureDefinitionException : Exception
    {
        public FigureDefinitionException(string message)
            : base(message) { }
    }

}
