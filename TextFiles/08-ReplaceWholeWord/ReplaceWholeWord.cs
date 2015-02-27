/*
 * Problem 8. Replace whole word
 * 
 * Modify the solution of the previous problem to replace only whole words (not strings).
 */

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _08_ReplaceWholeWord
{
    class ReplaceWholeWord
    {
        static void Main()
        {
            using (var input = new StreamReader(@"..\..\..\Problem7-StartToFinishText.txt"))
            {
                using (var output = new StreamWriter(@"..\..\..\Problem8-Result.txt"))
                {
                    for (string line; (line = input.ReadLine()) != null; )
                    {
                        output.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                    }
                }
            }
            Console.WriteLine("It's done!");
        }
    }
}
// Регулярните изрази (известни още с абревиатурите си regex или regexp) са последователности от символи, 
// които формират модел за търсене, главно за употреба на „шаблонни съвпадения“ (pattern matching) в стрингове, 
// примерно операции, подобни на „намери и замести“ (find and replace). 
