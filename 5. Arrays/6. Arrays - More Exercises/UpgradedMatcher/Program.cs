namespace UpgradedMatcher
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            string[] orders = Console.ReadLine().Split(' ').ToArray();

            while (orders[0] != "done")
            {
                string orderProduct = orders[0];
                int index = Array.IndexOf(products, orderProduct);
                long orderedQuantity = long.Parse(orders[1]);

                if (quantities[index] >= orderedQuantity)
                {
                    quantities[index] -= orderedQuantity;
                    decimal orderedCost = price[index] * orderedQuantity;
                    Console.WriteLine($"{orders[index]} x {orderedQuantity} costs {orderedCost:f2}");
                }

                else
                {
                    Console.WriteLine($"We do not have enough {orders[index]}");
                }

                orders = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
