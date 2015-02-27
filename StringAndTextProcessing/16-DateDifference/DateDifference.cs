/*
 * Problem 16. Date difference
 * 
 * Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_DateDifference
{
    class DateDifference
    {
        static void Main()
        {
            Console.WriteLine("Enter first date in the format day.month.year: ");
            var firstDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter second date in the format day.month.year: ");
            var secondDate = DateTime.Parse(Console.ReadLine());

            TimeSpan daysBetween = firstDate - secondDate;

            Console.WriteLine("Days between: " + Math.Abs(daysBetween.Days));
        }
    }
}
