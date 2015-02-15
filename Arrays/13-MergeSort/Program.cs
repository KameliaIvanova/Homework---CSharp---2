/*
 * Problem 13.* Merge sort
 * 
 * Write a program that sorts an array of integers using the Merge sort algorithm.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_MergeSort
{
    class Program
    {
        static void MergeSort(int[] elements, int[] temp, int start, int end)
        {
            if (start >= end) return;  // Array with 1 element

            int middle = start + (end - start) / 2; // Define a middle of the array

            MergeSort(elements, temp, start, middle);
            MergeSort(elements, temp, middle + 1, end);
            CompareAndSort(elements, temp, start, middle, end);
        }

        static void CompareAndSort(int[] elements, int[] temp, int start, int middle, int end)
        {
            int i = start; // 'temp' index
            int l = start, m = middle + 1; // 'elements' indexes

            while (l <= middle && m <= end)
                temp[i++] = (elements[l] > elements[m]) ? elements[m++] : elements[l++];

            while (l <= middle) temp[i++] = elements[l++];

            while (m <= end) temp[i++] = elements[m++];

            for (int j = start; j <= end; j++) elements[j] = temp[j];
        }
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            Console.WriteLine("Enter {0} number(s) to array: ", n);

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            int[] tmp = new int[n];

            Console.WriteLine("Before sorting: {0}", string.Join(", ", nums));

            MergeSort(nums, tmp, 0, nums.Length - 1);

            Console.WriteLine("After sorting: {0}", string.Join(", ", nums));
        }
    }
}
