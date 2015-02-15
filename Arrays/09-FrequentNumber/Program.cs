/*
 * Problem 9. Frequent number
 * 
 * Write a program that finds the most frequent number in an array.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_FrequentNumber
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
            int count = 1;
            int maxCount = 1;
            int countedNum = 0;

            Array.Sort(arr);

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    countedNum = arr[i];
                }
            }
            if (maxCount > 1)
            {
                Console.WriteLine("{0} ({1} times)", countedNum, maxCount);
            }
            else
            {
                Console.WriteLine("No frequancy!");
            }

        }
    }
}
