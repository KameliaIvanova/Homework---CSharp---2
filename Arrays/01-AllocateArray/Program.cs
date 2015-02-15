/*
 * Problem 1. Allocate array
 * 
 * Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 * Print the obtained array on the console.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllocateArray
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[20];

            for (int i = 0; i < 20; i++)
            {
                arr[i] = i * 5;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("a[{0}] = {1}", i, arr[i]);
            }
        }
    }
}
