using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
    /// <summary>
    /// Задача на курс «Угадай число»
    /// Напишите программу-игру, которая делает следующее:
    /// Компьютер загадывает случайное число от 1 до 100 включительно
    /// Для генерации случайного числа используйте класс Random
    /// Далее задача пользователя – отгадать число
    /// Вы вводите свою догадку. Если ввели верно, то игра
    /// завершается, и компьютер выводит за сколько попыток вы
    /// отгадали число
    /// Если ввели неверно, то компьютер должен сообщить,
    /// загаданное число больше или меньше
    /// Число попыток у пользователя не ограничено
    /// </summary>
    class NumberGuess
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Компьютер загадывает случайное число от 1 до 100 включительно");

            Random randomNumber = new Random();
            int mysteriousNumber = randomNumber.Next(1, 101);
            Console.WriteLine(" {0}", mysteriousNumber);

            for (int i = 1; ; i++)
            {
                Console.Write("Введите число = ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == mysteriousNumber)
                {
                    Console.WriteLine("Вы угадали число, Вам на это понадобилось {0} попыток :)", i);
                    break;
                }

                if (userNumber > mysteriousNumber)
                {
                    Console.WriteLine("Введеное число больше загаданного, попробуйте снова");
                }
                else
                {
                    Console.WriteLine("Введеное число меньше загаданного, попробуйте снова");
                }
            }

            Console.ReadKey();
        }
    }
}
