//Problem 2.	Last Digit of Number
//Write a method that returns the last digit of a given integer as an English word. Test the method with different 
//input values. Ensure you name the method properly.
//Sample Code	                                           Output
//Console.WriteLine(GetLastDigitAsWord(512));              two
//Console.WriteLine(GetLastDigitAsWord(1024));             four
//Console.WriteLine(GetLastDigitAsWord(12309));            nine

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitOfNumber
{
    class LastDigitOfNumber
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            GetLastDigitAsWord(inputNumber);
        }

        static void GetLastDigitAsWord(int number)
        {
            int lastDigit = number % 10;
            switch (lastDigit)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
            }
        }
    }
}
