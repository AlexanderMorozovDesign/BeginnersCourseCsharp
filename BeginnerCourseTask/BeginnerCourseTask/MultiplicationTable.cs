using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        /// <summary>
        /// Задача на курс «Таблица умножения»
        /// Вывести в консоль таблицу умножения чисел от 1 до 10 при помощи циклов for
        /// Но программа должна работать верно и если попросят таблицу от 1 до другого числа
        /// Примерно так, только без границ клеток, консоль этого не позволяет
        /// Добейтесь чтобы числа были выровнены по столбцам (добейте числа нужным количеством пробелов)
        /// Добавьте «шапку» таблицы, отделите ее символами, например, | и --
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите число до которого будет вычислена таблица умножения = ");
            int endNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Таблица умножения от 1 до {0}", endNumber);

            Console.Write("   ");

            for (int i = 1; i <= endNumber; i++)
            {
                Console.Write(i.ToString().PadLeft(5));
            }

            Console.WriteLine();

            Console.Write("---");
            for (int i = 1; i <= endNumber; i++)
            {
                Console.Write("-----");
            }

            Console.WriteLine();

            int maxRowNumberLength = endNumber.ToString().Length;

            for (int i = 1; i <= endNumber; i++)
            {
                Console.Write("{0}|", i.ToString().PadLeft(maxRowNumberLength, ' '));

                for (int j = 1; j <= endNumber; j++)
                {
                    int multiplication = i * j;
                    Console.Write(multiplication.ToString().PadLeft(5));
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
