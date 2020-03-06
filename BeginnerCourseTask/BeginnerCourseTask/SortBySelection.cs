using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortBySelection
{
    class SortBySelection
    {
        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minElement = array[i];
                int minElementIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < minElement)
                    {
                        minElement = array[j];
                        minElementIndex = j;
                    }
                }

                array[minElementIndex] = array[i];
                array[i] = minElement;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка выбором ");

            int[] array1 = { 83, 15, 76, 32, 84, 65, 12, 81, 46, 73, 55, 45, 37, 22, 14, 54, 75, 94, 3, 72, 51 };
            Console.WriteLine(Environment.NewLine + "Не сортированный массив целых чисел: " + string.Join(", ", array1));

            SelectionSort(array1);
            Console.WriteLine(Environment.NewLine + "Сортированный массив целых чисел методом выбора: " + string.Join(", ", array1));

            int[] array2 = { 35, 68, 83, 26, 53, 96, 71, 58, 39, 63, 20, 59, 74, 43, 69, 82, 7, 24, 8, 6, 3 };
            Console.WriteLine(Environment.NewLine + "Не сортированный массив целых чисел: " + string.Join(", ", array2));

            SelectionSort(array2);
            Console.WriteLine(Environment.NewLine + "Сортированный массив целых чисел методом выбора: " + string.Join(", ", array2));

            Console.ReadKey();
        }
    }
}
