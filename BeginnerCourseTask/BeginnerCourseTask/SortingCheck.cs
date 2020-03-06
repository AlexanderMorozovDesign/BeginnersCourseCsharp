using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCheck
{
    class SortingCheck
    {
        public static bool IsArraySortedAscending(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsArraySortedDescending(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Массив чисел от 1 до 21 ");

            int[] array = new int[21];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
                Console.Write(" " + array[i]);
            }

            Console.WriteLine(Environment.NewLine + "Массив отсортирован по возрастанию? = " + IsArraySortedAscending(array));
            Console.WriteLine("Массив отсортирован по убыванию? = " + IsArraySortedDescending(array));

            Console.WriteLine(Environment.NewLine + "Массив чисел от 21 до 1 ");

            int[] array1 = new int[21];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = array1.Length - i;
                Console.Write(" " + array1[i]);
            }

            Console.WriteLine(Environment.NewLine + "Массив отсортирован по возрастанию? = " + IsArraySortedAscending(array1));
            Console.WriteLine("Массив отсортирован по убыванию? = " + IsArraySortedDescending(array1));

            Console.ReadKey();
        }
    }
}
