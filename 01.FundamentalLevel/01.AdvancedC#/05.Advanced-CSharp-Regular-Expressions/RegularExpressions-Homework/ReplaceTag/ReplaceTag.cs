//Problem 2.Replace <a> tag
//Write a program that replaces in a HTML document given as string all the tags <a href=…>…</a>
//with corresponding tags [URL href=…]…[/URL]. Print the result on the console. Examples:
//Input
//"<ul>
// <li>
// <a href=http://softuni.bg>SoftUni</a>
// </li>
// </ul>"
//Output
//<ul>
// <li>
//  [URL href=http://softuni.bg]SoftUni[/URL]
// </li>
//</ul>
//Note: The input may be read on a single line (unlike the example above) or from a file.
//Remove all new lines if you choose the first approach

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceTag
{
    class ReplaceTag
    {
        static void Main(string[] args)
        {
            //<ul><li><a href=http://softuni.bg>SoftUni</a></li></ul>
            string input = "<ul><li><a href=http://softuni.bg>SoftUni</a></li></ul>";
            string pattern = @"<a\s+href=([^>]+)>([^<]+)</a>";
            Regex regex = new Regex(pattern);
            string replacement = "[URL href=$1]$2[/URL]";
            string result = Regex.Replace(input, pattern, replacement);
            Console.WriteLine(result);
        }                                                                   
    }                                
}                               
                           