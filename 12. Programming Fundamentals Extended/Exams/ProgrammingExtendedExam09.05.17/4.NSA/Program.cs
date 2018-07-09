namespace _4.NSA
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class NSA
    {
        public static void Main()
        {
            var database = new Dictionary<string, Dictionary<string, int>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "quit")
            {
                string pattern = @"(?<country>\w+)\s->\s(?<spyName>\w+)\s->\s(?<daysInService>\d+)";
                var match = Regex.Match(input, pattern);

                string country = match.Groups["country"].Value;
                string spyName = match.Groups["spyName"].Value;
                int daysInService = int.Parse(match.Groups["daysInService"].Value);

                if (!database.ContainsKey(country))
                {
                    database.Add(country, new Dictionary<string, int>());
                }

                if (!database[country].ContainsKey(spyName))
                {
                    database[country].Add(spyName, 0);
                }

                database[country][spyName] = daysInService;
            }

            foreach (var country in database.OrderByDescending(x => x.Value.Count()))
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
