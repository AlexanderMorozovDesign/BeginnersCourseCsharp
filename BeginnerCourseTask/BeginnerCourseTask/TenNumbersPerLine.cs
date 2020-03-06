using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenNumbersPerLine
{
    class TenNumbersPerLine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа по строчно распечатывает по 10 чисел в строке от 1 до 100");

            int i = 1;

            while (i <= 100)
            {
                if (i % 10 != 0)
                {
                    Console.Write(" " + i);
                }
                else
                {
                    Console.WriteLine(" " + i);
                }
                i++;
            }

            Console.ReadKey();
        }
    }
}
