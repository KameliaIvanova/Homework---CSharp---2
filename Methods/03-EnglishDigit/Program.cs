/*
 * Problem 3. English digit
 * 
 * Write a method that returns the last digit of given integer as an English word.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EnglishDigit
{
    class Program
    {
        static void Main()
        {
            Console.Write("Write a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Last digit is: {0}", LastDigit(number));
        }

        static string LastDigit(int number)
        {
            string lastDigit = String.Empty;
            switch (number % 10)
            {
                case 0: lastDigit = "zero"; break;
                case 1: lastDigit = "one"; break;
                case 2: lastDigit = "two"; break;
                case 3: lastDigit = "three"; break;
                case 4: lastDigit = "four"; break;
                case 5: lastDigit = "five"; break;
                case 6: lastDigit = "six"; break;
                case 7: lastDigit = "seven"; break;
                case 8: lastDigit = "eight"; break;
                case 9: lastDigit = "nine"; break;
            }
            return lastDigit;
        }


    }
}
