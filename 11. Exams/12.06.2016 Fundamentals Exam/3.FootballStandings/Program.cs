namespace _3.FootballStandings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class FootballStandings
    {
        public static void Main()
        {
            var leagueStandings = new Dictionary<string, int>();
            var scoredGoals = new Dictionary<string, int>();

            var key = Regex.Escape(Console.ReadLine());
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "final")
            {
                string pattern = $@".*{key}(.*){key}.*{key}(.*){key}.*?((\d+):(\d+))";
                var match = Regex.Match(input, pattern);

                var firstTeam = new string(match.Groups[1].Value.ToUpper().Reverse().ToArray());
                var secondTeam = new string(match.Groups[2].Value.ToUpper().Reverse().ToArray());
                var firstTeamScore = int.Parse(match.Groups[4].Value);
                var secondTeamScore = int.Parse(match.Groups[5].Value);

                if (!leagueStandings.ContainsKey(firstTeam))
                {
                    leagueStandings.Add(firstTeam, 0);
                }

                if (!leagueStandings.ContainsKey(secondTeam))
                {
                    leagueStandings.Add(secondTeam, 0);
                }

                if (!scoredGoals.ContainsKey(firstTeam))
                {
                    scoredGoals.Add(firstTeam, 0);
                }

                if (!scoredGoals.ContainsKey(secondTeam))
                {
                    scoredGoals.Add(secondTeam, 0);
                }

                scoredGoals[firstTeam] += firstTeamScore;
                scoredGoals[secondTeam] += secondTeamScore;

                if (firstTeamScore > secondTeamScore)
                {
                    leagueStandings[firstTeam] += 3;
                }

                if (secondTeamScore > firstTeamScore)
                {
                    leagueStandings[secondTeam] += 3;
                }

                else if (secondTeamScore == firstTeamScore)
                {
                    leagueStandings[firstTeam] += 1;
                    leagueStandings[secondTeam] += 1;
                }
            }

            Console.WriteLine("League standings:");
            int position = 1;

            foreach (var points in leagueStandings.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{position}. {points.Key} {points.Value}");
                position++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var goals in scoredGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine($"- {goals.Key} -> {goals.Value}");
            }
        }
    }
}
