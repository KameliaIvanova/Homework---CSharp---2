/*
 * Problem 1. Leap year
 * 
 * Write a program that reads a year from the console and checks whether it is a leap one.
 * Use System.DateTime.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            Console.Write("Write an year: ");
            int year = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} is a leap year!", year);
            }
            else
            {
                Console.WriteLine("{0} is NOT a leap year!", year);
            }
        }
    }
}
