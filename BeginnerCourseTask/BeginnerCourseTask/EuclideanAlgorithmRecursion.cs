using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanAlgorithmRecursion
{
    class EuclideanAlgorithmRecursion
    {
        public static int GetGreatestCommonFactor(int number1, int number2)
        {
            if (number2 == 0)
            {
                return number1;
            }

            int remainder = number1 % number2;

            if (remainder == 0)
            {
                return number2;
            }

            return GetGreatestCommonFactor(number2, remainder);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа для нахождения наибольшего общего делителя");

            Console.Write("Введите первое число = ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число = ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == 0 && number2 == 0)
            {
                Console.WriteLine("Наибольший общий делитель не существует");
            }
            else
            {
                Console.WriteLine("Наибольший общий делитель = {0}", GetGreatestCommonFactor(number1, number2));
            }

            Console.ReadKey();
        }
    }
}
