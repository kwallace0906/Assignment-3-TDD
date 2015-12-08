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

        
    }

   
}
