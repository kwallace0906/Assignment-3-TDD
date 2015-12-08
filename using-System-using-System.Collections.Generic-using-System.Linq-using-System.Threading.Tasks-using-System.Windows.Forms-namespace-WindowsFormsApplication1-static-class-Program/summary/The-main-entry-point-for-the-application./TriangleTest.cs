using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTriangle;

namespace MyTriangle.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void HypotenuseSimple()
        {
            var triangle = new Triangle();
            double hypot = triangle.Hypotenuse(3, 4);
            Assert.AreEqual(5, hypot);
        }

        [TestMethod]
        public void AreaSimple()
        {
            var triangle = new Triangle();
            double area = triangle.Area(4, 5);
            Assert.AreEqual(12, area);
        }
    }

   
}
