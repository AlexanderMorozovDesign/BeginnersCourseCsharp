using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineSplit
{
    class LineSplit
    {
        static void Main(string[] args)
        {
            string line = "1, 2, 3, 4, 5";

            Console.WriteLine(line);

            string[] numbersStrings = line.Split(',');

            int[] numbers = new int[numbersStrings.Length];

            int sum = 0;

            for (int i = 0; i < numbersStrings.Length; i++)
            {
                numbers[i] = Convert.ToInt32(numbersStrings[i]);
                sum += numbers[i];
            }

            Console.WriteLine(Environment.NewLine + "Массив чисел конвертированных из строки: " + string.Join(" ", numbers));
            Console.WriteLine("Сумма чисел массива = " + sum);

            Console.ReadKey();
        }
    }
}
