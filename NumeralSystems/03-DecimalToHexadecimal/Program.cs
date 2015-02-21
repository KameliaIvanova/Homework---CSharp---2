/*
 * Problem 3. Decimal to hexadecimal
 * 
 * Write a program to convert decimal numbers to their hexadecimal representation.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DecimalToHexadecimal
{
    class Program
    {
        static void Main()
        {
            Console.Write("Write a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary representation of {0}(10) is {1}(16).", number, DecimalToHexadecimalFunc(number));
        }

        static string DecimalToHexadecimalFunc(int number)
        {
            int remainder;
            string result = string.Empty;

            while (number > 0)
            {
                remainder = number % 16;
                number /= 16;

                if (remainder < 10)
                {
                    result = remainder.ToString() + result;
                }
                else
                {
                    switch (remainder)
                    {
                        case 10: result = "A" + result; break;
                        case 11: result = "B" + result; break;
                        case 12: result = "C" + result; break;
                        case 13: result = "D" + result; break;
                        case 14: result = "E" + result; break;
                        case 15: result = "F" + result; break;
                    }
                }
            }

            return result;
        }
    }
}
