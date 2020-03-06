using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticMeanArray
{
    class ArrayArithmeticMean
    {
        public static double GetArrayEvenNumbersAverage(int[] array) 
        {
            int sum = 0;
            int count = 0;

            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                    count++;
                }
            }

            return (double)sum / count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Массив случайных чисел в котором нужно найти среднее арифметическое четных чисел ");

            int[] array = { 8, 5, 1, 3, 11, 10, 6, 7, 3, 2, 9 };

            foreach (int element in array)
            {
                Console.Write(" " + element);
            }

            Console.WriteLine(Environment.NewLine + "Среднее арифметическое в массиве четных чисел = " + GetArrayEvenNumbersAverage(array));

            Console.ReadKey();
        }
    }
}
