using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class LeapYear
    {
        /// <summary>
        /// Задача на дом «Високосный год» Прочитать с консоли год и вывести в консоль, является он високосным или нет
        /// Старайтесь использовать логические связки, если это возможно
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Год для проверки високосный он или нет, по Григорианскому календарю");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine("Год {0} високосный", year);
            }
            else
            {
                Console.WriteLine("Год {0} невисокосный", year);
            }
            Console.ReadKey();
        }
    }
}
