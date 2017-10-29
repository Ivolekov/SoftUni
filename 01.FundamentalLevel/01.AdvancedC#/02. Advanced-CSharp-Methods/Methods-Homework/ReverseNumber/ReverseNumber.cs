//Write a method that reverses the digits of a given floating-point number.

using System;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            Console.WriteLine(GetReversedNumber(input));
        }

        static double GetReversedNumber(double number)
        {
            string num = number.ToString();
            char[] reversed = num.ToCharArray();
            Array.Reverse(reversed);
            string charArray = new string(reversed);
            double floatingPoint = double.Parse(charArray);
            return floatingPoint;
        }
    }
}
