using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        /// <summary>
        /// Задача на курс «Числа Фибоначчи»
        /// Написать программу, которая принимает с консоли целое число n и возвращает число Фибоначчи с номером n.
        /// Числа Фибоначчи задаются следующим образом:
        /// f0 = 0, f1 = 1, fn = fn-1 + fn-2 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите номер(индекс) числа Фибоначчи = ");
            int index = Convert.ToInt32(Console.ReadLine());

            int currentFibonacciNumber = index;

            if (index > 1)
            {
                int i = 1;
                int previousFibonacciNumber = 0;
                currentFibonacciNumber = 1;

                while (i < index)
                {
                    int penultimateFibonacciNumber = previousFibonacciNumber;
                    previousFibonacciNumber = currentFibonacciNumber;
                    currentFibonacciNumber += penultimateFibonacciNumber;
                    i++;
                }
            }

            Console.WriteLine(Environment.NewLine + "Число Фибоначчи с индексом {0} = {1}", index, currentFibonacciNumber);

            Console.ReadKey();
        }
    }
}
