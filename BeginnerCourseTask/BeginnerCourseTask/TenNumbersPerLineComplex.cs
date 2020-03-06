using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenNumbersPerLineComplex
{
    class TenNumbersPerLineComplex
    {
        /// <summary>
        /// Задача на дом «10 чисел в строке» 
        /// Выводить числа ровно, чтобы они были друг под другом.Использовать функцию строки PadLeft
        /// Возможность задать начальное и конечное число, и по сколько чисел в строке выводить
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Программа построчно распечатывает вводимое количество чисел в строке в задаваемом интервале");

            Console.Write("Введите начало диапазона = ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите конец диапазона = ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество чисел в строке = ");
            int quantityPerLine = Convert.ToInt32(Console.ReadLine());

            int i = start;
            int count = 0;
            int numbersDistanceInLine = (int)Math.Log10(end) + 2;

            while (i <= end)
            {
                Console.Write(i.ToString().PadLeft(numbersDistanceInLine, ' '));
                count++;

                if (count == quantityPerLine)
                {
                    Console.WriteLine();
                    count = 0;
                }

                i++;
            }

            Console.ReadKey();
        }
    }
}
