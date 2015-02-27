/*
 * Problem 3. Correct brackets
 * 
 * Write a program to check if in a given expression the brackets are put correctly.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            Console.Write("Write a expression: ");
            string expression = Console.ReadLine();

            int bracketCount = 0;

            foreach (char symbol in expression)
            {
                if (symbol == '(')
                {
                    ++bracketCount;
                }
                else if (symbol == ')')
                {
                    --bracketCount;
                }
            }

            if (bracketCount < 0)
            {
                Console.WriteLine("Are INCORRECT!");
            }
            else
            {
                Console.WriteLine("Are CORRECT!");
            }
        }
    }
}
