//You have some text that contains your email address. You’re sick of spammers, so you want to hide it. 
//You decide to replace all characters in it with asterisks ('*') except the domain. Assume the email address
//will always be in format [username]@[domain]; you’ll need to replace username with asterisks of equal length 
//and keep the domain unchanged. 
//In the example below, your email is given on the first line and the text is given on the second line.
//In order to accomplish the task, you may find these steps useful:
//•	Split the email into two parts – username and domain
//•	Create the replacement string by concatenating a string containing '*' (with length equal to username.Length)
//with '@' and the domain.
//•	Replace all occurrences of your email with the replacement string.
//Input
//pesho.peshev@email.bg
//My name is Pesho Peshev. I am from Sofia, my email is: 
//pesho.peshev@email.bg (not pesho.peshev@email.com). 
//Test: pesho.meshev@email.bg, pesho.peshev@email.bg
//Output
//My name is Pesho Peshev. I am from Sofia, my email is:
//************@email.bg (not pesho.peshev@email.com). 
//Test: pesho.meshev@email.bg, ************@email.bg

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensorYourEmailAddress
{
    class CensorYourEmailAddress
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string text = Console.ReadLine();

            int lenghtOfUsername = email.IndexOf("@");
            string replacemend = new string('*', lenghtOfUsername) + email.Substring(lenghtOfUsername);
            text = text.Replace(email, replacemend);
            Console.WriteLine(text);
        }
    }
}
