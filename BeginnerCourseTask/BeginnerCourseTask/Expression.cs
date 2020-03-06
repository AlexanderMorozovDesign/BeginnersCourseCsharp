using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionEvaluation
{
    class Expression
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление выражений");

            Console.WriteLine("x = 3 - ((56 - 12) / 44) * (4 / 2)");
            double x = 3 - ((56 - 12) / 44) * (4 / 2);

            Console.WriteLine("y = (2 * x) / (33 - x)");
            double y = (2 * x) / (33 - x);

            Console.WriteLine("z = -x / (2 * y)");
            double z = -x / (2 * y);

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);

            Console.ReadKey();
        }
    }
}
