/*
 * Problem 5. Maximal increasing sequence
 * 
 * Write a program that finds the maximal increasing sequence in an array.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_MaximalIncreasingSequence
{
    class Program
    {
        static void Main()
        {
            Console.Write("The length of the array: ");
            int n = int.Parse(Console.ReadLine());

            int bestSequence = 1;
            int currentSequence = 1;
            string currentNumber = "";
            string bestNumber = "";

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("array[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    currentSequence++;
                    currentNumber += arr[i] + " ";
                }
                else
                {
                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        currentNumber += arr[i] + " ";
                        bestNumber = currentNumber;
                    }
                    currentSequence = 1;
                    currentNumber = "";
                }
            }
            if (currentSequence > bestSequence)
            {
                currentNumber += arr[arr.Length - 1];
                bestNumber = currentNumber;
            }
            Console.WriteLine(bestNumber);
        }
    }
}
