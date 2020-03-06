using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearchIteration
    {
        public static int BinarySearch(int desiredValue, int[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (array[middle] == desiredValue)
                {
                    return middle;
                }

                if (array[middle] > desiredValue)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
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

            Console.WriteLine(Environment.NewLine + "Индекс искомого значения 16 в массиве = " + BinarySearch(16, array));
            Console.WriteLine("Индекс искомого значения 35 в массиве = " + BinarySearch(35, array));

            Console.ReadKey();
        }
    }
}
