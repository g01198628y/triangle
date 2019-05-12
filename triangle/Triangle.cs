using System;
using System.Linq;

namespace triangle
{
    public class Triangle
    {
        public string GetTriangleType(int[] threeSidesLength)
        {
            Array.Sort(threeSidesLength);

            if (!IsMatchTriangleCondition(threeSidesLength)) return "Not Triangle";

            if (AnyTwoSidesLengthEqual(threeSidesLength))
            {
                return IsRegularTriangle(threeSidesLength) ? "Regular Triangle" : "Isosceles Triangle";
            }

            return JudgeTypeByAngle(threeSidesLength);
        }

        private static bool IsRegularTriangle(int[] threeSidesLength)
        {
            return (decimal)threeSidesLength.Sum() / 3 == threeSidesLength[0];
        }

        private string JudgeTypeByAngle(int[] threeSidesLength)
        {
            var sqrt = Math.Sqrt(Math.Pow(threeSidesLength[0], 2) + Math.Pow(threeSidesLength[1], 2));

            if (sqrt == threeSidesLength[2])
            {
                return "Right Triangle";
            }
            return sqrt < threeSidesLength[2] ? "Obtuse Triangle" : "Acute Triangle";
        }

        private static bool AnyTwoSidesLengthEqual(int[] threeSidesLength)
        {
            return threeSidesLength.Distinct().Count() <= 2;
        }

        private static bool IsMatchTriangleCondition(int[] threeSidesLength)
        {
            return threeSidesLength[0] + threeSidesLength[1] > threeSidesLength[2];
        }
    }
}