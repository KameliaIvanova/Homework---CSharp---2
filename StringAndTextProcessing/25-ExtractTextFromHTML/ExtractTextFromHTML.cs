/*
 * Problem 25. Extract text from HTML
 * 
 * Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_ExtractTextFromHTML
{
    class ExtractTextFromHTML
    {
        static void Main()
        {
            Console.Write("Enter text: ");
            var text = Console.ReadLine();

            var noTags = new StringBuilder();

            bool openTag = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    openTag = true;
                }

                if (!openTag)
                {
                    noTags.Append(text[i]);

                    if (text[i + 1] == '<')
                    {
                        noTags.AppendLine();
                    }
                }

                if (text[i] == '>')
                {
                    openTag = false;
                }
            }

            Console.WriteLine(noTags.ToString().Trim());
        }
    }
}
