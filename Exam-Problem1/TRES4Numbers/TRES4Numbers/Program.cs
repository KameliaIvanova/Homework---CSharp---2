using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRES4Numbers
{
    class Program
    {
        const int TresNumFourDigitsCount = 9;

        static readonly string[] TresNumFourDigits = new string[TresNumFourDigitsCount]
        {
            "LON+",
            "VK-",
            "*ACAD",
            "^MIM", 
            "ERIK|", 
            "SEY&", 
            "EMY>>", 
            "/TEL",
            "<<DON"
        };
        static void Main()
        {
            Console.WriteLine(ConvertToTresNumFourNumber(ulong.Parse(Console.ReadLine())));
        }

        static string ConvertToTresNumFourNumber(ulong decimalNumber)
        {
            var tresNumFourNumber = new List<string>();

            do
            {
                tresNumFourNumber.Add(TresNumFourDigits[decimalNumber % TresNumFourDigitsCount]);
                decimalNumber /= TresNumFourDigitsCount;
            } while (decimalNumber != 0);

            //Reversing the number to get the real value
            tresNumFourNumber.Reverse();

            return string.Join(string.Empty, tresNumFourNumber);
        }
    }
}
