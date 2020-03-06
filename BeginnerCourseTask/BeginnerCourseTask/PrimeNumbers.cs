using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    /// <summary>
    /// Задача на дом «Простые числа»
    /// Прочитать с консоли целое число
    /// Найти и распечатать все простые числа, не превышающие введенное число
    /// </summary>
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число до которого будут найдены простые числа");
            int endNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= endNumber; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;

                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write("{0} ", i);
                }
            }

            Console.ReadKey();
        }
    }
}
