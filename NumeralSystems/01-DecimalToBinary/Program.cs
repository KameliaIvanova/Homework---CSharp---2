/*
 * Problem 1. Decimal to binary
 * 
 * Write a program to convert decimal numbers to their binary representation.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DecimalToBinary
{
    class Program
    {
        static void Main()
        {
            Console.Write("Write a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary representation of {0}(10) is {1}(2).", number, DecimalToBinaryFunc(number));
        }

        static string DecimalToBinaryFunc(int number)
        {
            int remainder;
            string result = string.Empty;

            while (number > 0)
            {
                remainder = number % 2;
                number /= 2;
                result = remainder.ToString() + result;
            }

            return result;
        }
    }
}
