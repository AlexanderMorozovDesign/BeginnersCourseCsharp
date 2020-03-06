using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticalMean
{
    /// <summary>
    /// Задача на дом «Среднее арифметическое»
    /// Написать программу, вычисляющую среднее арифметическое чисел из некоторого диапазона чисел (например, от 3 до
    /// Концы диапазона задать переменными, начальное число должно быть > 1 , чтобы было посложнее
    /// Среднее арифметическое чисел нужно сумму всех чисел поделить на количество этих чисел
    /// Ниже в этом же классе найти среднее арифметическое только четных чисел из этого диапазона чисел
    /// </summary>
    class ArithmeticalMean
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

            while (i <= end)
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

            double average = (double)sum / count;
            double evenAverage = (double)evenSum / evenCount;

            Console.WriteLine("Среднее арифметическое диапазона чисел от {0} до {1} = {2}", start, end, average);
            Console.WriteLine("Среднее арифметическое четных чисел диапазона от {0} до {1} = {2}", start, end, evenAverage);

            Console.ReadKey();
        }
    }
}
