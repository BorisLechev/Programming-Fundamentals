namespace _3._1.SerializeString
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
                char currentSymbol = input[i];
                var positions = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        positions.Add(j);
                    }

                    database[currentSymbol] = positions;
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
