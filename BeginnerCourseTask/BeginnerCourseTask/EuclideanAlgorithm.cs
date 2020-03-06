using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanAlgorithm
{
    class EuclideanAlgorithm
    {
        /// <summary>
        /// Задача на курс «Алгоритм Евклида»
        /// Для нахождения наибольшего общего делителя двух чисел удобно использовать алгоритм Евклида:
        /// Реализовать вычисление НОД алгоритмом Евклида
        /// Использовать цикл
        /// При этом если оба числа равны 0, то НОД искать нельзя
        /// Просьба реализовывать именно этот алгоритм, а не другой
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа для нахождения наибольшего общего делителя");

            Console.Write("Введите первое число = ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число = ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == 0 && number2 == 0)
            {
                Console.WriteLine("Наибольший общий делитель не существует");
            }
            else if (number2 == 0)
            {
                Console.WriteLine("Наибольший общий делитель = {0}", number1);
            }
            else
            {
                while (true)
                {
                    int remainder = number1 % number2;

                    if (remainder == 0)
                    {
                        break;
                    }

                    number1 = number2;
                    number2 = remainder;
                }

                Console.WriteLine("Наибольший общий делитель = {0}", number2);
            }

            Console.ReadKey();
        }
    }
}
