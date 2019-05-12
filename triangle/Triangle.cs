using System;

namespace triangle
{
    public class Triangle
    {
        public string GetTriangleType(int[] threeSidesLength)
        {
            Array.Sort(threeSidesLength);
            if (threeSidesLength[0] + threeSidesLength[1] > threeSidesLength[2])
            {
                if (threeSidesLength[0] == threeSidesLength[1] && threeSidesLength[1] == threeSidesLength[2])
                {
                    return "Regular Triangle";
                }

                return string.Empty;
            }

            return "Not Triangle";
        }
    }
}