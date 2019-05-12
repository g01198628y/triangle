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
        public void Two_Smallest_Sides_Sum_Smaller_Than_Third_Side_Would_Return_Not_Triangle_Case_One()
        {
            var triangle = new Triangle();
            var threeSidesLength = new[] { 1, 3, 5 };
            Assert.AreEqual("Not Triangle", triangle.GetTriangleType(threeSidesLength));
        }

        [TestMethod]
        public void Two_Smallest_Sides_Sum_Smaller_Than_Third_Side_Would_Return_Not_Triangle_Case_Two()
        {
            var triangle = new Triangle();
            var threeSidesLength = new[] { 1, 4, 5 };
            Assert.AreEqual("Not Triangle", triangle.GetTriangleType(threeSidesLength));
        }

        [TestMethod]
        public void Side_Length_Has_Zero_Would_Return_Not_Triangle()
        {
            var triangle = new Triangle();
            var threeSidesLength = new[] { 0, 4, 5 };
            Assert.AreEqual("Not Triangle", triangle.GetTriangleType(threeSidesLength));
        }

        [TestMethod]
        public void Side_Length_Smaller_Than_Zero_Would_Return_Not_Triangle()
        {
            var triangle = new Triangle();
            var threeSidesLength = new[] { -1, 4, 5 };
            Assert.AreEqual("Not Triangle", triangle.GetTriangleType(threeSidesLength));
        }

        [TestMethod]
        public void Two_Sides_Same_Length_Would_Return_Isosceles_Triangle_Case_One()
        {
            var triangle = new Triangle();
            var threeSidesLength = new[] { 4, 4, 5 };
            Assert.AreEqual("Isosceles Triangle", triangle.GetTriangleType(threeSidesLength));
        }

        [TestMethod]
        public void Two_Sides_Same_Length_Would_Return_Isosceles_Triangle_Case_Two()
        {
            var triangle = new Triangle();
            var threeSidesLength = new[] { 3, 5, 5 };
            Assert.AreEqual("Isosceles Triangle", triangle.GetTriangleType(threeSidesLength));
        }

        [TestMethod]
        public void Sum_of_Two_Sides_Length_Square_Smaller_Than_Third_Sides_Length_Square_Would_Return_Obtuse_Triangle()
        {
            var triangle = new Triangle();
            var threeSidesLength = new[] { 2, 3, 4 };
            Assert.AreEqual("Obtuse Triangle", triangle.GetTriangleType(threeSidesLength));
        }

        [TestMethod]
        public void Sum_of_Two_Sides_Length_Square_Bigger_Than_Third_Sides_Length_Square_Would_Return_Acute_Triangle()
        {
            var triangle = new Triangle();
            var threeSidesLength = new[] { 5, 6, 7 };
            Assert.AreEqual("Acute Triangle", triangle.GetTriangleType(threeSidesLength));
        }
    }
}