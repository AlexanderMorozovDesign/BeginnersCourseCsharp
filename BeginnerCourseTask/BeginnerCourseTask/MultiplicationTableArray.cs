using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTableArray
{
    class MultiplicationTableArray
    {
        public static int[,] GetMultiplicationTable(int endNumber)
        {
            int[,] multiplicationTable = new int[endNumber, endNumber];

            for (int i = 0; i < endNumber; i++)
            {
                for (int j = 0; j < endNumber; j++)
                {
                    multiplicationTable[i, j] = (i + 1) * (j + 1);
                }
            }

            return multiplicationTable;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа распечатывает таблицу умножения, размерность задается параметром ");

            Console.Write("Введите размерность таблицы умножения = ");
            int endNumber = Convert.ToInt32(Console.ReadLine());

            int[,] multiplicationTable = GetMultiplicationTable(endNumber);

            for (int i = 0; i < multiplicationTable.GetLength(0); ++i)
            {
                Console.WriteLine();

                for (int j = 0; j < multiplicationTable.GetLength(1); ++j)
                {
                    Console.Write("{0,4}", multiplicationTable[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}
