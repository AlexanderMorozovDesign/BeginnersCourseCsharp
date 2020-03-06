using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposit
{
    /// <summary>
    /// Задача на курс «Вклад»
    /// Напишите программу, которая рассчитывает сумму банковского вклада с заданной ставкой % годовых на заданное число месяцев
    /// Вклад с капитализацией – считаем, что после истечения каждого месяца к сумме вклада прибавляется начисленный за месяц процент от суммы вклада на начало месяца
    /// Также распечатать прибыль
    /// </summary>
    class Deposit
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму которую хотите положить на счет = ");
            double contribution = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ставка банка в процентах годовых по вкладу = ");
            double depositOnInterest = Convert.ToDouble(Console.ReadLine());

            Console.Write("На сколько месяцев вклад? = ");
            int monthsAmount = Convert.ToInt32(Console.ReadLine());

            double sum = contribution;
            const int oneHundredPercent = 100;
            const int monthsInYearAmount = 12;
            double monthlyAccruedInterest = depositOnInterest/ (monthsInYearAmount * oneHundredPercent);

            for (int i = 1; i <= monthsAmount; i++)
            {
                sum += sum * monthlyAccruedInterest;
            }

            Console.WriteLine("Прибыль по итогам {0} месяцев составляет {1} у.е", monthsAmount, (sum - contribution));

            Console.ReadKey();
        }
    }
}
