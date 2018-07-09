namespace _4._1.NSA
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NSA
    {
        public static void Main()
        {
            var database = new Dictionary<string, Dictionary<string, int>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "quit")
            {
                var currentInput = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var countryName = currentInput[0];
                var spyName = currentInput[1];
                var daysInService = int.Parse(currentInput[2]);

                if (!database.ContainsKey(countryName))
                {
                    database.Add(countryName, new Dictionary<string, int>());
                }

                if (!database[countryName].ContainsKey(spyName))
                {
                    database[countryName].Add(spyName, 0);
                }

                database[countryName][spyName] = daysInService;
            }

            foreach (var country in database.OrderByDescending(x => x.Value.Values.Count))
            {
                Console.WriteLine($"Country: {country.Key}");

                foreach (var spies in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"**{spies.Key} : {spies.Value}");
                }
            }
        }
    }
}
