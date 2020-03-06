using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class MaxMin
    {
        /// <summary>
        /// Программа выводит максимальное и минимальное число из двух введеных чисел
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ниже 2 целых числа для определения максимального и минимального из них");

            Console.WriteLine("Введите первое число ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сравнение двух чисел первым способом через if ");

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Максимальное из двух введеных чисел = {0} Минимальное = {1}", firstNumber, secondNumber);
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("Максимальное из двух введеных чисел = {0} Минимальное = {1}", secondNumber, firstNumber);
            }
            else
            {
                Console.WriteLine("Вы ввели 2 одинаковых числа");
            }

            Console.WriteLine(Environment.NewLine + "Сравнение двух чисел вторым способом через тернарный оператор ");

            int ternaryMax = (firstNumber > secondNumber) ? firstNumber : secondNumber;
            Console.WriteLine("Выводит максимальное из 2 чисел вычисленное через тернарный оператор = " + ternaryMax);

            int ternaryMin = (firstNumber > secondNumber) ? secondNumber : firstNumber;
            Console.WriteLine("Выводит минимальное из 2 чисел вычисленное через тернарный оператор = " + ternaryMin);

            Console.ReadKey();
        }
    }
}
