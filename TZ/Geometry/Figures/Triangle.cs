using System;
using System.Collections.Generic;
using System.Linq;

namespace Geometry.Figures
{
    public class Triangle : IFigure
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;

        public Triangle(
            double firstSide,
            double secondSide,
            double thirdSide)
        {
            if (firstSide < 0 || firstSide == 0 ||
                secondSide < 0 || secondSide == 0 ||
                thirdSide < 0 || thirdSide == 0)
            {
                throw new Exception("Стороны треугольника не могут быть меньше либо равными нулю");
            }

            if (firstSide + secondSide <= thirdSide ||
                firstSide + thirdSide <= secondSide ||
                secondSide + thirdSide <= firstSide)
            {
                throw new Exception("Сумма двух любых сторон треугольника должна быть больше третьей стороны");
            }

            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        public double CalculateSquare()
        {
            var semiPerimeter =
                (_firstSide +
                _secondSide +
                _thirdSide) / 2;

            return
                Math.Sqrt(
                    semiPerimeter *
                    (semiPerimeter - _firstSide) *
                    (semiPerimeter - _secondSide) *
                    (semiPerimeter - _thirdSide));
        }

        public bool IsTriangleRight()
        {
            var sidesList = new List<double>
            {
                _firstSide, 
                _secondSide, 
                _thirdSide 
            };

            sidesList.Sort();

            return Math.Pow(sidesList[0], 2) + Math.Pow(sidesList[1], 2) == Math.Pow(sidesList[2], 2);
        }
    }
}
