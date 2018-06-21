namespace _4.SupermarketDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SupermarketDatabase
    {
        public static void Main()
        {
            var database = new Dictionary<string, decimal[]>();

            while (true)
            {
                var productData = Console.ReadLine().Split(' ').ToList();

                if (productData[0] == "stocked")
                {
                    break;
                }

                string product = productData[0];
                decimal price = decimal.Parse(productData[1]);
                int quantity = int.Parse(productData[2]);

                if (!database.ContainsKey(product))
                {
                    database[product] = new decimal[2];
                }

                database[product][0] = price;
                database[product][1] += quantity;
            }

            decimal grandTotal = 0;

            foreach (var item in database)
            {
                decimal stockPrice = item.Value[0] * item.Value[1];

                grandTotal += stockPrice;

                Console.WriteLine($"{item.Key}: ${item.Value[0]:f2} * {item.Value[1]} = ${stockPrice:f2}");
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }
}
