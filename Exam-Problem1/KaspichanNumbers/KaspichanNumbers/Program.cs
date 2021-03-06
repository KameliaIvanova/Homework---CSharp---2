﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspichanNumbers
{
    class Program
    {
        static void Main()
        {
            string[] digits = BuildDigits();
            ulong number = ulong.Parse(Console.ReadLine());
            string convertedNumber = ConvertNumberToBase(number, 256, digits);
            Console.WriteLine(convertedNumber);

            ulong convertedBackNumber = ConvertNumberFromBase(convertedNumber, 256);
        }

        private static ulong ConvertNumberFromBase(string number, ulong numberBase)
        {
            ulong sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int digit;

                if (char.IsUpper(number[i]))
                {
                    digit = number[i] - 'A';
                }
                else
                {
                    digit = (number[i] - 'a' + 1) * 26 + number[i + 1] - 'A';
                    i++;
                }
                sum = sum * numberBase + (ulong)digit;
            }
            return sum;
        }

        private static string ConvertNumberToBase(ulong number, ulong numberBase, string[] digits)
        {
            var resultDigits = new StringBuilder();

            do
            {
                ulong remainder = number % numberBase;
                string nextDigit = digits[remainder];
                resultDigits.Insert(0, nextDigit);
                number = number / numberBase;
            } while (number > 0);

            string result = resultDigits.ToString();
            return result;
        }

        private static string[] BuildDigits()
        {
            var digits = new List<string>();

            for (char digit = 'A'; digit <= 'Z'; digit++)
            {
                digits.Add("" + digit);
            }

            for (char prefix = 'a'; prefix <= 'z'; prefix++)
            {
                for (char suffix = 'A'; suffix <= 'Z'; suffix++)
                {
                    string digit = "" + prefix + suffix;
                    digits.Add(digit);
                }
            }
            return digits.ToArray();
        }
    }
}
