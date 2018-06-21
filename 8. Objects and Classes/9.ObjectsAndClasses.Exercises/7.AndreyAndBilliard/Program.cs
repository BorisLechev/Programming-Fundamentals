namespace _7.AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AndreyAndBilliard
    {
        public static void Main()
        {
            int amountOfEntities = int.Parse(Console.ReadLine());
            var shop = new Dictionary<string, decimal>();

            for (int i = 0; i < amountOfEntities; i++)
            {
                var availableEntities = Console.ReadLine().Split('-').ToList();
                string product = availableEntities[0];
                decimal price = decimal.Parse(availableEntities[1]);

                if (!shop.ContainsKey(product))
                {
                    shop.Add(product, price);
                }

                else
                {
                    shop[product] = price;
                }
            }

            var customers = new List<Customer>();
            string inputOrder = Console.ReadLine();

            while (inputOrder != "end of clients")
            {
                var orders = inputOrder.Split(new char[] { '-', ',' },
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                string customerName = orders[0];
                string productOrder = orders[1];
                int quantityOrder = int.Parse(orders[2]);

                if (shop.ContainsKey(productOrder))
                {
                    decimal customerBill = quantityOrder * shop[productOrder];

                    Customer customer = new Customer
                    {
                        Name = customerName,
                        ShopList = new Dictionary<string, int>(),
                        Bill = customerBill
                    };

                    customer.ShopList.Add(productOrder, quantityOrder);

                    if (customers.Any(x => x.Name == customerName))
                    {
                        //If customer makes new order.
                        var currentCustomer = customers.First(x => x.Name == customerName);

                        if (currentCustomer.ShopList.ContainsKey(productOrder))
                        {
                            //If customer orders the same product.
                            currentCustomer.ShopList[productOrder] += quantityOrder;
                            currentCustomer.Bill += shop[productOrder] * quantityOrder;
                        }

                        else
                        {
                            //If customer orders new product.
                            currentCustomer.ShopList[productOrder] = quantityOrder;
                            currentCustomer.Bill += shop[productOrder] * quantityOrder;
                        }
                    }

                    else
                    {
                        customers.Add(customer);
                    }
                }

                inputOrder = Console.ReadLine();
            }

            foreach (var customer in customers.OrderBy(x => x.Name))
            {
                Console.WriteLine(customer.Name);

                foreach (var item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }

                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }

            Console.WriteLine($"Total bill: {customers.Sum(x => x.Bill):f2}");
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public decimal Bill { get; set; }
    }
}
