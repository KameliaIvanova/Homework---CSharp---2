/*
 * Problem 1. Fill the matrix
 * 
 * Write a program that fills and prints a matrix of size (n, n) as shown below:
 * 
 * 1	12	11	10
 * 2	13	16	9
 * 3	14	15	8
 * 4	5	6	7
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FillTheMatrixD
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
            {
                int number = 1; for (int i = 0; i < n; i++) // get top rows and cols
                {
                    for (int j = i; j < n - i; j++)
                    {
                        matrix[i, j] = number;
                        number++;

                    }

                    for (int j = 0; j < n - 1 - i * 2; j++) // get right coloumns 
                    {
                        matrix[j + 1 + i, n - i - 1] = number;
                        number++;
                    }


                    for (int j = 0; j < n - 1 - i * 2; j++) // get botom rows and cols
                    {
                        matrix[n - 1 - i, n - j - 2 - i] = number;
                        number++;
                    }


                    for (int j = 0; j < n - 2 - i * 2; j++) //get left cols
                    {
                        matrix[n - j - 2 - i, i] = number;
                        number++;
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
