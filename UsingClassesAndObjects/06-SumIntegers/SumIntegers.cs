/*
 * Problem 6. Sum integers
 * 
 * You are given a sequence of positive integer values written into a string, separated by spaces.
 * Write a function that reads these values from given string and calculates their sum.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SumIntegers
{
    class SumIntegers
    {
        static void Main()
        {
            Console.Write("Numbers: ");
            int[] numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            Console.WriteLine("The sum is: " + numbers.Sum());
        }
    }
}
