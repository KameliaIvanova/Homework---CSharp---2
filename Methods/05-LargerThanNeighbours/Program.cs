/*
 * Problem 5. Larger than neighbours
 * 
 * Write a method that checks if the element at given position in given array of integers is larger than its two neighbours 
 * (when such exist).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LargerThanNeighbours
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[10] { 1, 3, 7, 6, 5, 4, 9, 2, 6, 8 };

            Console.Write("Write a position: ");
            int position = int.Parse(Console.ReadLine());

            if ((position != 0) && (position != arr.Length - 1))
            {
                Console.WriteLine("The number at position {0} is {1} and it is larger then its two neighbours: {2}", position, arr[position], LargerOfThree(arr, position));
            }
            else
            {
                Console.WriteLine("There are no enough neighbours!");
            }
        }

        static bool LargerOfThree(int[] arr, int position)
        {
            if ((arr[position] > arr[position - 1]) && (arr[position] > arr[position + 1]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
