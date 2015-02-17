/*
 * Problem 1. Fill the matrix
 * 
 * Write a program that fills and prints a matrix of size (n, n) as shown below:
 * 
 * 1	8	9	16
 * 2	7	10	15
 * 3	6	11	14
 * 4	5	12	13
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FillTheMatrixB
{
    class Program
    {
        static void Main()
        {
            // Length of the matrix
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            // Algorithm
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = row + col * n + 1;
                    }
                }
                else
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = (col + 1) * n - row;
                    }
                }
            }

            // Print the matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
