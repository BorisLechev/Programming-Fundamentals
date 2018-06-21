namespace _7.SalesReport
{
    using System;
    using System.Collections.Generic;

    public class SalesReport
    {
        public static void Main()
        {
            int numberOfCities = int.Parse(Console.ReadLine());

            var sales = new List<Sale>();

            for (int i = 0; i < numberOfCities; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currentInput = new Sale
                {
                    City = input[0],
                    Product = input[1],
                    Price = decimal.Parse(input[2]),
                    Quantity = int.Parse(input[3])
                };

                sales.Add(currentInput);
            }

            var salesByCity = new SortedDictionary<string, decimal>();

            foreach (var sale in sales)
            {
                if (!salesByCity.ContainsKey(sale.City))
                {
                    salesByCity[sale.City] = 0;
                }

                salesByCity[sale.City] += sale.Price * sale.Quantity;
            }

            foreach (var result in salesByCity)
            {
                Console.WriteLine($"{result.Key} -> {result.Value:f2}");
            }

        }
    }

    public class Sale
    {
        public string City { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
