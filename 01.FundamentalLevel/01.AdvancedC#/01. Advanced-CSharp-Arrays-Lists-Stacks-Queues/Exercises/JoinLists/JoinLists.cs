using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            
            List<int> firstNums = firstInput.Split(' ').Select(int.Parse).ToList();
            List<int> secondNums = secondInput.Split(' ').Select(int.Parse).ToList();
            
            firstNums.AddRange(secondNums);
            
            SortedSet<int> a = new SortedSet<int>(firstNums);
            Console.WriteLine();
            foreach (var n in a)
            {
                Console.Write("{0} ", n);
            }
            
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
