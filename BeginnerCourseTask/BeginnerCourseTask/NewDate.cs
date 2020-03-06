using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDate
{
    /// <summary>
    /// Задача на курс «Следующая дата»
    /// Программа запрашивает сегодняшнюю дату, и выдает дату следующего дня
    /// Например, входные данные: 31 12 2015, на выходе: 01.01.2016
    /// День, месяц и год можно запрашивать у пользователя с консоли по очереди
    /// Еще сделать проверку даты на корректность
    /// </summary>
    class NewDate
    {
        static void NextDate()
        {
            Console.WriteLine("Введите сегодняшнюю дату в формате день месяц год");

            Console.Write("Введите сегодняшний день = ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите сегодняшний месяц = ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите сегодняшний год = ");
            int year = Convert.ToInt32(Console.ReadLine());

            int daysInMonthAmount = 31;

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                daysInMonthAmount = 30;
            }
            else if (month == 2)
            {
                if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                {
                    daysInMonthAmount = 29;
                }
                else
                {
                    daysInMonthAmount = 28;
                }
            }

            if ((month < 1 || month > 12) || (day < 1 || day > daysInMonthAmount) || year < 0)
            {
                Console.WriteLine("Дата введена некорректно");

                return;
            }

            int nextDay = day + 1;
            int nextMonth = month;
            int nextYear = year;

            if (nextDay > daysInMonthAmount)
            {
                nextDay = 1;
                nextMonth++;
            }

            if (nextMonth > 12)
            {
                nextMonth = 1;
                nextYear++;
            }

            Console.WriteLine("Следующая дата - {0}.{1}.{2} ", nextDay, nextMonth, nextYear);
        }

        static void Main(string[] args)
        {
            NextDate();

            Console.ReadKey();
        }
    }
}
