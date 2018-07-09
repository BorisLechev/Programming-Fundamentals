namespace _4.AnonymousCache
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AnonymousCache
    {
        public static void Main()
        {
            var data = new Dictionary<string, Dictionary<string, long>>();
            var cache = new Dictionary<string, Dictionary<string, long>>();
            var input = string.Empty;

            while ((input = Console.ReadLine()) != "thetinggoesskrra")
            {
                var inputParameters = input.Split(new char[] { ' ', '-', '>', '|' },
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                if (inputParameters.Count == 1)
                {
                    var dataSet = inputParameters[0];

                    if (cache.ContainsKey(dataSet))
                    {
                        data[dataSet] = new Dictionary<string, long>(cache[dataSet]); //!
                        cache.Remove(dataSet);
                    }

                    else
                    {
                        data[dataSet] = new Dictionary<string, long>();
                    }
                }

                else
                {
                    var dataKey = inputParameters[0];
                    var dataSize = long.Parse(inputParameters[1]);
                    var dataSet = inputParameters[2];

                    if (!data.ContainsKey(dataSet))
                    {
                        if (!cache.ContainsKey(dataSet))
                        {
                            cache[dataSet] = new Dictionary<string, long>();
                        }

                        cache[dataSet].Add(dataKey, dataSize);
                    }

                    else
                    {
                        data[dataSet].Add(dataKey, dataSize);
                    }
                }
            }

            if (data.Count > 0)
            {
                var result = data.OrderByDescending(x => x.Value.Sum(y => y.Value)).First();

                Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Sum(x => x.Value)}");

                string prefix = "$.";

                foreach (var dataKeys in result.Value)
                {
                    Console.WriteLine($"{prefix}{dataKeys.Key}");
                }
            }
        }
    }
}
