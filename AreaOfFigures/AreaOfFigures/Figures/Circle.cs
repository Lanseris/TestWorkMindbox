using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfFigures.Figures
{
    public class Circle: Figure
    {
        double _radius;

        public Circle(Side[] sides, double radius = 0)
            :base(sides)
        {
            if (radius!=0 && sides.Length == 1)
            {
                if (sides[0].side!=Math.Round(2*Math.PI*radius,3))
                {
                    throw new FigureCreationException("Circle parameters do not match, try to pass the length of the circle, or its radius");
                }
            }
            else if (radius==0 && sides.Length==1)
            {
                if (sides[0].side == 0)
                    throw new FigureCreationException("Side of a circle cannot be zero");

                Perimeter = sides[0].side;
                _radius = Perimeter / (2 * Math.PI);
            }
            else if (radius!=0 && sides.Length == 0)
            {
                Sides[0].side = Math.Round(2 * Math.PI * radius, 3);
                Perimeter = Sides[0].side;
            }
        }

        public override double CalculateArea()
        {
            Area = Math.Pow(_radius, 2) * Math.PI;
            return Area;
        }
    }
}
