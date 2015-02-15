/*
 * Problem 10. Find sum in array
 * 
 * Write a program that finds in given array of integers a sequence of given sum S (if present).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_FindSumInArray
{
    class Program
    {
        static void Main()
        {
            Console.Write("Length n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Sum s = ");
            int s = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int currentSum = 0;
            int startIndex = 0;

            for (int i = 0; i < n - 1; i++)
            {
                currentSum += arr[i];
                startIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    currentSum += arr[j];
                    if (currentSum == s)
                    {
                        for (int k = startIndex; k <= j; k++)
                        {
                            Console.Write("{0} ", arr[k]);
                        }
                        break;
                    }
                }
                currentSum = 0;
            }
        }
    }
}
