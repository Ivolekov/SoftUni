using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var list = new GenericList<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(list.Count);
            list.Add(1);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Contains(11));
            Console.WriteLine(list.FindIndex(3));
            list.Insert(0, 5);
            Console.WriteLine(list);
            list.Remove(0);
            Console.WriteLine(list);
            list.Clear();
            Console.WriteLine(list);
        }
    }
}