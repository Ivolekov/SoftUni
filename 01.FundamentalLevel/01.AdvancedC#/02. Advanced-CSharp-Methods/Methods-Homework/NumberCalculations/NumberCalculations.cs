//Problem 6.	Number Calculations
//Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers. 
//Overload the methods to work with numbers of type double and decimal.
//Note: Do not use LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCalculations
{
    class NumberCalculations
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           // double[] numSet = input.Split(' ').Select(double.Parse).ToArray();
            decimal[] numSet = input.Split(' ').Select(decimal.Parse).ToArray();

            Console.WriteLine("Min value ----> {0}", GetMin(numSet));
            Console.WriteLine("Max value ----> {0}", GetMax(numSet));
            Console.WriteLine("Sum value ----> {0}", GetSum(numSet));
            Console.WriteLine("Avg value ----> {0}", GetAvarage(numSet));
            Console.WriteLine("Product value ----> {0}", GetProduct(numSet));
        }

        static double GetMin(double[] array)
        {
            double min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }

        static decimal GetMin(decimal[] array)
        {
            decimal min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }

        static double GetMax(double[] array)
        {
            double max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        static decimal GetMax(decimal[] array)
        {
            decimal max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        static double GetSum(double[] array)
        {
            double sum = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static decimal GetSum(decimal[] array)
        {
            decimal sum = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static double GetProduct(double[] array)
        {
            double product = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }
        static decimal GetProduct(decimal[] array)
        {
            decimal product = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }
        static double GetAvarage(double[] array)
        {
            double avarage = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                avarage += array[i];
            }
            avarage /= array.Length;
            return avarage;
        }
        static decimal GetAvarage(decimal[] array)
        {
            decimal avarage = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                avarage += array[i];
            }
            avarage /= array.Length;
            return avarage;
        }
    }
}
