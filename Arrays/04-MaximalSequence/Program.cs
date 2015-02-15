/*
 * Problem 4. Maximal sequence
 * 
 * Write a program that finds the maximal sequence of equal elements in an array.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MaximalSequence
{
    class Program
    {
        static void Main()
        {
            // Input
            Console.Write("How many elements do you want to have the sequence? ");
            int numbersOfElements = int.Parse(Console.ReadLine());

            int[] arr = new int[numbersOfElements];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            // Compare elements
            int bestSeq = 1;
            int currSeq = 1;
            int bestNum = 0;

            for (int i = 0; i < numbersOfElements - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    currSeq++;
                }
                else
                {
                    currSeq = 1;
                }
                if (currSeq >= bestSeq)
                {
                    bestSeq = currSeq;
                    bestNum = arr[i];
                }
            }
            for (int i = 0; i < bestSeq; i++)
            {
                Console.Write("{0} ", bestNum);
            }
            Console.WriteLine();
        }
    }
}
