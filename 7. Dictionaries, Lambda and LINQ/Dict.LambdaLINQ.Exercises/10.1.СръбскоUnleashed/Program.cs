namespace _10._1.СръбскоUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class СръбскоUnleashed
    {
        public static void Main()
        {
            var database = new Dictionary<string, Dictionary<string, int>>();

            string pattern = @"([A-Za-z\s]+)\s@([A-Za-z\s]+)\s(\d+)\s(\d+)";
            var regex = new Regex(pattern);

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                var match = regex.Match(input);

                if (match.Success)
                {
                    string singer = match.Groups[1].Value;
                    string venue = match.Groups[2].Value;
                    int ticketPrice = int.Parse(match.Groups[3].Value);
                    int ticketCount = int.Parse(match.Groups[4].Value);

                    if (!database.ContainsKey(venue))
                    {
                        database.Add(venue, new Dictionary<string, int>());
                    }

                    if (!database[venue].ContainsKey(singer))
                    {
                        database[venue].Add(singer, ticketPrice * ticketCount);
                    }

                    else
                    {
                        database[venue][singer] += ticketPrice * ticketCount;
                    }
                }
            }

            foreach (var city in database)
            {
                Console.WriteLine($"{city.Key}");

                foreach (var singer in city.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
