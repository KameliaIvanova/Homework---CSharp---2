/*
 * Problem 8. Maximal sum
 * 
 * Write a program that finds the sequence of maximal sum in given array.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MaximalSum
{
    class Program
    {
        static void Main()
        {
            // Input
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Algorithm
            int currentSum = arr[0];
            int startIndex = 0;
            int endIndex = 0;
            int tempIndex = 0;
            int maxSum = arr[0];

            for (int i = 0; i < n; i++)
            {
                if (currentSum <= 0)
                {
                    startIndex = i;
                    currentSum = 0;
                }

                currentSum += arr[i];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    tempIndex = startIndex;
                    endIndex = i;
                }
            }
            Console.Write("The best sequence is: ");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The max sum is: {0}", maxSum);
        }
    }
}
