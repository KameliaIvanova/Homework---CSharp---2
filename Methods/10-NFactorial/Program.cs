/*
 * Problem 10. N Factorial
 * 
 * Write a program to calculate n! for each n in the range [1..100].
 * Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10_NFactorial
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[100];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            CalculateFactorialOfN(arr);
        }

        static void CalculateFactorialOfN(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                BigInteger factorial = Factorial(arr[i]);
                Console.WriteLine(factorial);
            }
        }

        static BigInteger Factorial(int i)
        {
            BigInteger fact = i;
            while (i > 1)
            {
                fact *= i - 1;
                i--;
            }
            return fact;
        }
    }
}
