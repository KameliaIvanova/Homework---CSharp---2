/*
 * Problem 5. Maximal area sum
 * Write a program that reads a text file containing a square matrix of numbers.
 * Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
 * The first line in the input file contains the size of matrix N.
 * Each of the next N lines contain N numbers separated by space.
 * The output should be a single number in a separate text file.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05_MaximalAreaSum
{
    class MaximalAreaSum
    {
        static int[,] ReadMatrix() // Метод, който чете от файл матрица
        {
            using (var input = new StreamReader(@"..\..\..\Problem5-Matrix.txt")) // 
            {
                int n = int.Parse(input.ReadLine());
                int[,] matrix = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    string[] numbers = input.ReadLine().Split(' '); // чете от стринга и изключва ' ' 

                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = int.Parse(numbers[j]);
                    }
                }

                return matrix;
            }
        }

        static int GetMax(int[,] matrix) // Метод, който намира максималната сума
        {
            int maxSum = int.MinValue;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    maxSum = Math.Max(maxSum, matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1]);
                }
            }
            return maxSum;
        }

        static void WriteResult(int maxSum) // Метод, който записва резултата в нов файл
        {
            using (var output = new StreamWriter(@"..\..\..\Problem5-Result.txt"))
            {
                output.WriteLine(maxSum);
            }
        }


        static void Main()
        {
            WriteResult(GetMax(ReadMatrix()));
        }
    }
}
