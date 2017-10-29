//Problem 1.	Series of Letters
//Write a program that reads a string from the console and replaces all
//series of consecutive identical letters with a single one.
//Input	                    Output
//aaaaabbbbbcdddeeeedssaa  	abcdedsa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var regex = new Regex("(.)\\1+");
            Console.WriteLine(regex.Replace(input, "$1"));
        }
    }
}
