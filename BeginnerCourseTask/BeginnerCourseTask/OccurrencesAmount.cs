using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OccurrencesAmount
{
    class OccurrencesAmount
    {
        public static int GetOccurrencesAmountInLine(string line, string searchString)
        {
            int index = 0;
            int amount = 0;
            int length = searchString.Length;

            string searchStringInUpperCase = searchString.ToUpper();
            string lineInUpperCase = line.ToUpper();

            index = lineInUpperCase.IndexOf(searchStringInUpperCase, index);

            while (index != -1)
            {
                amount++;
                index += length;
                index = lineInUpperCase.IndexOf(searchStringInUpperCase, index);
            }

            return amount;
        }

        static void Main(string[] args)
        {
            int amount = 0;
            string searchString = "rT";

            using (StreamReader reader = new StreamReader("..\\..\\input.txt"))
            {
                string currentLine;

                while ((currentLine = reader.ReadLine()) != null)
                {
                    amount += GetOccurrencesAmountInLine(currentLine, searchString);
                }
            }

            Console.WriteLine("Чтение выполнено");
            Console.WriteLine("Количество вхождений строки {0} = {1}, без учета регистра ", searchString, amount);

            Console.ReadKey();
        }
    }
}
