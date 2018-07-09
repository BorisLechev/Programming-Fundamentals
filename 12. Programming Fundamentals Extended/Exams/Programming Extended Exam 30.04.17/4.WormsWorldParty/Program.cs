namespace _4.WormsWorldParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WormsWorldParty
    {
        public static void Main()
        {
            var database = new Dictionary<string, Dictionary<string, long>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "quit")
            {
                var currentInput = input.Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                var wormName = currentInput[0];
                var teamName = currentInput[1];
                var wormScore = long.Parse(currentInput[2]);

                bool hasWorm = true;

                foreach (var item in database)
                {
                    if (item.Value.ContainsKey(wormName))
                    {
                        hasWorm = false;
                    }
                }

                if (hasWorm)
                {
                    if (!database.ContainsKey(teamName))
                    {
                        database.Add(teamName, new Dictionary<string, long>());
                    }

                    database[teamName].Add(wormName, 0);
                    database[teamName][wormName] += wormScore;
                }
            }

            int count = 1;

            foreach (var team in database.OrderByDescending(x => x.Value.Values.Sum())
                .ThenByDescending(x => x.Value.Values.Sum() / x.Value.Values.Count))
            {
                Console.WriteLine($"{count}. Team: {team.Key} - {team.Value.Values.Sum()}");

                foreach (var item in team.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{item.Key} : {item.Value}");
                }

                count++;
            }
        }
    }
}
