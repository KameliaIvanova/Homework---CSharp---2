/*
 * Problem 2. Enter numbers
 * 
 * Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
 * If an invalid number or non-number text is entered, the method should throw an exception.
 * Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            var numbers = new int[10];
            int number = ReadNumber(1, 91);
            numbers[0] = number;

            for (int i = 8; i >= 0; i--)
            {
                number = ReadNumber(number, 100 - i);
                numbers[9 - i] = number;
            }

            Console.WriteLine("You entered: {0}", string.Join(", ", numbers));
        }

        static int ReadNumber(int start, int end)
        {
            Console.Write("Enter an integer bigger than {0} and smaller than {1}: ", start, end);

            try
            {
                var input = int.Parse(Console.ReadLine());

                if (input <= start || input >= end)
                {
                    throw new ArgumentException();
                }
                return input;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Input is not in the given range");
                throw;
            }
            catch (FormatException) //an int can not be parsed from the input
            {
                Console.WriteLine("Invalid input");
                throw;
            }
            catch (OverflowException) //input number is out of the Int32 range
            {
                Console.WriteLine("Invalid input");
                throw;
            }
        }
    }
}
