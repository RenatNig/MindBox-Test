using System;
using NUnit.Framework;
using SpaceCalculator.Abstract;
using SpaceCalculator.Entities;

namespace UnitTests
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(0)]
        [TestCase(-1)]
        [Test]
        public void Can_Create_Broken_Circle(double rad)
        {
            Assert.Catch<ArgumentException>(() => new Circle(rad));
        }

        [TestCase(4,6, ExpectedResult = 50.265482d)]
        [TestCase(5,2, ExpectedResult = 78.54d)]
        [TestCase(88, 11, ExpectedResult = 24328.49350939936d)]
        [Test]
        public double Can_Calculate_Space_Circle(double radius, int round)
        {
            //org
            Circle c = new Circle(radius);
            //act
            var result = c.CalculateSpace(round);
            //assert
            return result;
        }
    }
}