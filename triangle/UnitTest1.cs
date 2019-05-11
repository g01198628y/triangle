using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace triangle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Three_Sides_Same_Length_Would_Return_Regular_Triangle()
        {
            var triangle = new Triangle();
            var sidesLength = new[] {2, 2, 2};
            Assert.Equals("Regular Triangle", triangle.GetTriangleType());
        }
    }
}
