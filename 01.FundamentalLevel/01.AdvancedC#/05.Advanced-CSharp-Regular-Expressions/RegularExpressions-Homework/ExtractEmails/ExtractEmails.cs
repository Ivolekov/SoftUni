//Problem 3.	Extract Emails
//Write a program to extract all email addresses from a given text. The text comes at the only input line. 
//Print the emails on the console, each at a separate line. Emails are considered to be in format <user>@<host>, where: 
//•	<user> is a sequence of letters and digits, where '.', '-' and '_' can appear between them. Examples of valid users: "stephan", "mike03", "s.johnson", "st_steward", "softuni-bulgaria", "12345". Examples of invalid users: ''--123", ".....", "nakov_-", "_steve", ".info". 
//•	<host> is a sequence of at least two words, separated by dots '.'. Each word is sequence of letters and can have hyphens '-' between the letters. Examples of hosts: "softuni.bg", "software-university.com", "intoprogramming.info", "mail.softuni.org". Examples of invalid hosts: "helloworld", ".unknown.soft.", "invalid-host-", "invalid-". 
//•	Examples of valid emails: info@softuni-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com, s.peterson@mail.uu.net, info-bg@software-university.software.academy. 
//•	Examples of invalid emails: --123@gmail.com, …@mail.bg, .info@info.info, _steve@yahoo.cn, mike@helloworld, mike@.unknown.soft., s.johnson@invalid-.
//Examples:
//Input	                                                                                   Output
//Please contact us at: support@github.com.	                                               support@github.com
//Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.	   s.miller@mit.edu
//                                                                                         j.hopking@york.ac.uk
//Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality
//training @ home or @ class. –- steve.parker@softuni.de.	                               steve.parker@softuni.de

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //string input = "Please contact us at: support@github.com. _steve@yahoo.cn";
            Regex reg = new Regex(@"\s([a-z]{1}[\w\.+-]*)@[a-z-]+\.[a-z\.]+[a-z]{1}");
            MatchCollection matches = reg.Matches(input);
            foreach (var match in matches)
            {
                Console.WriteLine(match.ToString().TrimStart());
            }
        }
    }
}
