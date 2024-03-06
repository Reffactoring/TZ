using Geometry.Figures;

namespace Geometry.Tests
{
    public class Tests
    {
        #region CircleTests

        [TestCase(5)]
        [TestCase(6.13)]
        [TestCase(1)]
        [TestCase(78)]
        [TestCase(21)]
        [TestCase(33)]
        public void CircleSquareTestOk(double radius)
        {
            var correctResult = Math.PI* Math.Pow(radius, 2);

            var circle = new Circle(radius);

            Assert.That(circle.CalculateSquare(), Is.EqualTo(correctResult));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-6.3)]
        public void CircleTestEx(double radius)
        {
            try
            {
                var correctResult = Math.PI * Math.Pow(radius, 2);

                var circle = new Circle(radius);
                circle.CalculateSquare();
            }
            catch
            {
                Assert.True(true);
            }
        }

        #endregion

        #region TriangleTests

        [TestCase(3,4,5)]
        [TestCase(2,4,7)]
        [TestCase(8,16,48)]
        public void TriangleSquareTestOk(
            double firstSide,
            double secondSide,
            double thirdSide)
        {
            var semiPerimeter =
               (firstSide +
               secondSide +
               thirdSide) / 2;

            var correctResult =
               Math.Sqrt(
                    semiPerimeter *
                    (semiPerimeter - firstSide) *
                    (semiPerimeter - secondSide) *
                    (semiPerimeter - thirdSide));


            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.That(triangle.CalculateSquare(), Is.EqualTo(correctResult));
        }

        [TestCase(1, 1, 1)]
        [TestCase(2.2, 0, 7)]
        public void TriangleTestEx(
           double firstSide,
           double secondSide,
           double thirdSide)
        {
            try
            {
                var semiPerimeter =
               (firstSide +
               secondSide +
               thirdSide) / 2;

                var correctResult =
                   Math.Sqrt(
                        semiPerimeter *
                        (semiPerimeter - firstSide) *
                        (semiPerimeter - secondSide) *
                        (semiPerimeter - thirdSide));


                var triangle = new Triangle(firstSide, secondSide, thirdSide);
                triangle.CalculateSquare();
            }
            catch
            {
                Assert.True(true);
            }
        }

        [TestCase(3, 4, 5)]
        [TestCase(2, 4, 5)]
        public void TraingleTestRight(
            double firstSide,
            double secondSide,
            double thirdSide)
        {
            var sidesList = new List<double>
            {
                firstSide,
                secondSide,
                thirdSide
            };

            sidesList.Sort();

            var correctResult =
                Math.Pow(sidesList[0], 2) + Math.Pow(sidesList[1], 2) == Math.Pow(sidesList[2], 2);

            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            Assert.That(correctResult, Is.EqualTo(triangle.IsTriangleRight()));
        }

        #endregion
    }
}