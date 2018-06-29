namespace _4.Weather
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Weather
    {
        public static void Main()
        {
            var database = new Dictionary<string, Dictionary<double, string>>();

            string pattern = @"([A-Z]{2})(\d+.\d+)([A-Za-z]+)\|";

            string input = Console.ReadLine();

            while (input != "end")
            {
                MatchCollection regex = Regex.Matches(input, pattern);

                foreach (Match match in regex)
                {
                    string city = match.Groups[1].Value;
                    double averageTemperature = double.Parse(match.Groups[2].Value);
                    string typeOfWeather = match.Groups[3].Value;

                    if (database.ContainsKey(city))
                    {
                        database.Remove(city);
                    }

                    if (!database.ContainsKey(city))
                    {
                        database[city] = new Dictionary<double, string>();
                        database[city].Add(averageTemperature, typeOfWeather);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var printCity in database.OrderBy(x => x.Value.Keys.Average()))
            {
                foreach (var item in printCity.Value)
                {
                    Console.WriteLine($"{printCity.Key} => {item.Key:f2} => {item.Value}");
                }
            }
        }
    }
}
