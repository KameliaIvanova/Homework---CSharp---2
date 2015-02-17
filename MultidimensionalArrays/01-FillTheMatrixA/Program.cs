/*
 * Problem 1. Fill the matrix
 * 
 * Write a program that fills and prints a matrix of size (n, n) as shown below:
 * 
 * 1	5	9	13
 * 2	6	10	14
 * 3	7	11	15
 * 4	8	12	16
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FillTheMatrixA
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
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = 1 + j * n + i;
                }
            }

            // Print the matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}", matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
