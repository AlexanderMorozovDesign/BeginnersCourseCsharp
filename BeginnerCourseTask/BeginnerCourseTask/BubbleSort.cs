using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    class BubbleSorting
    {
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool wereExchanges = false;

                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        wereExchanges = true;
                    }
                }

                if (!wereExchanges)
                {
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка пузырьком ");

            int[] array1 = { 83, 15, 76, 32, 84, 65, 12, 81, 46, 73, 55, 45, 37, 22, 14, 54, 75, 94, 3, 72, 51 };
            Console.WriteLine(Environment.NewLine + "Не сортированный массив целых чисел " + string.Join(", ", array1));

            BubbleSort(array1);
            Console.WriteLine(Environment.NewLine + "Сортированный массив целых чисел методом пузырька " + string.Join(", ", array1));

            int[] array2 = { 35, 68, 83, 26, 53, 96, 71, 58, 39, 63, 20, 59, 74, 43, 69, 82, 7, 24, 8, 6, 3 };
            Console.WriteLine(Environment.NewLine + "Не сортированный массив целых чисел " + string.Join(", ", array2));

            BubbleSort(array2);
            Console.WriteLine(Environment.NewLine + "Сортированный массив целых чисел методом пузырька " + string.Join(", ", array2));

            int[] array3 = { 1, 3, 2 };
            Console.WriteLine(Environment.NewLine + "Не сортированный массив целых чисел " + string.Join(", ", array3));

            BubbleSort(array3);
            Console.WriteLine(Environment.NewLine + "Сортированный массив целых чисел методом пузырька " + string.Join(", ", array3));

            Console.ReadKey();
        }
    }
}
