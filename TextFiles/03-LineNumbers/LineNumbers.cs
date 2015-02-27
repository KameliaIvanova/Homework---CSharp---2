/*
 * Problem 3. Line numbers
 * 
 * Write a program that reads a text file and inserts line numbers in front of each of its lines.
 * The result should be written to another text file.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03_LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            string textFile = @"..\..\..\TextFileProblem3.txt";
            string newTFwithLines = @"..\..\..\TextFileProblem3Rezult.txt";

            var streamReader = new StreamReader(textFile);
            var streamWriter = new StreamWriter(newTFwithLines);

            using (streamWriter)
            {
                using (streamReader)
                {
                    int lineNumber = 1;
                    string line = streamReader.ReadLine();

                    while (line != null)
                    {
                        streamWriter.WriteLine("Line {0}: {1}", lineNumber, line);
                        lineNumber++;
                        line = streamReader.ReadLine();
                    }
                }
            }
            Console.WriteLine("It's done.");
        }
    }
}
