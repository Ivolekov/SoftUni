using System;

namespace Problems_3_4.Generic_List_Version
{
    class GenericListVersion
    {
        static void Main()
        {
            var list = new GenericList<int> { 8, 11, 9, 11, 63, 5, 45, 9, 0 };
            list.Version();

            Console.WriteLine(list.Count);
            list.Add(1);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Contains(7));
            Console.WriteLine(list.FindIndex(9));
            list.Insert(3, 7);
            Console.WriteLine(list);
            list.Remove(5);
            Console.WriteLine(list);
            list[0] = 22;
            Console.WriteLine(list);
            list.Clear();
            Console.WriteLine(list);
        }
    }
}