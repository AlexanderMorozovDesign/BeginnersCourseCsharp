using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStringsUp
{
    class StringsUpArray
    {
        public static void ConvertStringsToUpper(string[] stringArray)
        {
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i].ToUpper();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Массив строк символы которого через функцию преобразуются в заглавные");

            string[] stringArray = { "wert", "alex", "qwe", "uio", "ert", "ppp", "qaz", "mmm", "bbb", "rrr" };

            Console.WriteLine(Environment.NewLine + "Нижний регистр букв " + string.Join(", ", stringArray));

            ConvertStringsToUpper(stringArray);
            Console.WriteLine(Environment.NewLine + "Верхний регистр букв " + string.Join(", ", stringArray));

            Console.ReadKey();
        }
    }
}
