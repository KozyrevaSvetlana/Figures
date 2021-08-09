using System;

namespace FiguresLibrary
{
    public class Circle : Figure
    {
        #region Properties

        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; }

        #endregion

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentOutOfRangeException">Если радиус круга имеет отрицательное значение</exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");

            Radius = radius;
        }

        #region Functions

        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        protected sealed override double CalculateSquare()
        {
            return Math.PI * Radius * Radius;
        }

        #endregion
    }
}
