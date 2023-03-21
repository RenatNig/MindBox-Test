using System;
using NUnit.Framework;
using SpaceCalculator.Abstract;
using SpaceCalculator.Entities;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(5, 5, -10)]
        [TestCase(5, 0, 10)]
        [TestCase(5, 5, 10)]
        [Test]
        public void Can_Create_Broken_Triangle(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
        }
        
        [TestCase(7, 25, 24, ExpectedResult = true)]
        [TestCase(5, 25, 26, ExpectedResult = false)]
        [Test]
        public bool Can_Check_IsRight_Triangle(double a, double b, double c)
        {
            //org
            Triangle t = new Triangle(a,b,c);
            //act
            var result = t.IsRight;
            //assert
            return result;
        }

        [TestCase(3, 5, 5, ExpectedResult = 7.15d)]
        [TestCase(6, 5, 5, ExpectedResult = 12d)]
        [TestCase(4, 2, 4, ExpectedResult = 3.87d)]
        [Test]
        public double Can_Calculate_Space_Triangle(double a, double b, double c)
        {
            //org
            Triangle t = new Triangle(a,b,c);
            //act
            var result = t.CalculateSpace();
            //assert
            return result;
        }
    }
}