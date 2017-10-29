//Problem 3.	Larger Than Neighbours
//Write a method that checks if the element at given position in a given array of integers is larger than its two 
//neighbours (when such exist).
// 1 3 4 5 0 5
//int[] numbers = {1,3,4,5,0,5};
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(IsLargerThanNeighbours(number, i));
//}
//Output
//False
//False
//False
//True
//False
//False
//True

using System;
using System.Linq;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers, i));
            }
        }

        static bool IsLargerThanNeighbours(int[] numbers, int i)
        {
            bool isLarger;

            if (i == 0)
            {
                isLarger = numbers[i + 1] < numbers[i];
            }
            else if (i > 0 && i < numbers.Length - 1)
            {
                isLarger = numbers[i + 1] < numbers[i] && numbers[i - 1] < numbers[i];
            }
            else
            {
                isLarger = numbers[i - 1] < numbers[i];
            }
            return isLarger;
        }
    }
}
