using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    /// <summary>
    /// Задача на курс «Площадь треугольника»
    /// Прочитать с консоли координаты трёх точек на плоскости: (x1, y1), (x2, y2), (x3, y3)
    /// Вычислить и вывести на экран площадь данного треугольника
    /// Для вычисления площади можно воспользоваться формулой Герона:
    /// Проверить на случай, когда эти точки лежат на одной прямой в этом случае 
    /// вычислять площадь не нужно, а нужно вывести сообщение об этом
    /// Для вычисления корня использовать команду
    /// </summary>
    class TriangleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты X для первой точки");
            double point1X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты Y для первой точки");
            double point1Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты X для второй точки");
            double point2X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты Y для второй точки");
            double point2Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты X для третей точки");
            double point3X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты Y для третей точки");
            double point3Y = Convert.ToDouble(Console.ReadLine());

            double epsilon = 1.0e-6;

            if (Math.Abs((point3X - point1X) * (point2Y - point1Y) - (point3Y - point1Y) * (point2X - point1X)) <= epsilon)
            {
                Console.WriteLine(Environment.NewLine + "Все точки лежат на одной прямой, площадь треугольника = 0");
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "Вычисление длин сторон треугольника между 3 точками");

                double firstSide = Math.Sqrt(Math.Pow(point1X - point2X, 2) + Math.Pow(point1Y - point2Y, 2));
                double secondSide = Math.Sqrt(Math.Pow(point2X - point3X, 2) + Math.Pow(point2Y - point3Y, 2));
                double thirdSide = Math.Sqrt(Math.Pow(point3X - point1X, 2) + Math.Pow(point3Y - point1Y, 2));

                Console.WriteLine("Длина первой стороны = {0}", firstSide);
                Console.WriteLine("Длина второй стороны = {0}", secondSide);
                Console.WriteLine("Длина третьей стороны = {0}", thirdSide);

                double trianglePerimeter = firstSide + secondSide + thirdSide;
                double halfPerimeter = trianglePerimeter / 2;

                Console.WriteLine(Environment.NewLine + "Длина периметра треугольника = {0}", trianglePerimeter);
                Console.WriteLine("Длина полупериметра треугольника = {0}", halfPerimeter);

                double triangleArea = Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide) * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide));
                Console.WriteLine("Площадь треугольника = {0}", triangleArea);
            }

            Console.ReadKey();
        }
    }

}
