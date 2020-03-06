using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidSort
{
    class PyramidSorting
    {
        static void Sift(int[] array, int i, int length)
        {
            int maxIndex = i;
            int max = array[i];

            while (true)
            {
                i = maxIndex;
                int childIndex = i * 2 + 1; 

                if (childIndex < length && array[childIndex] > max)
                {
                    maxIndex = childIndex;
                }

                childIndex++; 

                if (childIndex < length && array[childIndex] > array[maxIndex])
                {
                    maxIndex = childIndex;
                }

                if (maxIndex == i)
                {
                    break;
                }

                array[i] = array[maxIndex]; 
                array[maxIndex] = max;
            }
        }

        public static void PyramidSort(int[] array)
        {
            int length = array.Length;

            for (int i = length / 2 - 1; i >= 0; i--)
            {
                Sift(array, i, length);
            }

            for (int i = length - 1; i > 0; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                Sift(array, 0, i);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Пирамидальная сортировка");

            int[] array1 = { 83, 15, 76, 32, 84, 65, 12, 81, 46, 73, 55, 45, 37, 22, 14, 54, 75, 94, 3, 72, 51 };
            Console.WriteLine(Environment.NewLine + "Не сортированный массив целых чисел: " + string.Join(", ", array1));

            PyramidSort(array1);
            Console.WriteLine(Environment.NewLine + "Сортированный массив целых чисел методом пирамидальной сортировки: " + string.Join(", ", array1));

            int[] array2 = { 35, 68, 83, 26, 53, 96, 71, 58, 39, 63, 20, 59, 74, 43, 69, 82, 7, 24, 8, 6, 3 };
            Console.WriteLine(Environment.NewLine + "Не сортированный массив целых чисел: " + string.Join(", ", array2));

            PyramidSort(array2);
            Console.WriteLine(Environment.NewLine + "Сортированный массив целых чисел методом пирамидальной сортировки:  " + string.Join(", ", array2));

            Console.ReadKey();
        }
    }
}
