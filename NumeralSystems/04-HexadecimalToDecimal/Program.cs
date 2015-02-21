/*
 * Problem 4. Hexadecimal to decimal
 * 
 * Write a program to convert hexadecimal numbers to their decimal representation.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_HexadecimalToDecimal
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter hex number: ");
            string number = Console.ReadLine();
            Console.WriteLine("Binary representation of {0}(16) is {1}(10).", number, HexadecimalToDecimalFunc(number));
        }

        static int HexadecimalToDecimalFunc(string number)
        {
            int result = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(number[i]))
                {
                    result += (int)((number[i] - '0') * Math.Pow(16, number.Length - i - 1));
                }
                else
                {
                    int num = 0;

                    switch (number[i])
                    {
                        case 'a':
                        case 'A': num = 10; break;
                        case 'b':
                        case 'B': num = 11; break;
                        case 'c':
                        case 'C': num = 12; break;
                        case 'd':
                        case 'D': num = 13; break;
                        case 'e':
                        case 'E': num = 14; break;
                        case 'f':
                        case 'F': num = 15; break;
                    }
                    result += (int)(num * Math.Pow(16, number.Length - i - 1));
                }
            }

            return result;
        }
    }
}
