using System;
using SpaceCalculator.Abstract;

namespace SpaceCalculator.Entities
{
    public class Triangle: IFigure
    {
        private double A;
        private double B;
        private double C;

        private bool _IsRight;
        public bool IsRight => _IsRight;

        private double PerHalf;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0)
                throw new ArgumentException($"Сторона не может быть отрицательной или равняться нулю {nameof(a)}");

            if (b <= 0)
                throw new ArgumentException($"Сторона не может быть отрицательной или равняться нулю {nameof(b)}");

            if (c <= 0)
                throw new ArgumentException($"Сторона не может быть отрицательной или равняться нулю {nameof(c)}");

            double[] array = new double[3] {a, b, c};
            Array.Sort(array);
            
            if(!CheckSidesSum(array))
                throw new ArgumentException($"Наибольшая сторона треугольника должна быть меньше суммы двух других");
            
            _IsRight = CheckIfRight(array);
            PerHalf = (a + b + c) / 2;

            A = a;
            B = b;
            C = c;
        }

        private bool CheckIfRight(double[] arr)
        {
            return Math.Pow(arr[2], 2) == Math.Pow(arr[1], 2) + Math.Pow(arr[0], 2);
        }

        private bool CheckSidesSum(double[] arr)
        {
            return arr[2] < arr[0] + arr[1];
        }
        
        public double CalculateSpace(int round = 2)
        {
            return Math.Round(Math.Sqrt(PerHalf*(PerHalf-A)*(PerHalf-B)*(PerHalf-C)), round);
        }
    }
}