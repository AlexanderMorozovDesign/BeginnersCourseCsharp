using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exponentiation
{
    class Exponentiation
    {
        public static int GetMathPowRecursion(int number, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }

            return number * GetMathPowRecursion(number, exponent - 1);
        }

        public static int GetMathPow(int number, int exponent)
        {
            int result = 1;

            for (int i = 1; i <= exponent; i++)
            {
                result *= number;
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Возведение в степень нерекурсивной функцией  ");

            Console.WriteLine("  " + GetMathPow(2, 2) + "  " + Math.Pow(2, 2));
            Console.WriteLine("  " + GetMathPow(2, 3) + "  " + Math.Pow(2, 3));
            Console.WriteLine(" " + GetMathPow(2, 4) + " " + Math.Pow(2, 4));
            Console.WriteLine(" " + GetMathPow(2, 5) + " " + Math.Pow(2, 5));
            Console.WriteLine(" " + GetMathPow(2, 6) + " " + Math.Pow(2, 6));

            Console.WriteLine("Возведение в степень рекурсивной функцией  ");

            Console.WriteLine("  " + GetMathPowRecursion(2, 2) + "  " + Math.Pow(2, 2));
            Console.WriteLine("  " + GetMathPowRecursion(2, 3) + "  " + Math.Pow(2, 3));
            Console.WriteLine(" " + GetMathPowRecursion(2, 4) + " " + Math.Pow(2, 4));
            Console.WriteLine(" " + GetMathPowRecursion(2, 5) + " " + Math.Pow(2, 5));
            Console.WriteLine(" " + GetMathPowRecursion(2, 6) + " " + Math.Pow(2, 6));

            Console.ReadKey();
        }
    }
}
