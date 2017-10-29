//Problem 2.	String Length
//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less 
//than 20, the rest of the characters should be filled with *. Print the resulting string on the console.
//Examples:
//Input	                                                                   Output
//Welcome to SoftUni!	                                                   Welcome to SoftUni!*
//a regular expression (abbreviated regex or regexp and sometimes          a regular expression
//called a rational expression) is a sequence of characters 
//that forms a search pattern	                    
//C#	                                                                   C#******************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Length > 20)
            {
               Console.WriteLine(input.Remove(20));
            }
            else
            {
                Console.WriteLine(input.PadRight(20,'*'));
            }
        }
    }
}
