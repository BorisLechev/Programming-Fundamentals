namespace _3.TravelCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TravelCompany
    {
        public static void Main()
        {
            var database = new Dictionary<string, Dictionary<string, int>>();
            var input = string.Empty;

            while ((input = Console.ReadLine()) != "ready")
            {
                var currentInput = input.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string city = currentInput[0];
                var vehicles = currentInput[1].Split(new char[] { ',', '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!database.ContainsKey(city))
                {
                    database.Add(city, new Dictionary<string, int>());
                }

                for (int i = 0; i < vehicles.Count - 1; i += 2)
                {
                    string vehicle = vehicles[i];
                    int capacity = int.Parse(vehicles[i + 1]);

                    if (!database[city].ContainsKey(vehicle))
                    {
                        database[city].Add(vehicle, capacity);
                    }

                    else
                    {
                        database[city][vehicle] = capacity;
                    }
                }
            }

            var finalLine = string.Empty;

            while ((finalLine = Console.ReadLine()) != "travel time!")
            {
                var inputAfterReady = finalLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string city = inputAfterReady[0];
                int peopleCount = int.Parse(inputAfterReady[1]);

                foreach (var offer in database)
                {
                    string town = offer.Key;
                    var vehicleCapacity = offer.Value;
                    int sum = 0;

                    if (town == city)
                    {
                        foreach (var item in vehicleCapacity)
                        {
                            sum += item.Value;
                        }

                        if (sum > peopleCount)
                        {
                            Console.WriteLine($"{town}-> all {peopleCount} accommodated");
                        }

                        else
                        {
                            Console.WriteLine($"{town} -> all except {peopleCount - sum} accommodated");
                        }
                    }
                }
            }
        }
    }
}
