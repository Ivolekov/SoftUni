//Write a program that converts a string to a sequence of C# Unicode character literals. 
//Examples:
//Input	      Output
//Hi!	      \u0048\u0069\u0021
//What?!?	  \0057\0068\0061\0074\003f\0021\003f
//SoftUni	  \0053\006f\0066\0074\0055\006e\0069

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            for (int i = 0; i < input.Length; i++)
            {
                int unicode = 0;
                unicode += input[i];
                Console.Write("\\u" + unicode.ToString("X4"));
            }       
            Console.WriteLine();
        }
    }
}
