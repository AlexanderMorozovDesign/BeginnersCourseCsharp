using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    /// <summary>
    /// Прочитать с консоли коэффициенты a, b и c квадратного уравнения 𝑎𝑥2+𝑏𝑥+𝑐=0и найти решение этого уравнения
    /// Не забыть рассмотреть все 3 случая когда есть 2 корня, 1 корень и нет решений
    /// Программа должна работать даже если уравнение не квадратное(a равен 0 ), например, решать линейное уравнение и т.д.
    /// </summary>
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты  a, b, c квадратного уравнения");

            Console.Write("Введите первый коэффициент квадратного уравнения = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второй коэффициент квадратного уравнения = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите третий (свободный) коэффициент квадратного уравнения = ");
            double c = Convert.ToDouble(Console.ReadLine());

            double epsilon = 1e-9;

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            if ((Math.Abs(a) < epsilon) && (Math.Abs(b) < epsilon))
            {
                if (Math.Abs(c) < epsilon)
                {
                    Console.WriteLine("Уравнение имеет бесконечное множество решений");
                }
                else
                {
                    Console.WriteLine("Уравнение не имеет решений");
                }
            }

            else if (Math.Abs(a) < epsilon)
            {
                double root = -c / b;

                Console.WriteLine("В этом случае квадратное уравнение имеет один корень = {0} ", root);
            }
            else
            {
                double discriminant = Math.Pow(b, 2) - 4 * a * c;
                Console.WriteLine("Дискриминант квадратного уравнения = {0}", discriminant);

                if (discriminant >= epsilon)
                {
                    Console.WriteLine("Дискриминант квадратного уравнения больше 0, корней два ");

                    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                    Console.WriteLine("Первый корень квадратного уравнения = {0}", root1);
                    Console.WriteLine("Второй корень квадратного уравнения = {0}", root2);
                }
                else if (Math.Abs(discriminant) < epsilon)
                {
                    Console.WriteLine("Квадратное уравнения имеет два корня, но они равны!");

                    double root = -b / (2 * a);

                    Console.WriteLine("Корни квадратного уравнения x1 = {0}, x2 = {1}", root, root);
                }
                else
                {
                    Console.WriteLine("Дискриминант квадратного уравнения меньше 0");
                    Console.WriteLine("Действительных корней у квадратного уравнения нет");
                }
            }

            Console.ReadKey();
        }
    }
}




