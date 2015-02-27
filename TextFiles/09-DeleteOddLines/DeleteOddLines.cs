/*
 * Problem 9. Delete odd lines
 * 
 * Write a program that deletes from given text file all odd lines.
 * The result should be in the same file.
 */

using System;
using System.IO;
using System.Collections.Generic;

namespace _09_DeleteOddLines
{
    class DeleteOddLines
    {
        static List<string> ReadEvenLines() // Метод, който чете от файла четните редове и ги записва в лист
        {
            var lines = new List<string>();

            int n = 1;

            using (var input = new StreamReader(@"..\..\..\Problem9-TextToDeleteOddLines.txt"))
            {
                for (string line; (line = input.ReadLine()) != null; n++)
                {
                    if (n % 2 == 0)
                    {
                        lines.Add(line);
                    }
                }
            }
            return lines;
        }

        static void WriteLines(List<string> lines)
        {
            using (StreamWriter output = new StreamWriter(@"..\..\..\Problem9-DeleteOddLinesFromText.txt"))
            {
                foreach (string line in lines)
                {
                    output.WriteLine(line);
                }
            }
        }

        static void Main()
        {
            WriteLines(ReadEvenLines()); // TODO: Do it without storing the lines in the memory
            Console.WriteLine("It's done!");
        }
    }
}
