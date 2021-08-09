using System;
using NUnit.Framework;
using FiguresLibrary;

namespace FiguresTest
{
    [TestFixture]
    public class SqrCalculatorTests
    {
        /// <summary>
        /// Тестируем отрицательный радиус круга
        /// </summary>
        [Test]
        public void CircleNegativeRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));
        }

        /// <summary>
        /// Тестируем отрицательные стороны треугольника
        /// </summary>
        [Test]
        public void TriangleNegativeSidesTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-10, 0, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -10, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -10));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-10, -10, -10));
        }

        /// <summary>
        /// Тестируем вычисление площади круга
        /// </summary>
        [Test]
        public void CircleSqrCalculationTest()
        {
            //Arrange
            var circle = new Circle(10);

            //Act
            var circleSquare = circle.Square;

            //Assert
            Assert.AreEqual(314.15926535897931, circleSquare);
        }

        /// <summary>
        /// Тестируем вычисление площади тиугольника
        /// </summary>
        [Test]
        public void TriangleSqrCalculationTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var triangleSquare = triangle.Square;

            //Assert
            Assert.AreEqual(6, triangleSquare);
        }

        /// <summary>
        /// Тестируем прямоугольный треугольник
        /// </summary>
        [Test]
        public void RightAngleTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var isTriangleRightAngled = triangle.IsRightAngled;

            //Assert
            Assert.AreEqual(true, isTriangleRightAngled);
        }

        /// <summary>
        /// Тестируем не прямоугольный треугольник
        /// </summary>
        [Test]
        public void NotRightAngleTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(6, 2, 5);

            //Act
            var isTriangleRightAngled = triangle.IsRightAngled;

            //Assert
            Assert.AreEqual(false, isTriangleRightAngled);
        }
    }
}
