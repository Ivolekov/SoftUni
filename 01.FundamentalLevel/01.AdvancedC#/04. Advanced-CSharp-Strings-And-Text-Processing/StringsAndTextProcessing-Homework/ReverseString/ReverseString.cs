//Write a program that reads a string from the console, reverses it and prints the result back at the console.
//sample	    elpmas
//24tvcoi92	    29iocvt42

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = input.Length-1; i > -1 ; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
    }
}
