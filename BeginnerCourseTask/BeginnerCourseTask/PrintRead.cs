using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAndRead
{
    /// <summary>
    /// Задача на дом «Print and read»
    /// Написать функцию, которая объединяет в себе две
    /// операции: вывод пользователю приглашения для ввода в консоль и чтение int’а с консоли
    /// Функция должна принимать строку и возвращать прочитанное число
    /// Из функции Main несколько раз вызвать данную функцию с разными значениями аргументов
    /// Пример: int a = PrintAndRead(“Введите число:”)
    /// </summary>
    class PrintRead
    {
        public static int PrintAndRead(string s)
        {
            Console.WriteLine(s);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int number1 = PrintAndRead("Введите целое число = ");
            Console.WriteLine(number1);

            int number2 = PrintAndRead("Введите число больше 100 = ");
            Console.WriteLine(number2);

            int number3 = PrintAndRead("Введите число меньше 560 = ");
            Console.WriteLine(number3);

            Console.ReadKey();
        }
    }
}
