using System;

namespace InterestCalculator
{
    class Program
    {
        private const int InterestCompounded = 12;

        static void Main(string[] args)
        {
            Func<decimal, decimal, int, decimal> simple = GetSimpleInterest;
            Func<decimal, decimal, int, decimal> compound = GetCompoundInterest;

            var icalc1 = new InterestCalculator(123m, 3.4m, 12, compound);
            var icalc2 = new InterestCalculator(5500m, 8.2m, 13, simple);

            Console.WriteLine(icalc1);
            Console.WriteLine(icalc2);
        }

        private static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            return sum * (decimal)Math.Pow((double)(1 + (interest / 100 / InterestCompounded)), years * InterestCompounded);
        }

        private static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            return sum * (1 + (interest / 100 * years));
        }
    }
}
