namespace _4._1.AnonymousCache
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AnonymousCache
    {
        public static void Main()
        {
            var database = new Dictionary<string, Dictionary<string, long>>();

            var input = string.Empty;

            while ((input = Console.ReadLine()) != "thetinggoesskrra")
            {
                var currentInput = input.Split(new string[] { " -> ", " | " },
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                if (currentInput.Count > 1)
                {
                    string dataKey = currentInput[0];
                    long dataSize = long.Parse(currentInput[1]);
                    string dataSet = currentInput[2];

                    if (!database.ContainsKey(dataSet))
                    {
                        database.Add(dataSet, new Dictionary<string, long>());
                    }

                    if (!database[dataSet].ContainsKey(dataKey))
                    {
                        database[dataSet].Add(dataKey, 0);
                    }

                    database[dataSet][dataKey] = dataSize;
                }
            }

            if (database.Count() > 1)
            {                 //database.OrderByDescending(x => x.Value.Sum(y => y.Value)).First()
                var maxValue = database.OrderByDescending(x => x.Value.Values.Sum()).First();

                Console.WriteLine($"Data Set: {maxValue.Key}, Total Size: {maxValue.Value.Values.Sum()}");//maxValue.Value.Sum(x => x.Value)

                foreach (var dataKeys in maxValue.Value)
                {
                    Console.WriteLine($"$.{dataKeys.Key}");
                }
            }
        }
    }
}
