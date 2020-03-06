using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberDigits
{
    class NumberDigits
    {
        /// <summary>
        /// Задача на дом «Цифры числа» Прочитать с консоли целое число Найдите сумму его цифр Найдите сумму только тех цифр числа, которые являются
        /// нечетными числами Найдите максимальную цифру числа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное число");
            int number = Convert.ToInt32(Console.ReadLine());

            string numberString = Convert.ToString(number);
            int digitsQuantity = numberString.Length;

            Console.WriteLine("Количество цифр в числе = {0}", digitsQuantity);

            int i = 1;
            int sum = 0;
            int oddSum = 0;
            int maxDigit = 0;

            while (i <= digitsQuantity)
            {
                int digit = (number / (int)Math.Pow(10, (digitsQuantity - (i - 1)) - 1)) % 10;
                sum += digit;
                
                if (digit % 2 != 0)
                {
                    oddSum += digit;
                }

                if (maxDigit < digit)
                {
                    maxDigit = digit;
                }

                i++;
            }

            Console.WriteLine("Сумма цифр числа = " + sum);
            Console.WriteLine("Сумма нечетных цифр числа = " + oddSum);
            Console.WriteLine("Максимальная цифра числа = " + maxDigit);

            Console.ReadKey();
        }
    }
}
