namespace _4.ExamShopping
{
    using System;
    using System.Collections.Generic;

    public class ExamShopping
    {
        public static void Main()
        {
            var database = new Dictionary<string, int>();
            var input = Console.ReadLine().Split(' ');

            while (input[0] != "shopping" && input[1] != "time")
            {
                string name = input[1];
                int quantity = int.Parse(input[2]);

                if (!database.ContainsKey(name))
                {
                    database[name] = 0;
                }

                database[name] += quantity;

                input = Console.ReadLine().Split(' ');
            }

            input = Console.ReadLine().Split(' ');

            while (input[0] != "exam" && input[1] != "time")
            {
                string name = input[1];
                int quantity = int.Parse(input[2]);

                if (!database.ContainsKey(name))
                {
                    Console.WriteLine($"{name} doesn't exist");
                }

                else if (database[name] <= 0)
                {
                    Console.WriteLine($"“{name} out of stock");
                }

                else
                {
                    database[name] -= quantity;

                    if (database[name] < 0)
                    {
                        database[name] = 0;
                    }
                }

                input = Console.ReadLine().Split(' ');
            }

            foreach (var items in database)
            {
                if (items.Value > 0)
                {
                    Console.WriteLine($"{items.Key} -> {items.Value}");
                }
            }
        }
    }
}
