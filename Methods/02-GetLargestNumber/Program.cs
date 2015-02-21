/*
 * Problem 2. Get largest number
 * 
 * Write a method GetMax() with two parameters that returns the larger of two integers.
 * Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GetLargestNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("1 number = ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("2 number = ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("3 number = ");
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("The Largest of these three numbers is: {0}", GetMax(GetMax(number1, number2), number3));
        }

        static int GetMax(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
