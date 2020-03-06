using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevertArray
{
    class ReverseArray
    {
        public static void RevertArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Массив чисел от 1 до 21 ");

            int[] array = new int[21] { 7, 11, 17, 2, 21, 16, 3, 17, 14, 19, 17, 19, 14, 8, 10, 6, 17, 8, 15, 3, 1 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }

            RevertArray(array);
            Console.WriteLine(Environment.NewLine + "Вывод обратного массива чисел от 21 до 1:  " + string.Join(", ", array));

            Console.ReadKey();
        }
    }
}
