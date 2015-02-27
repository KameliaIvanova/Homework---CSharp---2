/*
 * Problem 2. Concatenate text files
 * 
 * Write a program that concatenates two text files into another text file.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02_ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main()
        {
            string firstTextFile = @"..\..\..\TextFile.txt";
            string secondTextFile = @"..\..\..\TextFile2.txt";
            string newTextFile = @"..\..\..\NewTextFile.txt";

            var strReaderOne = new StreamReader(firstTextFile);
            var strReaderTwo = new StreamReader(secondTextFile);
            var strWriter = new StreamWriter(newTextFile);

            using (strWriter)
            {
                using (strReaderOne)
                {
                    string LineFOne = strReaderOne.ReadLine();
                    while (LineFOne != null)
                    {
                        strWriter.WriteLine(LineFOne);
                        LineFOne = strReaderOne.ReadLine();
                    }
                }
                using (strReaderTwo)
                {
                    string LineFTwo = strReaderTwo.ReadLine();
                    while (LineFTwo != null)
                    {
                        strWriter.WriteLine(LineFTwo);
                        LineFTwo = strReaderTwo.ReadLine();
                    }
                }
            }
            Console.WriteLine("It's done.");
        }
    }
}
