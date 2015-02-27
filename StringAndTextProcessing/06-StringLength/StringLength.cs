/*
 * Problem 6. String length
 * 
 * Write a program that reads from the console a string of maximum 20 characters. 
 * If the length of the string is less than 20, the rest of the characters should be filled with *.
 * Print the result string into the console.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StringLength
{
    class StringLength
    {
        static void Main()
        {
            string input = String.Empty;

            while (input.Length > 20 || input.Length == 0)
            {
                Console.Write("Enter string with max length of 20 chars: ");
                input = Console.ReadLine();
            }

            Console.WriteLine(input.PadRight(20, '*'));
        }
    }
}
