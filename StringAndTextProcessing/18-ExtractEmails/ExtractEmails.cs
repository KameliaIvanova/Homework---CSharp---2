﻿/*
 * Problem 18. Extract e-mails
 * 
 * Write a program for extracting all email addresses from given text.
 * All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */

using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;

namespace _18_ExtractEmails
{
    class ExtractEmails
    {
        static void Main()
        {
            string text = "Contact Telerik at telerik@telerik.com or nakov@gmail.com";

            foreach (var item in Regex.Matches(text, @"\w+@\w+\.\w+"))
            {
                Console.WriteLine(item);
            }
        }
    }
}
