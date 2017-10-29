//Problem 1.	Bigger Number
//Write a method GetMax() with two parameters that returns the larger of two integers. Write a program that reads 
//2 integers from the console and prints the largest of them using the method GetMax().
// Input	Output
// 4        4
// -5	    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNumber
{
    class BiggerNumber
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);
            Console.WriteLine(max);
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            int c = Math.Max(firstNumber, secondNumber);
            return c;
        }
    }
}
