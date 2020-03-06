using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticMeanDo
{
    class ArithmeticMeanDoWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начало и конец диапазона чисел для вычисления среднего арифметического");

            Console.Write("Начало диапазона = ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Конец диапазона = ");
            int end = Convert.ToInt32(Console.ReadLine());

            int i = start;
            int sum = 0;
            int count = 0;
            int evenSum = 0;
            int evenCount = 0;

            do
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                    evenCount++;
                }

                sum += i;
                count++;
                i++;
            }
            while (i <= end);

            double average = (double)sum / count;
            double evenAverage = (double)evenSum / evenCount;

            Console.WriteLine("Среднее арифметическое диапазона чисел от {0} до {1} = {2}", start, end, average);
            Console.WriteLine("Среднее арифметическое четных чисел диапазона от {0} до {1} = {2}", start, end, evenAverage);

            Console.ReadKey();
        }
    }
}
