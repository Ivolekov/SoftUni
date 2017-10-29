//Problem 4.	First Larger Than Neighbours
//Write a method that returns the index of the first element in array that is larger than its neighbours, 
//or -1 if there's no such element. Use the method from the previous exercise in order to re.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLarger_4
{
    class FirstLarger_4
    {
        static int[] arr;

        static bool GetFirstLarger(int idx)
        {
            bool firstLarger;
            if (idx == 0)
            {
                firstLarger = arr[idx] > arr[idx + 1];
            }
            else if (idx == arr.Length - 1)
            {
                firstLarger = arr[idx] > arr[idx - 1];
            }
            else
            {
                firstLarger = arr[idx] > arr[idx - 1] && arr[idx] > arr[idx + 1];
            }
            return firstLarger;
        }
        static void Main(string[] args)
        {
            string inputArray = Console.ReadLine();
            arr = inputArray.Split().Select(int.Parse).ToArray();
            bool isGreater = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (GetFirstLarger(i))
                {
                    Console.WriteLine("First Larger element is {0}", i);
                    isGreater = true;
                    break;
                }
            }
            if (!isGreater)
            {
                Console.WriteLine("-1");
            }
        }
    }
}
