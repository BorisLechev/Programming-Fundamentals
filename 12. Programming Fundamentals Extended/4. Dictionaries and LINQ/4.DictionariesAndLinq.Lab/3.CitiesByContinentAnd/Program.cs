namespace _3.CitiesByContinentAnd
{
    using System;
    using System.Collections.Generic;

    public class CitiesByContinentAnd
    {
        public static void Main()
        {
            var database = new Dictionary<string, Dictionary<string, List<string>>>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!database.ContainsKey(continent))
                {
                    database.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!database[continent].ContainsKey(country))
                {
                    database[continent].Add(country, new List<string>());
                }

                database[continent][country].Add(city);
            }

            foreach (var item in database)
            {
                string continent = item.Key;
                Console.WriteLine($"{continent}: ");

                var countries = item.Value;

                foreach (var country in countries)
                {
                    string currentCountry = country.Key;
                    var cities = country.Value;

                    Console.WriteLine($"  {currentCountry} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
