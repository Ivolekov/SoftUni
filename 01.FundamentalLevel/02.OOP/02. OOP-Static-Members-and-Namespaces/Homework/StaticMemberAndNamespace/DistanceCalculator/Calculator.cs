using System;
using System.Linq;

namespace DistanceCalculator
{
    public class Calculator
    {
        public static void Main()
        {
            try
            {
                double[] points = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();
                DistanceCalculator.CalculateTheDistance(points[0], points[1], points[2]);
            }
            catch (FormatException)
            {
                return;
            }
        }
    }
}
