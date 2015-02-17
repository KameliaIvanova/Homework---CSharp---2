/*
 * Problem 2. Maximal sum
 * 
 * Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MaximalSum
{
    class Program
    {
        static void Main()
        {
            // Input
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            // Elements from the console
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("matrix[{0}, {1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            // Print the elements 
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,4}", matrix[col,row]);
                }
                Console.WriteLine();
            }

            // Algorithm
            if (n < 3 || m < 3)
            {
                Console.WriteLine("Wrong input!");
            }
            else if (n == 3 && m == 3)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        sum += matrix[row, col];
                    }
                }

                Console.WriteLine("Max sum = " + sum);
            }
            else
            {
                int sum = matrix[0, 0] + matrix[0, 1] + matrix[0, 2] + matrix[1, 0] + matrix[1, 1] + matrix[1, 2] + matrix[2, 0] + matrix[2, 1] + matrix[2, 2];
                for (int row = 0; row < matrix.GetLength(0) - 2; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                    {
                        int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                         matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                         matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                        if (sum < currentSum)
                        {
                            sum = currentSum;
                        }
                    }
                }

                Console.WriteLine("Max sum = " + sum);
            }
        }
    }
}
