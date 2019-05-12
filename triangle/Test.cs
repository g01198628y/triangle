using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace triangle
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Three_Sides_Same_Length_Would_Return_Regular_Triangle()
        {
            var triangle = new Triangle();
            var threeSidesLength = new[] { 2, 2, 2 };
            Assert.AreEqual("Regular Triangle", triangle.GetTriangleType(threeSidesLength));
        }

        [TestMethod]
        public void Two_Smallest_Sides_Sum_Smaller_than_Third_Side_Would_Return_Not_Triangle()
        {
            var triangle = new Triangle();
            var threeSidesLength = new[] { 1, 3, 5 };
            Assert.AreEqual("Not Triangle", triangle.GetTriangleType(threeSidesLength));
        }
    }
}