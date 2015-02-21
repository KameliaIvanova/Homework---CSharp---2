/*
 * Problem 1. Say Hello
 * 
 * Write a method that asks the user for his name and prints “Hello, <name>”.
 * Write a program to test this method.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SayHello
{
    class Program
    {
        static void Main()
        {
            SayHello();
        }

        static void SayHello()
        {
            Console.Write("What is your first name? ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}", name);
        }
    }
}
