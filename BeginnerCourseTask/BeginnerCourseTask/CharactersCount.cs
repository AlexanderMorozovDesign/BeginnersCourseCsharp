using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCount
{
    class CharactersCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку содержащую буквы, цифры, пробелы и прочие символы");
            string symbolString = Console.ReadLine();

            int digitsAmount = 0;
            int lettersAmount = 0;
            int whiteSpacesAmount = 0;
            int otherSymbolsAmount = 0;

            for (int i = 0; i < symbolString.Length; i++)
            {
                char symbol = symbolString[i];

                if (char.IsDigit(symbol))
                {
                    digitsAmount++;
                }
                else if (char.IsLetter(symbol))
                {
                    lettersAmount++;
                }
                else if (char.IsWhiteSpace(symbol))
                {
                    whiteSpacesAmount++;
                }
                else
                {
                    otherSymbolsAmount++;
                }
            }

            Console.WriteLine("Количество цифр = " + digitsAmount);
            Console.WriteLine("Количество букв = " + lettersAmount);
            Console.WriteLine("Количество пробелов = " + whiteSpacesAmount);
            Console.WriteLine("Количество других символов = " + otherSymbolsAmount);

            Console.ReadKey();
        }
    }
}
