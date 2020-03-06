using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchRecursion
{
    class BinarySearchRecursion
    {
        public static int BinarySearch(int[] array, int left, int right, int desiredValue)
        {
            if (right < left)
            {
                return -1;
            }

            int middle = left + (right - left) / 2;

            if (array[middle] == desiredValue)
            {
                return middle;
            }

            if (array[middle] > desiredValue)
            {
                return BinarySearch(array, left, middle - 1, desiredValue);
            }
            else
            {
                return BinarySearch(array, middle + 1, right, desiredValue);
            }
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

            Console.WriteLine();
            Console.Write("Введите число от 1 до 21 = ");
            int desiredValue0 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число более 21 = ");
            int desiredValue1 = Convert.ToInt32(Console.ReadLine());

            int leftIndex = 0;
            int rightIndex = array.Length - 1;

            Console.WriteLine(Environment.NewLine + "Индекс искомого значения {0} в массиве: {1} ", desiredValue0, BinarySearch(array, leftIndex, rightIndex, desiredValue0));
            Console.WriteLine("Индекс искомого значения {0} в массиве: {1} ", desiredValue1, BinarySearch(array, leftIndex, rightIndex, desiredValue1));

            Console.ReadKey();
        }
    }
}
