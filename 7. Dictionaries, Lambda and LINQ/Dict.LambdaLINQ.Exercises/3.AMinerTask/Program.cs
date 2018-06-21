namespace _3.AMinerTask
{
    using System;
    using System.Collections.Generic;

    public class AMinerTask
    {
        public static void Main()
        {
            var resources = new Dictionary<string, long>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "stop")
            {
                string metal = input;
                long quantity = long.Parse(Console.ReadLine());

                if (!resources.ContainsKey(metal))
                {
                    resources.Add(metal, quantity);
                }

                else
                {
                    resources[metal] += quantity;
                }
            }

            foreach (var metal in resources)
            {
                Console.WriteLine($"{metal.Key} -> {metal.Value}");
            }
        }
    }
}
