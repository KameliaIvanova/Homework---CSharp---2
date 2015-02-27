/*
 * Problem 24. Order words
 * 
 * Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_OrderWords
{
    class OrderWords
    {
        static void Main()
        {
            string words = "Telerik academy GitHub Windows Linux Samsung";
            string[] splittedWords = words.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(splittedWords);

            foreach (string word in splittedWords)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
    }
}
