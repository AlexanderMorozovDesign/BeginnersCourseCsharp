using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCost
{
    /// <summary>
    /// Задача на дом «Стоимость заказа»
    /// Написать функцию для расчета стоимости заказа с учетом скидок
    /// Всего есть два вида товаров, в заказ может входить некоторое количество товаров одного типа и другого типа
    /// Скидка 5% начисляется, если суммарное количество товаров в заказе не меньше 10
    /// Скидка 5% начисляется, если суммарная стоимость заказа не меньше 1000 рублей
    /// Если выполняются оба условия, то скидка 10% от начальной стоимости
    /// </summary>
    class OrderCost
    {
        public static double GetOrderCost(int firstProductAmount, double firstProductPrice, int secondProductAmount, double secondProductPrice)
        {
            double totalPriceWithoutDiscount = firstProductPrice * firstProductAmount + secondProductPrice * secondProductAmount;
            int totalAmount = firstProductAmount + secondProductAmount;

            const double amountAndCostDiscount = 0.9;
            const double amountOrCostDiscount = 0.95;
            const int discountsProductAmount = 10;
            const int discountsProductPrice = 1000;

            double result = totalPriceWithoutDiscount;

            if (totalAmount >= discountsProductAmount && totalPriceWithoutDiscount >= discountsProductPrice)
            {
                result = amountAndCostDiscount * totalPriceWithoutDiscount;
            }
            else if (totalPriceWithoutDiscount >= discountsProductPrice || totalAmount >= discountsProductAmount)
            {
                result = amountOrCostDiscount * totalPriceWithoutDiscount;
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Сколько Вы купили пачек печенья? ");
            int firstProductAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Цена одной пачки печенья? ");
            double firstProductPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сколько Вы купили пакетиков кофе? ");
            int secondProductAmount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Цена одного пакетика кофе? ");
            double secondProductPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Общая стоймость товаров с учётом скидок = {0} ", GetOrderCost(firstProductAmount, firstProductPrice, secondProductAmount, secondProductPrice));

            Console.ReadKey();
        }
    }
}
