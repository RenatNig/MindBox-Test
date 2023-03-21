using SpaceCalculator.Abstract;
using System;

namespace SpaceCalculator.Entities
{
    public class Circle : IFigure
    {
        private double Radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException($"Радиус не может быть отрицательным или равняться нулю {nameof(radius)}");
            Radius = radius;
        }

        public double CalculateSpace(int round = 2)
        {
            return Math.Round(Math.Pow(Radius,2) * Math.PI,round);
        }
    }
}