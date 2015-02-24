/*
 * Problem 5. Workdays
 * 
 * Write a method that calculates the number of workdays between today and given date, passed as parameter.
 * Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Workdays
{
    class Workdays
    {
        static List<DateTime> holydaysPublic;

        static void Main()
        {
            holydaysPublic = new List<DateTime>()
            {
                new DateTime(2015, 3, 1),new DateTime(2015, 3, 3),new DateTime(2015, 4, 2),
                new DateTime(2015, 4, 10), new DateTime(2015, 5, 2),new DateTime(2015, 5, 12),
                new DateTime(2015, 5, 16),new DateTime(2015, 6, 13),new DateTime(2015, 6, 15)
            };

            Console.WriteLine(CountWorkdays(new DateTime(2015, 1, 1), new DateTime(2015, 6, 20)));
        }

        static string CountWorkdays(DateTime startDate, DateTime endDate)
        {
            int workdays = 0;
            int holydays = 0;
            int weekends = 0;
            DateTime current = startDate;

            while (current <= endDate)
            {
                if (holydaysPublic.Contains(current))
                {
                    ++holydays;
                }
                else if ((int)current.DayOfWeek == 0 || (int)current.DayOfWeek == 6)
                {
                    ++weekends;
                }
                else
                {
                    ++workdays;
                }
                current = current.AddDays(1);
            }

            return String.Format(@"holydays: {0}
weekends: {1}
workdays: {2}", holydays, weekends, workdays);
        }
    }
}
