/*
 * Problem 12. Index of letters
 * 
 * Write a program that creates an array containing all letters from the alphabet (A-Z).
 * Read a word from the console and print the index of each of its letters in the array.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_IndexOfLetters
{
    class Program
    {
        static void Main()
        {
            char[] arr = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            Console.Write("Write a word: ");
            string word = Console.ReadLine().ToUpper();

            char[] wordLetters = new char[word.Length];
            wordLetters = word.ToCharArray();

            for (int i = 0; i < wordLetters.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (wordLetters[i] == arr[j])
                    {
                        Console.Write("{0} -> {1}", wordLetters[i], j);
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
