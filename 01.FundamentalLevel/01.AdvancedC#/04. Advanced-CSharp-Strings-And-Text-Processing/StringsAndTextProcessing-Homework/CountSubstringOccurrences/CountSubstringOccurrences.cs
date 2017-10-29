//Problem 3.	Count Substring Occurrences
//Write a program to find how many times a given string appears in a given text as substring. The text is given at the 
//first input line. The search string is given at the second input line. The output is an integer number. Please ignore
//the character casing. Overlapping between occurrences is allowed. 
//Examples:
//Input	                                                   Output
//Welcome to the Software University (SoftUni)!              4
//Welcome to programming. Programming is wellness 
//for developers, said Maxwell.
//wel	

//aaaaaa                                                     5
//aa	
//ababa caba                                                 3
//aba	
//Welcome to SoftUni                                         0
//Java


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string stringToFind = Console.ReadLine();
            int possition = text.IndexOf(stringToFind);
            int foundStrings = 0;

            while (possition >= 0 && possition <= text.Length)
            {
                foundStrings++;
                possition = text.IndexOf(stringToFind, possition + 1);

            }
            Console.WriteLine(foundStrings);
        }
    }
}
