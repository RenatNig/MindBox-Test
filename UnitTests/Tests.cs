using System;
using NUnit.Framework;
using SpaceCalculator.Abstract;
using SpaceCalculator.Entities;


namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Can_Check_IsRight_Triangle()
        {
            //org
            double a = 7;
            double b = 25;
            double c = 24;
            Triangle t = new Triangle(a,b,c);
            //act
            var result = t.IsRight;
            //assert
            Assert.AreEqual(true,result);
        }
        
        [Test]
        public void Can_Calculate_Circle_Space()
        {
            //org
            double radius = 4;
            int round = 6;
            Circle c = new Circle(radius);
            //act
            var result = c.CalculateSpace(round);
            //assert
            Assert.AreEqual(50.265482d,result);
        }
        
        [Test]
        public void Can_Calculate_Triangle_Space()
        {
            //org
            double a = 3;
            double b = 5;
            double c = 5;
            Triangle t = new Triangle(a,b,c);
            //act
            var result = t.CalculateSpace();
            //assert
            Assert.AreEqual(7.15d,result);
        }
        
        [Test]
        public void Can_Calculate_Figure_Space()
        {
            //org
            double radius = 4;
            int round = 6;
            IFigure c = new Circle(radius);
            //act
            var result = c.CalculateSpace(round);
            //assert
            Assert.AreEqual(50.265482d,result);
        }
    }
}