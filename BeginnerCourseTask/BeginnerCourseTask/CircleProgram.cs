using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleProgram
{
    class CircleProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для расчета геометрических параметров окружности");

            Console.WriteLine("Введите радиус окружности ");
            double circle1Radius = Convert.ToDouble(Console.ReadLine());

            double circle1Area = Math.PI * Math.Pow(circle1Radius, 2);
            double circle1Length = 2 * Math.PI * circle1Radius;

            Console.WriteLine("Радиус окружности = " + circle1Radius);
            Console.WriteLine("Площадь окружности = " + circle1Area);
            Console.WriteLine("Длина окружности = " + circle1Length);

            Console.WriteLine(Environment.NewLine + "Программа для расчета радиуса окружности по площади");

            double circle2Area = 2349.789;
            double circle2Radius = Math.Sqrt(circle2Area / Math.PI);
            Console.WriteLine("Площадь окружности = " + circle2Area);
            Console.WriteLine("Вычисленный радиус = " + circle2Radius);

            Console.WriteLine(Environment.NewLine + "Программа для расчета площади сектора по углу и радиусу");

            double sectorRadius = 581.21;
            double sectorAngle = 48; // угол дуги сектора в градусах
            double sectorArea = Math.PI * Math.Pow(sectorRadius, 2) * (sectorAngle / 360);
            Console.WriteLine("Радиус сектора = " + sectorRadius);
            Console.WriteLine("Угол дуги сектора = " + sectorAngle);
            Console.WriteLine("Вычисленная площадь сектора круга = " + sectorArea);

            Console.ReadKey();
        }
    }
}
