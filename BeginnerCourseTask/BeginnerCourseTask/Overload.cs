using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    /// <summary>
    /// Задача на дом «Перегрузка»
    /// Объявить в классе несколько функций с именем GetTypeSize
    /// Каждая функция должна принимать один аргумент одного из следующих типов: byte, short, int, long, float, double
    /// Функция должна возвращать int – количество байт, требуемых под переменную данного типа
    /// В функции Main сделать по одному примеру использования для каждой перегруженной функции
    /// </summary>
    class Overload
    {
        public static int GetTypeSize(byte x)
        {
            return 1;
        }

        public static int GetTypeSize(short x)
        {
            return 2;
        }

        public static int GetTypeSize(int x)
        {
            return 4;
        }

        public static int GetTypeSize(long x)
        {
            return 8;
        }

        public static int GetTypeSize(float x)
        { 
            return 4;
        }

        public static int GetTypeSize(double x)
        {
            return 8;
        }

        static void Main(string[] args)
        {
            byte a = 254;
            short b = 32766;
            int c = 2147483646;
            long d = 9223372036854775806;
            float f = 0.333f;
            double g = 3.5464e+10;

            Console.WriteLine("byte размер в байтах {0}", GetTypeSize(a));
            Console.WriteLine("short размер в байтах {0}", GetTypeSize(b));
            Console.WriteLine("int размер в байтах {0}", GetTypeSize(c));
            Console.WriteLine("long размер в байтах {0}", GetTypeSize(d));
            Console.WriteLine("float размер в байтах {0}", GetTypeSize(f));
            Console.WriteLine("double размер в байтах {0}", GetTypeSize(g));

            Console.ReadKey();
        }
    }
}
