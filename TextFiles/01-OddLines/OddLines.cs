/*
 * Problem 1. Odd lines
 * 
 * Write a program that reads a text file and prints on the console its odd lines.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01_OddLines
{
    class OddLines
    {
        static void Main()
        {
            string textFile = @"..\..\..\TextFile.txt";
            Console.WriteLine("Every odd line in {0} is:", textFile);

            var streamReader = new StreamReader(textFile);

            using (streamReader)
            {
                int lineNumber = 1;
                string line = streamReader.ReadLine();

                while (line != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    }
                    lineNumber++;
                    line = streamReader.ReadLine();
                }
            }
        }
    }
}
