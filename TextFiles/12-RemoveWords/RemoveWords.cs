/*
 * Problem 12. Remove words
 * 
 * Write a program that removes from a text file all words listed in given another text file.
 * Handle all possible exceptions in your methods.
 */

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

namespace _12_RemoveWords
{
    class RemoveWords
    {
        static void Main()
        {
            try
            {
                string regex = @"\b(" + String.Join("|", File.ReadAllLines(@"..\..\..\Problem12-JustWords.txt")) + @")\b";

                using (StreamReader input = new StreamReader(@"..\..\..\Problem12-JustText.txt"))
                {
                    using (StreamWriter output = new StreamWriter(@"..\..\..\Problem12-JustTextResult.txt"))
                    {
                        for (string line; (line = input.ReadLine()) != null; )
                        {
                            output.WriteLine(Regex.Replace(line, regex, String.Empty));
                        }
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
