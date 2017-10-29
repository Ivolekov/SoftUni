//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SortArrayOfNumbersUsingBubbleSort
//{
//    class BubbleSort
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            int[] num = input.Split(' ').Select(int.Parse).ToArray();

//            int temp;
//            for (int i = 0; i < num.Length; i++)
//            {
//                for (int j = 0; j < num.Length - 1; j++)
//                {
//                    if (num[j] > num[j + 1])
//                    {
//                        temp = num[j + 1];
//                        num[j + 1] = num[j];
//                        num[j] = temp;
//                    }
//                }
//            }
//            for (int i = 0; i < num.Length; i++)
//            {
//                Console.Write(num[i] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

using System;

class MainClass
{
    static void Main()
    {
        string[] s = { "Bill", "Gates", "James", "Apple", "Net", "Java" };

        try
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length - 1; j++)
                {
                    for (int k = 0; k < s.Length; k++)
                        if (s[j][k] > s[j + 1][k])
                        {
                            string temp = s[j];
                            s[j] = s[j + 1];
                            s[j + 1] = temp;
                        }

                }
            }
        }

        catch (Exception)
        {

        }

        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine(s[i] + " ");
        }
    }
}