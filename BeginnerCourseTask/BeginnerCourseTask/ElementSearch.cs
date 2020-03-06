using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementSearch
{
    class ElementSearch
    {
        public static int GetElementIndex(int searchNumber, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchNumber)
                {
                    return i;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите любое целое число от 1 до 51 = ");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Массив случайных чисел в котором нужно найти число = {0} ", searchNumber);

            int[] array = { 7, 23, 14, 50, 33, 29, 14, 4, 20, 51, 7, 46, 44, 50, 32, 37, 31, 2, 37, 6, 46, 9, 13, 23, 33, 7, 2, 25, 4, 48, 21, 43, 6, 44, 35, 30, 41, 38, 50, 47, 41, 30, 47, 38, 23, 34, 36, 18, 32, 8, 47 };

            foreach (int element in array)
            {
                Console.Write(" " + element);
            }

            Console.WriteLine(Environment.NewLine + "Индекс искомого число в массиве чисел ( если - 1 такого числа нет в массиве) = " + GetElementIndex(searchNumber, array));

            Console.ReadKey();
        }
    }
}
