namespace _4.HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HornetArmada
    {
        public static void Main()
        {
            var legionWithActivity = new Dictionary<string, int>();
            var legionAndSoldiers = new Dictionary<string, Dictionary<string, long>>();

            int numberOfRows = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRows; i++)
            {
                var input = Console.ReadLine()
                    .Split(new string[] { " = ", " -> ", ":" }, StringSplitOptions.RemoveEmptyEntries);

                int lastActivity = int.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                long soldierCount = long.Parse(input[3]);

                if (!legionWithActivity.ContainsKey(legionName))
                {
                    legionWithActivity.Add(legionName, lastActivity);
                    legionAndSoldiers.Add(legionName, new Dictionary<string, long>());
                }

                if (lastActivity > legionWithActivity[legionName])
                {
                    legionWithActivity[legionName] = lastActivity;
                }

                if (!legionAndSoldiers[legionName].ContainsKey(soldierType))
                {
                    legionAndSoldiers[legionName][soldierType] = 0;
                }

                legionAndSoldiers[legionName][soldierType] += soldierCount;
            }

            var finalLine = Console.ReadLine().Split('\\').ToList();

            if (finalLine.Count == 2)
            {
                int activity = int.Parse(finalLine[0]);
                string soldiersToPrint = finalLine[1];

                foreach (var legion in legionAndSoldiers
                    .Where(legion => legion.Value.ContainsKey(soldiersToPrint))
                    .OrderByDescending(x => x.Value[soldiersToPrint]))
                {
                    if (legionWithActivity[legion.Key] < activity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legionAndSoldiers[legion.Key][soldiersToPrint]}");
                    }
                }
            }

            else
            {
                string soldiersToPrint = finalLine[0];

                foreach (var legion in legionWithActivity.OrderByDescending(x => x.Value))
                {
                    if (legionAndSoldiers[legion.Key].ContainsKey(soldiersToPrint))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }
            }
        }
    }
}
