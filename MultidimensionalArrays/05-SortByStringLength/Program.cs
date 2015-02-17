/*
 * Problem 5. Sort by string length
 * 
 * You are given an array of strings. Write a method that sorts the array by the length of its elements 
 * (the number of characters composing them).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SortByStringLength
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            string[] array = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = Console.ReadLine();
            }

            // Sort with lambda
            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("array[{0}] = {1}", i, array[i]);
            }
        }
    }
}
