/*
 * Problem 8. Extract sentences
 * 
 * Write a program that extracts from a given text all sentences containing given word.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ExtractSentences
{
    class ExtractSentences
    {
        static void Main()
        {
            string text = "We are living in an yellow submarine." +
            " We don't have anything else." +
            " Inside the submarine is very tight." +
            " So we are drinking all the day." +
            " We will move out of it in 5 days.";

            string keyWord = "in";

            string[] splitted = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var sent in splitted)
            {
                string[] words = sent.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    if (keyWord == words[i])
                    {
                        Console.WriteLine(sent.Trim() + ".");
                    }
                }
            }
        }
    }
}
