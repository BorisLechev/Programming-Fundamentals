namespace _4.RainAir
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RainAir
    {
        public static void Main()
        {
            var database = new Dictionary<string, List<int>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "I believe I can fly!")
            {
                var currentInput = input.Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string originCustomerName = currentInput[0];

                if (Char.IsNumber(currentInput[1][0]))
                {
                    var customerFlights = new List<int>();

                    if (!database.ContainsKey(originCustomerName))
                    {
                        database.Add(originCustomerName, new List<int>());
                    }

                    database[originCustomerName].AddRange(currentInput.Skip(1).Select(int.Parse));
                }

                else
                {
                    string targetCustomerName = currentInput[1];

                    database[originCustomerName] = new List<int>(database[targetCustomerName]);
                }
            }

            foreach (var customers in database.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"#{customers.Key} ::: {string.Join(", ", customers.Value.OrderBy(x => x))}");
            }
        }
    }
}
