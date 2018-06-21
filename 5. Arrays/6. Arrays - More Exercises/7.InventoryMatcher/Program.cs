namespace _7.InventoryMatcher
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
            string productName = Console.ReadLine();

            while (productName != "done")
            {
                int index = Array.IndexOf(products, productName);

                Console.WriteLine($"{productName} costs: {price[index]}; Available quantity: {quantities[index]}");

                productName = Console.ReadLine();
            }
        }
    }
}
