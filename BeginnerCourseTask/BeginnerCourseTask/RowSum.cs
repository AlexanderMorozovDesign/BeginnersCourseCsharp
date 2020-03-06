using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowSum
{
    class RowSum
    {
        /// <summary>
        /// Задача на дом «Сумма ряда» Написать программу, которая находит результат такого выражения: 1 - 4 + 9 - 16 + 25 - 36 ...
        /// Количество чисел в этом выражении должно быть параметром программы
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел ряда: ");
            int numbersAmount = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int i = 1;

            while (i <= numbersAmount)
            {
                if (i % 2 != 0)
                {
                    sum += i * i;
                }
                else
                {
                    sum -= i * i;
                }

                i++;
            }

            Console.WriteLine("Сумма числового ряда равна = {0} ", sum);

            Console.ReadKey();
        }
    }
}
