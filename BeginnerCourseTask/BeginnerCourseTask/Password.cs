using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Password
    {
        /// <summary>
        /// Задача на дом «Пароль» В программе объявить строковую переменную, хранящую пароль С консоли прочитать строку, сравнить её с этим паролем. 
        /// Если строка совпала, то выдать сообщение, что парольверный Если строка не совпала с паролем, 
        /// и её длина (использовать L ength) больше длины пароля, то сказать что пароль неверный и строка слишком длинная Если строка не совпала с паролем, и её длина меньше, то
        /// сказать, что пароль неверный строка слишком короткая
        /// Иначе сказать, что пароль неверный
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Подберите пароль к Убежищу № 57");
            string systemicPassword = "NewYork";

            Console.WriteLine("Введите пароль ");
            string userPassword = Console.ReadLine();

            int systemicPasswordLength = systemicPassword.Length;
            int userPasswordLength = userPassword.Length;

            if (systemicPassword.Equals(userPassword))
            {
                Console.WriteLine("Пароль {0} верный", userPassword);
            }
            else if (systemicPasswordLength < userPasswordLength)
            {
                Console.WriteLine("Пароль {0} неверный, и строка длинная", userPassword);
            }
            else if (systemicPasswordLength > userPasswordLength)
            {
                Console.WriteLine("Пароль {0} неверный, и строка короткая", userPassword);
            }
            else 
            {
                Console.WriteLine("Пароль {0} неверный, вой сирен... вертолеты...", userPassword);
            }
            Console.ReadKey();
        }
    }
}
