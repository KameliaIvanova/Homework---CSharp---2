﻿/*
 * Problem 13. Reverse sentence
 * 
 * Write a program that reverses the words in given sentence.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ReverseSentence
{
    class ReverseSentence
    {
        static void Main()
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";

            string[] splitted = sentence.Split(new char[] { ' ', ',', '.', '!' },
              StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(splitted);

            char end = sentence[sentence.Length - 1];

            int space = 0;
            int numberOfComas = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ',')
                {
                    numberOfComas++;
                }
            }

            var comaAtPosition = new int[numberOfComas];
            int currentComa = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    space++;
                }

                if (sentence[i] == ',')
                {
                    comaAtPosition[currentComa] = space;
                    currentComa++;
                }
            }

            var result = new StringBuilder();

            char lastSign = sentence[sentence.Length - 1];
            currentComa = 0;

            for (int i = 0; i < splitted.Length; i++)
            {
                if (i == splitted.Length - 1)
                {
                    result.Append(splitted[i] + lastSign);
                }
                else if (i == comaAtPosition[currentComa])
                {
                    result.Append(splitted[i] + ", ");
                    if (currentComa < comaAtPosition.Length - 1)
                    {
                        currentComa++;
                    }
                }
                else
                {
                    result.Append(splitted[i] + " ");
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
