/*
 * Problem 1. Fill the matrix
 * 
 * Write a program that fills and prints a matrix of size (n, n) as shown below:
 * 
 * 7	11	14	16
 * 4	8	12	15
 * 2	5	9	13
 * 1	3	6	10
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FillTheMatrixC
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
            int row = n - 1;
            int col = 0;
            int data = 0;

            for (int i = 0; i < n; i++)
            {
                do
                {
                    data++;
                    if (row < 0)
                    {
                        row = 0;
                    }
                    matrix[row, col] = data;
                    row++;
                    col++;
                } while (row < n);

                row -= col + 1;
                col = 0;
            }

            row = 0;
            col = 1;
            for (int i = 0; i < n - 1; i++)
            {
                do
                {
                    data++;
                    matrix[row, col] = data;
                    row++;
                    col++;
                } while (col < n);

                col -= row - 1;
                row = 0;
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
