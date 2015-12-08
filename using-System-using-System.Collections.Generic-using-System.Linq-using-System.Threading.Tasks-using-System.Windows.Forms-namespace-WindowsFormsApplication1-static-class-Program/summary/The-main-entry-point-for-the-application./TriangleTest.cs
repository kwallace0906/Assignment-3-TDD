using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTriangle;

namespace MyTriangle.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void RightHypotenuseSimple()
        {
            var triangle = new Triangle();
            double hypot = triangle.RightHypotenuse(3, 4);
            Assert.AreEqual(5, hypot);
        }

        [TestMethod]
        public void RightAreaSimple()
        {
            var triangle = new Triangle();
            double area = triangle.RightArea(4, 5);
            Assert.AreEqual(10, area);
        }
        [TestMethod]
        public void MissingAngleSimple()
        {
            var triangle = new Triangle();
            double angle = triangle.MissingAngle(41, 32);
            Assert.AreEqual(54, angle);
        }
        
    }

   
}
