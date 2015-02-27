/*
 * Problem 11. Prefix "test"
 * 
 * Write a program that deletes from a text file all words that start with the prefix test.
 * Words contain only the symbols 0…9, a…z, A…Z, _.
 */

using System;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;

namespace _11_PrefixText
{
    class PrefixText
    {
        static void Main()
        {
            string fileName = @"..\..\..\Problem11-DeleteWordsStartsWithTest.txt";
            string resultFileName = @"..\..\..\Problem11-ResultFromDeletedWordsWithTest.txt";
            Random randomGenerator = new Random(); // първо си правя един рандомгенератор за текстoвия файл

            List<string> words = new List<string>(66);
            GenerateWords(words);

            StreamWriter writer = new StreamWriter(fileName, false, Encoding.GetEncoding("windows-1251"));
            using (writer)
            {
                for (int i = 0; i < 200; i++)
                {
                    switch (randomGenerator.Next(5))
                    {
                        case 0:
                            writer.Write(words[0]);
                            break;
                        case 1:
                            writer.Write(words[1]);
                            break;
                        case 2:
                            writer.Write(words[2]);
                            break;
                        default:
                            writer.Write(words[randomGenerator.Next(words.Count)]);
                            break;
                    }
                }
            }

            writer = new StreamWriter(resultFileName, false, Encoding.GetEncoding("windows-1251"));
            StreamReader reader = new StreamReader(fileName, Encoding.GetEncoding("windows-1251"));
            using (writer)
            {
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        line = Regex.Replace(line, @"(\b)test((\d|\w|_)*)(\b)", " "); // търси всички думи започващи с префикс "test" и 
                        // ги замества с едно интервалче, чрез метода Regex.Replace.
                        writer.WriteLine(Regex.Replace(line, @"(\s){2,}", " ")); // замества 2 или повече празни интервала само с един такъв.
                        line = reader.ReadLine();
                    }
                }
                // Като напишете израза @"(\b)test(\b)" той ще ви търси всички думи които са точно test. Ако искате test да е префикса 
                // добавям след test израза (\d|\w|_)*, което означава - \d = цифра, | = или, \w = буква, | = или, _ = това си е долна черта, 
                // а накрая звездичката означава че тези символи могат да се повтарят 0 или повече пъти.
            }


            Process openFile = new Process();
            openFile.StartInfo.FileName = fileName;
            openFile.Start(); // двата файла ги отварям с Process.Start(), за да се види резултатът.

            openFile.StartInfo.FileName = resultFileName;
            openFile.Start(); // двата файла ги отварям с Process.Start(), за да се види резултатът.
        }
        private static void GenerateWords(List<string> words)
        {
            words.Add("test");
            words.Add("\r\n");
            words.Add(" ");
            words.Add("_");
            for (int i = 48; i <= 57; i++)
            {
                words.Add(((char)i).ToString());
            }
            for (int i = 65; i <= 90; i++)
            {
                words.Add(((char)i).ToString());
            }
            for (int i = 97; i <= 122; i++)
            {
                words.Add(((char)i).ToString());
            }
        }

    }
}
