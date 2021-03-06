﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWords
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();
                words.Add(word);
            }

            for (int pos = 0; pos < words.Count; pos++)
            {
                string word = words[pos];
                int newPos = words[pos].Length % (words.Count + 1);

                words[pos] = null; // Mark the word for deleting
                words.Insert(newPos, word);
                words.Remove(null);
            }

            int longestWord = 0;
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length > longestWord)
                {
                    longestWord = words[i].Length;
                }
            }

            var result = new StringBuilder();

            for (int index = 0; index < longestWord; index++)
            {
                for (int i = 0; i < words.Count; i++)
                {
                    if (index < words[i].Length)
                    {
                        result.Append(words[i][index]);
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
