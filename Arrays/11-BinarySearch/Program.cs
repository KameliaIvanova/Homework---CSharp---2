/*
 * Problem 11. Binary search
 * 
 * Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_BinarySearch
{
    class Program
    {
        static int BinarySearch(int[] arr, int k)
        {
            Array.Sort(arr);

            int first = 0;
            int last = arr.Length - 1;

            while (last >= first)
            {
                int middle = (first + last) / 2;
                if (arr[middle] < k)
                {
                    first = middle + 1;
                }
                else if (arr[middle] > k)
                {
                    last = middle - 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(BinarySearch(arr, k));
        }
    }
}
