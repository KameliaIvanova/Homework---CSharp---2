/*
 * Problem 2. Random numbers
 * 
 * Write a program that generates and prints to the console 10 random values in the range [100, 200].
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RandomNumbers
{
    class RandomNumbers
    {
        static void Main()
        {
            Random rand = new Random();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0,2} - {1}", i, rand.Next(100, 201));
            }
        }
    }
}
