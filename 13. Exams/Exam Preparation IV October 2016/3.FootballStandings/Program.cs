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
            var scores = new Dictionary<string, int>();
            var goals = new Dictionary<string, int>();

            string boundariesToEscape = Regex.Escape(Console.ReadLine());
            string keyThatShouldBeDecrypted =
                $@".*{boundariesToEscape}(.*){boundariesToEscape}.*{boundariesToEscape}(.*){boundariesToEscape}.*?((\d+):(\d+))";

            string input = Console.ReadLine();

            while (input != "final")
            {
                Match match = Regex.Match(input, keyThatShouldBeDecrypted);

                string firstTeam = new string(match.Groups[1].Value.ToUpper().Reverse().ToArray());
                string secondTeam = new string(match.Groups[2].Value.ToUpper().Reverse().ToArray());

                int firstTeamScore = int.Parse(match.Groups[4].Value);
                int secondTeamScore = int.Parse(match.Groups[5].Value);

                if (!scores.ContainsKey(firstTeam))
                {
                    scores[firstTeam] = 0;
                }

                if (!scores.ContainsKey(secondTeam))
                {
                    scores[secondTeam] = 0;
                }

                if (!goals.ContainsKey(firstTeam))
                {
                    goals[firstTeam] = 0;
                }

                if (!goals.ContainsKey(secondTeam))
                {
                    goals[secondTeam] = 0;
                }

                goals[firstTeam] += firstTeamScore;
                goals[secondTeam] += secondTeamScore;

                if (firstTeamScore > secondTeamScore)
                {
                    scores[firstTeam] += 3;
                }

                else if (secondTeamScore > firstTeamScore)
                {
                    scores[secondTeam] += 3;
                }

                else
                {
                    scores[firstTeam] += 1;
                    scores[secondTeam] += 1;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

            int place = 1;

            foreach (var leagueStandings in scores.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{place}. {leagueStandings.Key} {leagueStandings.Value}");
                place++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var teamsWithMostScoredGoals in goals.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine($"- {teamsWithMostScoredGoals.Key} -> {teamsWithMostScoredGoals.Value}");
            }
        }
    }
}
