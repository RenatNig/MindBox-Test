using System;
using SpaceCalculator.Abstract;

namespace SpaceCalculator.Entities
{
    public class Triangle: IFigure
    {
        private double _a;
        private double _b;
        private double _c;

        private bool _IsRight;
        
        public bool IsRight => _IsRight;

        private double _perHalf;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
            _perHalf = (a + b + c) / 2;
            CheckIfRight();
        }

        private void CheckIfRight()
        {
            double[] array = new double[3] {_a, _b, _c};
            Array.Sort(array);
            _IsRight = Math.Pow(array[2], 2) == Math.Pow(array[1], 2) + Math.Pow(array[0], 2);
        }
        
        public double CalculateSpace(int round = 2)
        {
            return Math.Round(Math.Sqrt(_perHalf*(_perHalf-_a)*(_perHalf-_b)*(_perHalf-_c)), round);
        }
    }
}