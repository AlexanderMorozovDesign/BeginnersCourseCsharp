using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureTranslation
{
    /// <summary>
    /// Задача на дом «Перевод температур»
    /// Написать программу, которая переводит температуру из градусов Цельсия в градусы Кельвина и Фаренгейта (Фаренгейта – на дом)
    /// Например, прочитать число – температуру в шкале Цельсия и напечатать две строки – в градусах Кельвина и Фаренгейта
    /// Перевод градусов Цельсия в градусы Кельвина и перевод в градусы Фаренгейта оформить отдельными функциями
    /// Формулы найти в интернете
    /// </summary>
    class TemperatureTranslation
    {
        public static double ConvertToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        public static double ConvertToFahrenheit(double celsius)
        {
            return 1.8 * celsius + 32;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите температуру в Цельсиях для конвертации в Кельвины и Фаренгейты = ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double kelvin = ConvertToKelvin(celsius);
            Console.WriteLine("Температура по шкале Кельвина = " + kelvin);

            double fahrenheit = ConvertToFahrenheit(celsius);
            Console.WriteLine("Температура по шкале Фаренгейта = " + fahrenheit);

            Console.ReadKey();
        }
    }
}
