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
            double angle = triangle.MissingAngle(70, 30);
            Assert.AreEqual(80, angle);
        }
        
        [TestMethod]
        public void PerimeterSimple()
        {
            var triangle = new Triangle();
            int perimeter = triangle.Perimeter(3, 4, 5);
            Assert.AreEqual(12, perimeter);
        }

        [TestMethod]
        public void checkIsRightSimple()
        {
            var triangle = new Triangle();
            int isRight = triangle.CheckIsRight(30, 90, 60);
            Assert.AreEqual(1, isRight);
        }

        [TestMethod]
        public void isValidTriangleSimple()
        {
            var triangle = new Triangle();
            int isValid = triangle.isValidTriangle(70, 80, 90);
            Assert.AreEqual(1, isValid);
        }
    }


   
}
