/*
 * Problem 22. Words count
 * 
 * Write a program that reads a string from the console and lists all different words in the string along 
 * with information how many times each word is found.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_WordsCount
{
    class WordsCount
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string text = Console.ReadLine();
            string[] splittedText = text.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            bool[] visited = new bool[splittedText.Length];

            for (int i = 0; i < splittedText.Length; i++)
            {
                int count = 1;

                if (visited[i] == false)
                {
                    for (int j = i; j < splittedText.Length - 1; j++)
                    {
                        if (splittedText[i] == splittedText[j + 1])
                        {
                            count++;
                            visited[j + 1] = true;
                        }
                    }
                    visited[i] = true;
                    Console.WriteLine(splittedText[i] + "-" + count + " times");
                }
            }
        }
    }
}
