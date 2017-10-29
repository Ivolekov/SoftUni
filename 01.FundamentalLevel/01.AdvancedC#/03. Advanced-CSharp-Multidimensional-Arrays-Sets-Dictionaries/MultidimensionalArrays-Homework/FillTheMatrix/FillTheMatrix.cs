//Problem 1.	Fill the Matrix
//Write two programs that fill and print a matrix of size N x N. Filling a matrix in the regular pattern 
//(top to bottom and left to right) is boring. Fill the matrix as described in both patterns below:
// 1 5 9  13         1  8  9  16               
// 2 6 10 14         2  7  10 15              
// 3 7 11 15         3  6  11 14         
// 4 8 12 16         4  5  12 13 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Make youre choice A or B: ");
            string choice = Console.ReadLine();
            int[,] matrix = new int[4,4];
            int element = 1;
            
            switch (choice)
            {
                case "A":
                    for (int row = 0; row < 4; row++)
                    {
                        for (int col = 0; col < 4; col++)
                        {
                            matrix[row, col] = element;
                            element += 4;
                        }
                        element -= 15;
                    }
                    //Print the Matrix
                    for (int row = 0; row < 4; row++)
                    {
                        for (int col = 0; col < 4; col++)
                        {
                            Console.Write("{0,4}", matrix[row, col]);
                        }
                        Console.WriteLine();
                    }
                    break;
                case "B":
                    for (int col = 0; col < 4; col++)
                    {
                        if (col%2 == 0)
                        {
                            for (int row = 0; row < 4; row++)
                            {
                                matrix[row, col] = element;
                                element++;
                            }
                        }
                        else
                        {
                            for (int row = 4 - 1; row >= 0; row--)
                            {
                                matrix[row, col] = element;
                                element++;
                            }
                        }
                    }
                    
                    //Print the Matrix
                    for (int row = 0; row < 4; row++)
                    {
                        for (int col = 0; col < 4; col++)
                        {
                            Console.Write("{0,4}", matrix[row, col]);
                        }
                        Console.WriteLine();
                    }
                    break;
            }
        }
    }
}
