//Write a program that receives some info from the console about people and their phone numbers.
//You are free to choose the manner in which the data is entered; each entry should have just one name and one number 
//(both of them strings). 
//After filling this simple phonebook, upon receiving the command "search", your program should be able to perform a 
//search of a contact by name and print her details in format "{name} -> {number}". In case the contact isn't found,
//print "Contact {name} does not exist." 
//Examples:
// input                    output
//Nakov-0888080808          Contact Mariika does not exist.                          
//search                    Nakov -> 0888080808                                               
//Mariika                                                                     
//Nakov                                                                                 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Phonebook
{
    static void Main(string[] args)
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        string input = Console.ReadLine();
        while (input != "search")
        {
            string name = input.Split('-')[0];
            string phoneNumber = input.Split('-')[1];
            if (phonebook.Keys.Contains(name))
            {
                phonebook[name] = phonebook[name] + " , " + phoneNumber;
            }
            else
            {
                phonebook.Add(name, phoneNumber);
            }
            input = Console.ReadLine();
        }
        input = Console.ReadLine();
        while (!input.Equals(String.Empty))
        {
            if (phonebook.Keys.Contains(input))
            {
                Console.WriteLine("{0} -> {1}", input, phonebook[input]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", input);
            }
            input = Console.ReadLine();
        }
    }
}
