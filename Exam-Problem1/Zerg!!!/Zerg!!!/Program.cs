﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zerg___
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(ConvertZergNumber(Console.ReadLine()));
        }

        // Convert number from "zerg" number to normal 13-th based number
        public static long ConvertZergNumber(string input)
        {
            long result = 0;

            for (int i = 0, j = input.Length / 4 - 1; i < input.Length; i += 4, j--)
            {
                int currentDigit = ConvertDigitFromZerg(input.Substring(i, 4));

                result += currentDigit * PowerOfFifteen(j);
            }

            return result;
        }

        // Converts from "zerg" digit to normal 15-th based digit
        public static int ConvertDigitFromZerg(string zergDigit)
        {
            switch (zergDigit)
            {
                case "Rawr": return 0;
                case "Rrrr": return 1;
                case "Hsst": return 2;
                case "Ssst": return 3;
                case "Grrr": return 4;
                case "Rarr": return 5;
                case "Mrrr": return 6;
                case "Psst": return 7;
                case "Uaah": return 8;
                case "Uaha": return 9;
                case "Zzzz": return 10;
                case "Bauu": return 11;
                case "Djav": return 12;
                case "Myau": return 13;
                case "Gruh": return 14;
                default: throw new ArgumentException();
            }
        }

        //Get the power of 15
        public static long PowerOfFifteen(int power)
        {
            long result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= 15;
            }

            return result;
        }
    }
}
