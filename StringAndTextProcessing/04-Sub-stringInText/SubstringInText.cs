/*
 * Problem 4. Sub-string in text
 * 
 * Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Sub_stringInText
{
    class SubstringInText
    {
        static void Main()
        {
            Console.WriteLine("Write a text: ");
            string text = Console.ReadLine();

            Console.WriteLine("Write a sub-string: ");
            string subString = Console.ReadLine();

            int count = 0;
            int index = text.ToLower().IndexOf(subString, 0);

            while (index >= 0)
            {
                count++;
                index++;
                index = text.ToLower().IndexOf(subString, index);
            }
            Console.WriteLine(count);
        }
    }
}
