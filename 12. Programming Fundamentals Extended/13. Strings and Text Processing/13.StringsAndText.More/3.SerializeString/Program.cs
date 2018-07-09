namespace _3.SerializeString
{
    using System;
    using System.Collections.Generic;

    public class SerializeString
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var database = new Dictionary<char, List<int>>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentSymbol = input[i];

                if (!database.ContainsKey(currentSymbol))
                {
                    database.Add(currentSymbol, new List<int>());

                    int index = -1;

                    while ((index = input.IndexOf(currentSymbol, index + 1)) > -1)
                    {
                        database[currentSymbol].Add(index);
                    }
                }
            }

            PrintOccurrencesOfTheSymbols(database);
        }

        public static void PrintOccurrencesOfTheSymbols(Dictionary<char, List<int>> database)
        {
            foreach (var item in database)
            {
                Console.WriteLine($"{item.Key}:{string.Join("/", item.Value)}");
            }
        }
    }
}
