using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class QuickSorting
    {
        public static void QuickSort(int[] array)
        {
            if (array.Length < 2)
            {
                return;
            }

            int left = 0;
            int right = array.Length - 1;

            QuickSortAlgorithm(array, left, right);
        }

        public static void QuickSortAlgorithm(int[] array, int left, int right)
        {
            int supportingElement = array[(right + left) / 2];
            int i = left;
            int j = right;

            while (i <= j)
            {
                while (array[i] < supportingElement)
                {
                    i++;
                }

                while (array[j] > supportingElement)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                    i++;
                    j--;
                }
            }

            if (i < right)
            {
                QuickSortAlgorithm(array, i, right);
            }

            if (j > left)
            {
                QuickSortAlgorithm(array, left, j);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Быстрая сортировка");

            int[] array1 = { 83, 15, 76, 32, 84, 65, 12, 81, 46, 73, 55, 45, 37, 22, 14, 54, 75, 94, 3, 72, 51 };
            Console.WriteLine(Environment.NewLine + "Не сортированный массив целых чисел " + string.Join(", ", array1));

            QuickSort(array1);
            Console.WriteLine(Environment.NewLine + "Сортированный массив целых чисел методом быстрой сортировки " + string.Join(", ", array1));

            int[] array2 = { 35, 68, 83, 26, 53, 96, 71, 58, 39, 63, 20, 59, 74, 43, 69, 82, 7, 24, 8, 6, 3 };
            Console.WriteLine(Environment.NewLine + "Не сортированный массив целых чисел " + string.Join(", ", array2));

            QuickSort(array2);
            Console.WriteLine(Environment.NewLine + "Сортированный массив целых чисел методом быстрой сортировки  " + string.Join(", ", array2));

            Console.ReadKey();
        }
    }
}
