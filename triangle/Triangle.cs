using System;
using System.Linq;

namespace triangle
{
    public class Triangle
    {
        private double _sqrt;

        public string GetTriangleType(int[] threeSidesLength)
        {
            Array.Sort(threeSidesLength);

            if (!IsMatchTriangleCondition(threeSidesLength)) return "Not Triangle";

            if (AnyTwoSidesLengthEqual(threeSidesLength))
            {
                return (decimal)threeSidesLength.Sum() / 3 == threeSidesLength[0] ? "Regular Triangle" : "Isosceles Triangle";
            }

            _sqrt = Math.Sqrt(Math.Pow(threeSidesLength[0], 2) + Math.Pow(threeSidesLength[1], 2));

            if (_sqrt < threeSidesLength[2])
            {
                return "Obtuse Triangle";
            }

            if (_sqrt > threeSidesLength[2])
            {
                return "Acute Triangle";
            }

            return string.Empty;
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