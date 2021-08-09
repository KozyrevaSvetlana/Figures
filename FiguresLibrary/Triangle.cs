using System;
using System.Linq;

namespace FiguresLibrary
{
    public class Triangle : Figure
    {
        #region Fields

        private readonly Lazy<bool> _isRightAngled;

        #endregion

        #region Properties

        /// <summary>
        /// Первая сторона
        /// </summary>
        public double FirstSide { get; }

        /// <summary>
        /// Вторая сторона
        /// </summary>
        public double SecondSide { get; }

        /// <summary>
        /// Третья сторона
        /// </summary>
        public double ThirdSide { get; }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightAngled => _isRightAngled.Value;

        #endregion

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="firstSide">Первая сторона</param>
        /// <param name="secondSide">Вторая сторона</param>
        /// <param name="thirdSide">Третья сторона</param>
        /// <exception cref="ArgumentOutOfRangeException">Если сторона треугольника имеет отрицательное значение</exception>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            _isRightAngled = new Lazy<bool>(CheckIsRightAngled);
        }

        #region Functions

        /// <summary>
        /// Проверить, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        private bool CheckIsRightAngled()
        {
            var maxSide = new[] { FirstSide, SecondSide, ThirdSide }.Max();
            var maxSideSqr = maxSide * maxSide;
            return maxSideSqr + maxSideSqr == FirstSide * FirstSide + SecondSide * SecondSide + ThirdSide * ThirdSide;
        }

        /// <summary>
        /// Вычислить площадь треугольника
        /// </summary>
        protected sealed override double CalculateSquare()
        {
            var semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            var firstSideCoefficient = semiPerimeter - FirstSide;
            var secondSideCoefficient = semiPerimeter - SecondSide;
            var thirdSideCoefficient = semiPerimeter - ThirdSide;

            return Math.Sqrt(semiPerimeter * firstSideCoefficient * secondSideCoefficient * thirdSideCoefficient);
        }

        #endregion
    }
}
