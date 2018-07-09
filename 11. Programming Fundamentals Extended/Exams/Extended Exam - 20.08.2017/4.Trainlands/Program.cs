namespace _4.Trainlands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Trainlands                     
    {
        public static void Main()
        {
            var database = new Dictionary<string, Dictionary<string, int>>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "It's Training Men!")
            {
                var commands = input.Split().ToList();

                string trainName = commands[0];

                if (!database.ContainsKey(trainName))
                {
                    database.Add(trainName, new Dictionary<string, int>());
                }

                if (commands[1] == "->" && commands.Count == 3)
                {
                    string otherTrainName = commands[2];
                    var otherDictionary = database[otherTrainName];

                    foreach (var item in otherDictionary)
                    {
                        database[trainName].Add(item.Key, item.Value);
                    }

                    database.Remove(otherTrainName);
                }

                if (commands[1] == "->" && commands.Count > 3)
                {
                    string wagonName = commands[2];
                    int wagonPower = int.Parse(commands[4]);

                    database[trainName].Add(wagonName, wagonPower);
                }

                if (commands[1] == "=")
                {
                    string otherTrainName = commands[2];
                    var otherDatabase = database[otherTrainName];

                    database[trainName].Clear();

                    foreach (var item in otherDatabase)
                    {
                        database[trainName].Add(item.Key, item.Value);
                    }
                }
            }

            foreach (var item in database.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Count))
            {
                Console.WriteLine($"Train: {item.Key}");

                foreach (var wagon in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }
    }
}
