/*
 * Problem 6. Save sorted names
 * 
 * Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06_SaveSortedNames
{
    class SaveSortedNames
    {
        static List<string> ReadLines() // Метод, който чете от файл и записва в листове
        {
            var lines = new List<string>();

            using (var input = new StreamReader(@"..\..\..\Problem6.txt"))
            {
                for (string line; (line = input.ReadLine()) != null; ) // line - при всяко въртене на цикъла се взима нов 
                // ред от файла и докато той не е null цикъла се завърта
                {
                    lines.Add(line); // добавяме всеки ред от файла в листа
                }
            }
            return lines;
        }

        static void WriteLines(List<string> lines) // Метод, който записва в нов файл резултата
        {
            using (var output = new StreamWriter(@"..\..\..\Problem6-Result.txt"))
            {
                foreach (string line in lines)
                {
                    output.WriteLine(line);
                }
            }
        }

        static void Main()
        {
            List<string> lines = ReadLines();

            lines.Sort(); // Сортираме елементите в листа

            WriteLines(lines);

            Console.WriteLine("It's done!");
        }
    }
}
