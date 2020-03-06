using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break
{
    class Break
    {
        /// <summary>
        /// Задача на дом «Break» В программе должна быть некоторая загаданная фиксированная строка 
        /// Далее программа предлагает пользователю ввести строку, пользователь вводит
        /// Если введена та загаданная строка, то программа должна завершаться
        /// Иначе пользователю дается следующая попытка для ввода и т.д., пока не введет правильно. 
        /// При этом каждый раз пользователю должно выдаваться приглашение для ввода
        /// В этой задаче используйте бесконечный цикл и break
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Отгадайте загадку");
            string systemPassword = "Граммофон";

            for (; ; )
            {
                Console.WriteLine("Музыкант, певец, рассказчик — А всего труба да ящик.");
                string userPassword = Console.ReadLine();

                if (userPassword == systemPassword)
                {
                    Console.WriteLine("Ответ верный ! :)");
                    break;
                }

                Console.WriteLine("Ответ не верный, попробуйте снова");
            }

            Console.ReadKey();
        }
    }
}
