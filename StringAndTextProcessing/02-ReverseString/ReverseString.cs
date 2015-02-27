/*
 * Problem 2. Reverse string
 * 
 * Write a program that reads a string, reverses it and prints the result at the console.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            // Input
            Console.Write("Write a string: ");
            string input = Console.ReadLine();

            // Array of chars for every element in a string
            char[] charInput = input.ToCharArray();
            Array.Reverse(charInput);

            // Print every reverse element
            foreach (char element in charInput)
            {
                Console.Write(element);
            }
            Console.WriteLine();
        }
    }
}
