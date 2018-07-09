namespace _4._1HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class HornetArmada
    {
        public static void Main()
        {
            var legionWithActivity = new Dictionary<string, int>();
            var legionWithSoldiers = new Dictionary<string, Dictionary<string, long>>();

            short number = short.Parse(Console.ReadLine());
            var pattern = @"(\d+)\s+\=\s+(.*)\s+\->\s+(.*)\:(\d+)";

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                var match = Regex.Match(input, pattern);

                int lastActivity = int.Parse(match.Groups[1].Value);
                string legionName = match.Groups[2].Value;
                string soldierType = match.Groups[3].Value;
                int soldierCount = int.Parse(match.Groups[4].Value);

                if (!legionWithActivity.ContainsKey(legionName))
                {
                    legionWithActivity.Add(legionName, lastActivity);
                    legionWithSoldiers.Add(legionName, new Dictionary<string, long>());
                }

                if (lastActivity > legionWithActivity[legionName])
                {
                    legionWithActivity[legionName] = lastActivity;
                }

                if (!legionWithSoldiers[legionName].ContainsKey(soldierType))
                {
                    legionWithSoldiers[legionName].Add(soldierType, 0);
                }

                legionWithSoldiers[legionName][soldierType] += soldierCount;
            }

            var finalLine = Console.ReadLine().Split(new char[] { '\\' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            if (finalLine.Count > 1)
            {
                int lastActivity = int.Parse(finalLine[0]);
                string soldierType = finalLine[1];

                foreach (var legion in legionWithSoldiers.Where(x => x.Value.ContainsKey(soldierType))
                    .OrderByDescending(x => x.Value[soldierType]))
                {
                    if (legionWithActivity[legion.Key] < lastActivity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legionWithSoldiers[legion.Key][soldierType]}");
                    }
                }
            }

            else
            {
                var soldierType = finalLine[0];

                foreach (var legions in legionWithActivity.OrderByDescending(x => x.Value))
                {
                    if (legionWithSoldiers[legions.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{legions.Value} : {legions.Key}");
                    }
                }
            }
        }
    }
}
