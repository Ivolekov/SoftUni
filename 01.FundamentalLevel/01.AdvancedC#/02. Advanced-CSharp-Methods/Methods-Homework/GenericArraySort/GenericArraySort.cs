//Problem 7.	* Generic Array Sort
//Write a method which takes an array of any type and sorts it. Use bubble sort or selection sort (your own implementation).
//You may re-use your code from a previous homework and modify it. 
//Use a generic method (read in Internet about generic methods in C#). 
//Make sure that what you're trying to sort can be sorted – your method should work with numbers, strings, dates, etc., 
//but not necessarily with custom classes like Student.

//int[] numbers = {1, 3, 4, 5, 1, 0, 5};
//string[] strings = {"zaz", "cba", "baa", "azis"};
//DateTime[] dates = {new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1),};


using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArraySort
{
    class GenericArraySort
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 3, 4, 5, 1, 0, 5};
            string[] strings = {"zaz", "cba", "baa", "azis"};
            DateTime[] dates =
            {
                new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1)
            };
            SortArray(numbers);
            SortArray(strings);
            SortArray(dates);
        }

        static void SortArray(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void SortArray(DateTime[] array)
        {
            DateTime temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

       public static void SortArray(string[] array)
        {
           Array.Sort(array);
           
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }        
    }
}