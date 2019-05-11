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
            var sidesLength = new[] {2, 2, 2};
            Assert.AreEqual("Regular Triangle", triangle.GetTriangleType(sidesLength));
        }
    }
}
