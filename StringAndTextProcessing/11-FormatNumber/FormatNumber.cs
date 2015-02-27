﻿/*
 * Problem 11. Format number
 * 
 * Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_FormatNumber
{
    class FormatNumber
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            var number = Console.ReadLine();

            PrintAsScientificNotation(number);
            PrintAsPercentage(number);
            PrintAsHex(number);
            PrintAsDec(number);
            PrintAsCurrency(number);

        }

        static void PrintAsScientificNotation(string number)
        {
            Console.WriteLine("{0,15:E}", number);
        }

        static void PrintAsPercentage(string number)
        {
            Console.WriteLine("{0,15:P}", double.Parse(number) / 100);
        }

        static void PrintAsHex(string number)
        {
            Console.WriteLine("{0,15:X}", int.Parse(number));
        }

        static void PrintAsDec(string number)
        {
            Console.WriteLine("{0,15:D}", int.Parse(number));
        }

        static void PrintAsCurrency(string number)
        {
            Console.WriteLine("{0,15:C}", decimal.Parse(number));
        }
    }
}
