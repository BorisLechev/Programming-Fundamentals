namespace _1.SoftUniCoffeeOrders
{
    using System;
    using System.Globalization;

    public class SoftUniCoffeeOrders
    {
        public static void Main()
        {
            short countOfOrders = short.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 0; i < countOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                decimal orderPrice = daysInMonth * capsulesCount * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");

                totalPrice += orderPrice;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
