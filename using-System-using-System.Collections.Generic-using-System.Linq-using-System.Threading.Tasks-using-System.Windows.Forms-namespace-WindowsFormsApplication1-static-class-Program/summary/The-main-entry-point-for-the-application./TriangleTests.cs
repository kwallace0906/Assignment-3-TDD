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
            double hypot = triangle.Hypotenuse(4, 5);
            Assert.AreEqual(0, hypot);
        }
    }
}


