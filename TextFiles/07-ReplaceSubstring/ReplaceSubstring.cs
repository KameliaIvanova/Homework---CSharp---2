/*
 * Problem 7. Replace sub-string
 * 
 * Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
 * Ensure it will work with large files (e.g. 100 MB).
 */

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _07_ReplaceSubstring
{
    class ReplaceSubstring
    {
        static void Main()
        {
            using (var input = new StreamReader(@"..\..\..\Problem7-StartToFinishText.txt"))
            {
                using (var output = new StreamWriter(@"..\..\..\Problem7-FinishToStartText.txt"))
                {
                    for (string line; (line = input.ReadLine()) != null; )
                    {
                        output.WriteLine(line.Replace("start", "finish"));
                    }
                }
            }
            Console.WriteLine("It's done!");
        }
    }
}
