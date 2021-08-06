using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaOfFigures.Figures
{
    public class Triangle : Figure
    {
        double _a, _b, _c;

        bool _isRectangular;

        public Triangle(Side[] sides)
            :base(sides)
        {
            
            if (sides.Length!=3)
                throw new FigureCreationException("Wrong number fo sides, this is not a triangle");

            double angleSum = sides.Sum(x => x.angle);
            if (angleSum != 180)
                throw new FigureCreationException("Sum of all angls in triangle must be 180!");

            _a = sides[0].side;
            _b = sides[1].side;
            _c = sides[2].side;

            if (!(_a + _b > _c && _b + _c > _a && _c + _a > _b))
                throw new FigureCreationException("The dimensions of the sides are incorrect, the triangle does not exist");

            if(!(Math.Pow(_a,2)==Math.Pow(_b,2)+Math.Pow(_c,2) - 2*_b*_c*Math.Round(Math.Cos(sides[2].angle*(Math.PI/180)),5)))
                throw new FigureCreationException("Wrong angle and sides ratio, triangle cannot exist");

            //Проверка на то, является ли треугольник прямоугольным
            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i].angle == 90)
                    _isRectangular = true;
            }
        }

        public override double CalculateArea()
        {
            double semi_perimeter = (Perimeter) / 2;
            Area = Math.Sqrt(semi_perimeter * (semi_perimeter - _a) * (semi_perimeter - _b) * (semi_perimeter - _c));
            return Area;
        }
    }
}
