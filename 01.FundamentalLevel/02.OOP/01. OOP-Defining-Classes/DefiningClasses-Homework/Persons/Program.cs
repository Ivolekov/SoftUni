using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person kiro = new Person("Kiro", 22, "kiro@abv.bg");
            Person sasho = new Person("Sasho", 32);

            Console.WriteLine(kiro);
            Console.WriteLine(sasho);

        }
    }
}
