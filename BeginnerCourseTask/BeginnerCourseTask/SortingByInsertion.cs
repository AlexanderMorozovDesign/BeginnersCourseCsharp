using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class SortingByInsertion
    {
        public static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int currentElement = array[i];
                int j = i;

                while (j > 0 && currentElement < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }

                array[j] = currentElement;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка вставками");

            int[] array1 = { 83, 15, 76, 32, 84, 65, 12, 81, 46, 73, 55, 45, 37, 22, 14, 54, 75, 94, 3, 72, 51 };
            Console.WriteLine(Environment.NewLine + "Не сортированный массив целых чисел: " + string.Join(", ", array1));

            InsertionSort(array1);
            Console.WriteLine(Environment.NewLine + "Сортированный массив целых чисел методом вставок: " + string.Join(", ", array1));

            int[] array2 = { 35, 68, 83, 26, 53, 96, 71, 58, 39, 63, 20, 59, 74, 43, 69, 82, 7, 24, 8, 6, 3 };
            Console.WriteLine(Environment.NewLine + "Не сортированный массив целых чисел: " + string.Join(", ", array2));

            InsertionSort(array2);
            Console.WriteLine(Environment.NewLine + "Сортированный массив целых чисел методом вставок:  " + string.Join(", ", array2));

            Console.ReadKey();
        }
    }
}
