//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe and prints them on the console 
//on a single line, separated by comma and space. Use spaces, commas, dots, question marks and exclamation marks as 
//word delimiters. Print only unique palindromes, sorted lexicographically.
//Example:
//Hi,exe? ABBA! Hog fully a string. Bob	a, ABBA, exe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {',', '.', '?', '!', ' '}, 
                StringSplitOptions.RemoveEmptyEntries);
            
            SortedSet<string> output = new SortedSet<string>();
            
            for (int i = 0; i < input.Length; i++)
            {
                string reversed = ReverseString(input[i]);
                if (input[i] == reversed)
                {
                    output.Add(input[i]);
                }
            }
            foreach (var polindromes in output)
            {
                Console.Write("{0}, ", polindromes);
            }
            Console.WriteLine();
        }

        static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
