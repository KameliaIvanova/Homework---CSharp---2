/*
 * Problem 4. Appearance count
 * 
 * Write a method that counts how many times given number appears in given array.
 * Write a test program to check if the method is workings correctly.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AppearanceCount
{
    class Program
    {
        static void Main()
        {
            // Input
            Console.Write("length = ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Print the matrix
            for (int i = 0; i < length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            // Number to check
            Console.Write("Write a number to check: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The number {0} appears in this array {1} time/s.", number, CountTimes(arr, number));
        }

        static int CountTimes(int[] arr, int number)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
