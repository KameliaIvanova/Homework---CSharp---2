/*
 * Problem 7. Selection sort
 * 
 * Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
 * Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, 
 * move it at the second position, etc.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SelectionSort
{
    class Program
    {
        static void Main()
        {
            // Input
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("A[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Selection sort
            int swap;
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        swap = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = swap;
                    }
                }
            }

            // Output
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
