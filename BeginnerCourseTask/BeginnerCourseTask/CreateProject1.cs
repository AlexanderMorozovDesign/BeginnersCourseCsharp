using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateProject1
{
    class CreateProject1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод целых чисел a и b на экран");
            int a = 2 * 7 + 1; //переменная целого типа
            Console.WriteLine("a = " + a);
            
            int b = a + 8; //переменная целого типа
            Console.WriteLine("b = " + b);
            
            Console.WriteLine("Вывод на экран суммы a и b");
            Console.WriteLine("a + b = " + (a + b));
            
            Console.WriteLine("Вывод на экран разности a и b");
            Console.WriteLine("a - b = " + (a - b));
            
            Console.WriteLine("Вывод на экран произведения a и b");
            Console.WriteLine("a * b = " + (a * b));
            
            Console.WriteLine("Вывод на экран целой части от деления b и a");
            Console.WriteLine("b / a = " + (b / a));
            
            Console.WriteLine("Вывод на экран возведения в степень a");
            Console.WriteLine("a^2 = " + (a * a));
            
            Console.WriteLine("Вывод на экран возведения в степень b");
            Console.WriteLine("b^2 = "+ (b * b));
            
            Console.WriteLine("Вывод на экран частного с плавающей запятой от деления a и b");
            Console.WriteLine(Math.Round((double)a / b, 4));
            Console.ReadKey(); //задержка строки, после нажатия выход из консоли
        }
    }
}
