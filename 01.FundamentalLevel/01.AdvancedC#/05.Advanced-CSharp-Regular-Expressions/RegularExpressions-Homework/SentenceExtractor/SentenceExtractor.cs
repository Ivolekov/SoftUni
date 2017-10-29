//Problem 4.	Sentence Extractor
//Write a program that reads a keyword and some text from the console and prints all sentences from the text, 
//containing that word. A sentence is any sequence of words ending with '.', '!' or '?'. Examples:
//Input
//is
//This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world! 
//Isn’t it great? Well it is :)
//Output
//This is my cat!
//And this is my dog.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SentenceExtractor
{
    class SentenceExtractor
    {
        static void Main(string[] args)
        {
            //This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world! Isn’t it great? Well it is :)
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            Regex reg = new Regex(@"([A-Z][\w\W]*?\s)" + word + @"(\s[\W\w]*?[.!?])");
            MatchCollection matches = reg.Matches(input);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }                   
    }
}
