namespace _7.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            var database = new Dictionary<string, Dictionary<string, long>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "report")
            {
                var currentInput = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string city = currentInput[0];
                string country = currentInput[1];
                long population = long.Parse(currentInput[2]);

                if (!database.ContainsKey(country))
                {
                    database.Add(country, new Dictionary<string, long>());
                }

                if (!database[country].ContainsKey(city))
                {
                    database[country].Add(city, population);
                }

                else
                {
                    database[country][city] += population;
                }
            }

            foreach (var country in database.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
