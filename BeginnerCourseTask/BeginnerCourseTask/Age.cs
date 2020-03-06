using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    /// <summary>
    /// Задача на курс «Возраст»
    /// Программа просит ввести пользователя свой возраст от 1 до 112 включительно, после чего выводит сообщение «Вам x лет»
    /// При этом учесть, что для разных чисел разные склонения
    /// Например, «3 года», «99 лет» и т.д.
    /// Если введут слишком малое или слишком большое число, то выведите, что «Вы слишком малы» или стары
    /// Старайтесь использовать логические связки, если это возможно
    /// </summary>
    class Age
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свой возраст = ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 1)
            {
                Console.WriteLine("Вы слишком малы");
            }
            else if (age > 112)
            {
                Console.WriteLine("Вы слишком стары");
            }
            else if (age % 100 >= 11 && age % 100 <= 14)
            {
                Console.WriteLine("Вам {0} лет ", age);
            }
            else if (age % 10 == 1)
            {
                Console.WriteLine("Вам {0} год ", age);
            }
            else if (age % 10 == 2 || age % 10 == 3 || age % 10 == 4)
            {
                Console.WriteLine("Вам {0} года ", age);
            }
            else
            {
                Console.WriteLine("Вам {0} лет ", age);
            }

            Console.ReadKey();
        }
    }
}
