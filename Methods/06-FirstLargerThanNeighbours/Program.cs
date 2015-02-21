/*
 * Problem 6. First larger than neighbours
 * 
 * Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, 
 * if there’s no such element.
 * Use the method from the previous exercise.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_FirstLargerThanNeighbours
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 3, 4, 5, 7, 8, 9, 2, 3, 1, 1 };

            int index = LargerThanNeighbours(arr);

            Console.WriteLine(index);
        }

        static int LargerThanNeighbours(int[] arr)
        {
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i - 1] < arr[i] && arr[i] > arr[i + 1])
                {
                    return 1;
                }
            }
            return -1;
        }
    }
}
