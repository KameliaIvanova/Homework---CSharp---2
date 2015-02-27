/*
 * Problem 4. Compare text files
 * 
 * Write a program that compares two text files line by line and prints the number of lines that are the same and 
 * the number of lines that are different.
 * Assume the files have equal number of lines.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04_CompareTextFiles
{
    class CompareTextFiles
    {
        static void Main()
        {
            string textOne = @"..\..\..\Problem4-TextFile.txt";
            string textTwo = @"..\..\..\Problem4-TextFile2.txt";

            var readerOne = new StreamReader(textOne);
            var readerTwo = new StreamReader(textTwo);

            int numOfEquals = 0;
            int numOfDiffrents = 0;

            using (readerOne)
            {
                using (readerTwo)
                {
                    string lineOnFirstText = readerOne.ReadLine();
                    string lineOnSecondText = readerTwo.ReadLine();

                    while (lineOnFirstText != null)
                    {
                        if (lineOnFirstText == lineOnSecondText)
                        {
                            numOfEquals++;
                        }
                        else
                        {
                            numOfDiffrents++;
                        }
                        lineOnFirstText = readerOne.ReadLine();
                        lineOnSecondText = readerTwo.ReadLine();
                    }
                }
            }

            Console.WriteLine("The number of lines that are the same: " + numOfEquals);
            Console.WriteLine("The number of lines that are different: " + numOfDiffrents);
        }
    }
}
