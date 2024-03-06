using System;

namespace Geometry.Figures
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius < 0 || radius == 0)
            {
                throw new ArgumentException("Радиус не может быть меньше или равным нулю");
            }

            _radius = radius;
        }

        public double CalculateSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}