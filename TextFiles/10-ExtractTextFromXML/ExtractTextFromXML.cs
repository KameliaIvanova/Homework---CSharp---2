/*
 * Problem 10. Extract text from XML
 * 
 * Write a program that extracts from given XML file all the text without the tags.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10_ExtractTextFromXML
{
    class ExtractTextFromXML
    {
        static void Main()
        {
            using (var input = new StreamReader(@"..\..\..\Problem10-JustXMLText.xml"))
            {
                for (int i; (i = input.Read()) != -1; ) // Read char by char
                {
                    if (i == '>') // Inside text node
                    {
                        string text = String.Empty;

                        while ((i = input.Read()) != -1 && i != '<')
                        {
                            text += (char)i;
                        }

                        if (!String.IsNullOrWhiteSpace(text))
                        {
                            Console.WriteLine(text.Trim());
                        }
                    }
                }
            }
        }
    }
}
