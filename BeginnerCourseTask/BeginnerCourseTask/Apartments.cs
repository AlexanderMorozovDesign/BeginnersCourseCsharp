using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartments
{
    /// <summary>
    /// Программа по введенному номеру квартиры выдаёт номер подъезда и этажа, 
    /// где находится эта квартира, а также положение квартиры на лестничной площадке.
    /// </summary>
    class Apartments
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа по введенному числу выдаёт номер подъезда и этажа, где находится эта квартира, а также положение квартиры на лестничной площадке");
            
            Console.WriteLine(Environment.NewLine + "Введите количество этажей в доме: ");
            int floorsInHouseAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество подъездов в доме: ");
            int entranceInHouseAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер искомой квартиры: ");
            int apartmentNumber = Convert.ToInt32(Console.ReadLine());

            int apartmentsInFloorAmount = 4;
            Console.WriteLine(Environment.NewLine + "Количество квартир на площадке = " + apartmentsInFloorAmount);

            int apartmentsInEntranceAmount = floorsInHouseAmount * apartmentsInFloorAmount;
            Console.WriteLine("Количество квартир в подъезде = " + apartmentsInEntranceAmount);

            int apartmentsInHouseAmount = apartmentsInFloorAmount * floorsInHouseAmount * entranceInHouseAmount;
            Console.WriteLine("Общее количество квартир в доме = " + apartmentsInHouseAmount);

            if (apartmentNumber < 1 || apartmentNumber > apartmentsInHouseAmount)
            {
                Console.WriteLine(Environment.NewLine + "Квартиры с номером " + apartmentNumber + " нет в этом доме, сходите в следующий :)");
            }
            else
            {
                int entranceNumber = ((apartmentNumber - 1) / apartmentsInEntranceAmount) + 1;
                int floorNumber = (((apartmentNumber - 1) % apartmentsInEntranceAmount)) / apartmentsInFloorAmount + 1;
                int apartmentLocationIndex = apartmentNumber % apartmentsInFloorAmount;
                string apartmentLocationLine;

                if (apartmentLocationIndex == 0)
                {
                    apartmentLocationLine = "ближняя справа";
                }
                else if (apartmentLocationIndex == 1)
                {
                    apartmentLocationLine = "ближняя слева, квартира";
                }
                else if (apartmentLocationIndex == 2)
                {
                    apartmentLocationLine = "дальняя слева, квартира";
                }
                else
                {
                    apartmentLocationLine = "дальняя справа, квартира";
                }

                Console.WriteLine(Environment.NewLine + "Искомая квартира находится: {0} подъезд, {1} этаж, {2}", entranceNumber, floorNumber, apartmentLocationLine);
                Console.WriteLine("Добро Пожаловать, Вы прибыли :), ...Проходи. Садись. Закуривай! :)");
            }

            Console.ReadKey();
        }
    }
}
