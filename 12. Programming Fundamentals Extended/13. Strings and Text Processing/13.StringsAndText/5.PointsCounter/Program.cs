namespace _5.PointsCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PointsCounter
    {
        public static void Main()
        {
            var pollutedText = Console.ReadLine();

            var teams = new Dictionary<string, Dictionary<string, int>>();

            string teamName = string.Empty;
            string playerName = string.Empty;

            while (pollutedText != "Result")
            {
                var pollutedInput = pollutedText
                    .Replace("@", string.Empty)
                    .Replace("%", string.Empty)
                    .Replace("$", string.Empty)
                    .Replace("*", string.Empty);

                var input = pollutedInput.Split('|');

                if (input[0].Last() > 96)
                {
                    playerName = input[0];
                    teamName = input[1];
                }

                else if (input[0].Last() < 91)
                {
                    teamName = input[0];
                    playerName = input[1];
                }

                int points = int.Parse(input[2]);

                if (!teams.ContainsKey(teamName))
                {
                    teams.Add(teamName, new Dictionary<string, int>());
                }

                teams[teamName][playerName] = points;

                pollutedText = Console.ReadLine();
            }

            foreach (var team in teams.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{team.Key} => {team.Value.Values.Sum()}");

                foreach (var player in team.Value.OrderByDescending(x => x.Value).Take(1))
                {
                    Console.WriteLine($"Most points scored by {player.Key}");
                }
            }
        }
    }
}
