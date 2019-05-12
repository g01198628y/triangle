using System;

namespace triangle
{
    public class Triangle
    {
        public string GetTriangleType(int[] threeSidesLength)
        {
            Array.Sort(threeSidesLength);
            if (!IsMatchTriangleCondition(threeSidesLength)) return "Not Triangle";

            if (threeSidesLength[0] == threeSidesLength[1])
            {
                return threeSidesLength[1] == threeSidesLength[2] ? "Regular Triangle" : "Isosceles Triangle";
            }
            return string.Empty;
        }

        private static bool IsMatchTriangleCondition(int[] threeSidesLength)
        {
            return threeSidesLength[0] + threeSidesLength[1] > threeSidesLength[2];
        }
    }
}