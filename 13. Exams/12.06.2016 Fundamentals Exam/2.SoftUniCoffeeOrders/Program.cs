namespace _2.SoftUniCoffeeOrders
{
    using System;
    using System.Globalization;

    public class SoftUniCoffeeOrders
    {
        public static void Main()
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            decimal totalCheck = 0;

            for (int i = 0; i < countOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                decimal price = (daysInMonth * capsulesCount) * pricePerCapsule;
                totalCheck += price;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }

            Console.WriteLine($"Total: ${totalCheck:f2}");
        }
    }
}
