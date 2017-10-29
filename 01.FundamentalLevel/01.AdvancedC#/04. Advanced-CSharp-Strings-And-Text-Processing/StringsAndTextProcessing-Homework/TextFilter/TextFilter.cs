//Write a program that takes a text and a string of banned words. All words included in the ban list should be replaced 
//with asterisks "*", equal to the word's length. The entries in the ban list will be separated by a comma and space ", ".
//The ban list should be entered on the first input line and the text on the second input line. 
//Example:

//Input
//Linux, Windows
//It is not kkLinuxkkk, it is GNU/Linux. Linux is merely the kernel, 
//while GNU adds the functionality. Therefore we owe it to them by
//calling the OS GNU/Linux! Sincerely, a Windows client
//Output
//It is not *****, it is GNU/*****. ***** is merely the kernel, 
//while GNU adds the functionality. Therefore we owe it to them 
//by calling the OS GNU/*****! Sincerely, a ******* client

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] {',',' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] text = Console.ReadLine().Split(' ');
            string output = "";
            for (int i = 0; i < text.Length; i++)
            {
                string outputWord = "";
                string currentWord = text[i];

                for (int j = 0; j < bannedWords.Length; j++)
                {
                    string ban = bannedWords[j];

                    if (currentWord.IndexOf(ban) != -1)
                    {
                        outputWord += currentWord.Replace(ban, new string('*', ban.Length));
                        outputWord += ' ';
                        break;
                    }
                }

                if (outputWord == "")
                {
                    outputWord += currentWord + ' ';

                }
                output += outputWord;
            }
            Console.WriteLine(output);
        }
    }
}
