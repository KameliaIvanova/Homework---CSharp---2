/*
 * Problem 23. Series of letters
 * 
 * Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string text = "aaaaabbbbbcdddeeeedssaab";

            var sb = new StringBuilder();

            char previous = text[0];

            sb.Append(previous);

            for (int i = 1; i < text.Length; i++)
            {
                if (previous != text[i])
                {
                    sb.Append(text[i]);
                }

                previous = text[i];
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
