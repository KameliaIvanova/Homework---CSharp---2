/*
 * Problem 10. Unicode characters
 * 
 * Write a program that converts a string to a sequence of C# Unicode character literals.
 * Use format strings.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            var input = Console.ReadLine();

            var convert = new StringBuilder();

            foreach (var ch in input)
            {
                convert.AppendFormat("\\u{0:X4}", (int)ch);
            }

            Console.WriteLine(convert.ToString());
        }
    }
}
