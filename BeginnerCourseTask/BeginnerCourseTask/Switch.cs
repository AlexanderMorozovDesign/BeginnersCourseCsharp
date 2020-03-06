using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchNew
{
    class Switch
    {
        /// <summary>
        /// Задача на дом «Switch» Прочитать с консоли три числа два операнда и код команды
        /// Код команды должен быть от 1 до 4
        /// Если он равен 1, то выполнить сложение первых двух чисел. Если 2, то вычитание, если 3, то умножение, если 4,
        /// то деление.
        /// Если ввели число не от 1 до 4, то вывести, что неизвестная операция
        /// Использовать switch
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите код команды");
            int command = Convert.ToInt32(Console.ReadLine());

            switch (command)
            {
                case 1:
                    double sum = firstNumber + secondNumber;
                    Console.WriteLine("Сумма чисел = {0}", sum);
                    break;
                case 2:
                    double difference = firstNumber - secondNumber;
                    Console.WriteLine("Разность чисел = {0} ", difference);
                    break;
                case 3:
                    double multiplication = firstNumber * secondNumber;
                    Console.WriteLine("Произведение чисел = {0} ", multiplication);
                    break;
                case 4:
                    double division = firstNumber / secondNumber;
                    Console.WriteLine("Частное чисел = {0} ", division);
                    break;
                default:
                    Console.WriteLine("Введена неивестная команда");
                    break;
            }

            Console.ReadKey();
        }
    }
}
