using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingEdit
{
    class Greeting
    {
        /// <summary>
        /// класс который просит ввести ваше имя и количество сахара, а потом выводит в консоль приветсвие и время до вашей чашки кофе
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше Имя?"); // это печатает программа
            string name = Console.ReadLine();  // это ввожу я

            Console.WriteLine("Добрый день, " + name + "!"); // это печатает программа

            Console.WriteLine(Environment.NewLine + "Сколько порций сахара вам нужно в кофе?");  // это печатает программа
            int sugarAmount = Convert.ToInt32(Console.ReadLine()); // это ввожу я

            Console.WriteLine("Ваш кофе будет готов через " + (1 + sugarAmount / 2) + " мин"); // это печатает программа

            Console.ReadKey();
        }
    }
}
