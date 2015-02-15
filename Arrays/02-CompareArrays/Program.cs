/*
 * Problem 2. Compare arrays
 * 
 * Write a program that reads two integer arrays from the console and compares them element by element.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CompareArrays
{
    class Program
    {
        static void Main()
        {
            // Input
            Console.Write("Length for the first array: ");
            int lengthArrayOne = int.Parse(Console.ReadLine());
            Console.Write("Length for the second array: ");
            int lengthArrayTwo = int.Parse(Console.ReadLine());

            // Arrays
            int[] firstArray = new int[lengthArrayOne];
            int[] secondArray = new int[lengthArrayTwo];

            // Elements for arrays from the console
            Console.WriteLine("Elements for the first array: ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Elements for the second array: ");
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            // Compare their lengths
            if (firstArray.Length != secondArray.Length)
            {
                Console.WriteLine("They have different lengths!");
            }
            else
            {
                // Compare their elements
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine("They have different elements!");
                        return;
                    }
                }
                Console.WriteLine("Both have the same elements!");
            }
        }
    }
}
