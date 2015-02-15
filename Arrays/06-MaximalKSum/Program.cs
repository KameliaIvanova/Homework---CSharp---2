/*
 * Problem 6. Maximal K sum
 * 
 * Write a program that reads two integer numbers N and K and an array of N elements from the console.
 * Find in the array those K elements that have maximal sum.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MaximalKSum
{
    class Program
    {
        static void Main()
        {
            // Input
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("array[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Algorithm
            int bestSum = 0;
            int currentSum = 0;
            for (int i = 0; i <= n - k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    currentSum += arr[i + j];
                }
                if (currentSum >= bestSum)
                {
                    bestSum = currentSum;
                    currentSum = 0;
                }
            }
            Console.WriteLine("Max sum = " + bestSum);
        }
    }
}
