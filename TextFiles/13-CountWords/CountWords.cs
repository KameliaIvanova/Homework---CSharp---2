/*
 * Problem 13. Count words
 * 
 * Write a program that reads a list of words from the file words.txt and finds how many times each of the words is 
 * contained in another file test.txt.
 * The result should be written in the file result.txt and the words should be sorted by the number of their occurrences 
 * in descending order. Handle all possible exceptions in your methods.
 */

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

namespace _13_CountWords
{
    class CountWords
    {
        static void Main()
        {
            try
            {
                string[] words = File.ReadAllLines(@"..\..\..\Problem12-JustWords.txt");
                int[] values = new int[words.Length];

                // Count words
                using (StreamReader input = new StreamReader(@"..\..\..\Problem12-JustText.txt"))
                {
                    for (string line; (line = input.ReadLine()) != null; )
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            values[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                        }
                    }
                }
                // Sort
                Array.Sort(values, words);

                // Write output
                using (StreamWriter output = new StreamWriter(@"..\..\..\Problem13-JustResultWords.txt"))
                {
                    for (int i = words.Length - 1; i >= 0; i--) // Descending order
                    {
                        output.WriteLine("{0}: {1}", words[i], values[i]);
                    }
                }
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (SecurityException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
