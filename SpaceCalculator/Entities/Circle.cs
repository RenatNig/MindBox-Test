using SpaceCalculator.Abstract;
using System;

namespace SpaceCalculator.Entities
{
    public class Circle : IFigure
    {
        private double _radius;

        public Circle(double rad)
        {
            _radius = rad;
        }

        public double CalculateSpace(int round = 2)
        {
            return Math.Round(Math.Pow(_radius,2) * Math.PI,round);
        }
    }
}