/*
 * Problem 1. Square root
 * 
 * Write a program that reads an integer number and calculates and prints its square root.
 * If the number is invalid or negative, print Invalid number.
 * In all cases finally print Good bye.
 * Use try-catch-finally block.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            Console.Write("Enter non-negative integer: ");

            try
            {
                var input = int.Parse(Console.ReadLine());

                if (input < 0)
                {
                    throw new ArgumentException();
                }

                Console.WriteLine("Square root of {0} = {1}", input, Math.Sqrt(input));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid input");
            }
            catch (FormatException) //an int can not be parsed from the input
            {
                Console.WriteLine("Invalid input");
            }
            catch (OverflowException) //input number is out of the Int32 range
            {
                Console.WriteLine("Invalid input");
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
