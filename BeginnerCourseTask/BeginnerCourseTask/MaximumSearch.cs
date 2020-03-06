using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSearch
{
    class MaximumSearch
    {
        public static double GetMaximum(double[] array)
        {
            double maximumNumber = array[0];

            foreach (double number in array)
            {
                if (number > maximumNumber)
                {
                    maximumNumber = number;
                }
            }

            return maximumNumber;
        }

        static void Main(string[] args)
        {
            double[] array = { 9.7, 10.5, 18.5, 5.0, 10.6, 7.0, 4.6, 6.1, 13.3, 17.4, 16.7, 8.8, 20.4, 13.9, 13.3, 17.3, 15.9, 13.5, 11.6, 17.4, 9.7 };

            Console.WriteLine("Массив случайных вещественных чисел в котором нужно найти максимальное число");

            foreach (double element in array)
            {
                Console.Write(" " + element);
            }

            Console.WriteLine(Environment.NewLine + "Максимальное число в массиве вещественных чисел = " + GetMaximum(array));

            Console.ReadKey();
        }
    }
}
