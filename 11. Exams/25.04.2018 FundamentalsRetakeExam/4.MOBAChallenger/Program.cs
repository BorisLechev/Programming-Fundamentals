namespace _4.MOBAChallenger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MOBAChallenger
    {
        public static void Main()
        {
            var database = new Dictionary<string, Dictionary<string, int>>();
            var removedPlayers = new List<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Season end")
            {
                var currentInput = input.Split(new string[] { " -> ", " vs " },
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                string firstPlayer = currentInput[0];

                if (currentInput.Count == 3)
                {
                    string position = currentInput[1];
                    int skill = int.Parse(currentInput[2]);

                    if (!database.ContainsKey(firstPlayer))
                    {
                        database.Add(firstPlayer, new Dictionary<string, int>());
                    }

                    if (database[firstPlayer].ContainsKey(position))
                    {
                        if (database[firstPlayer][position] < skill)
                        {
                            database[firstPlayer][position] = skill;
                        }
                    }

                    else
                    {
                        database[firstPlayer].Add(position, skill);
                    }
                }

                else
                {
                    string secondPlayer = currentInput[1];

                    if (database.ContainsKey(firstPlayer) && database.ContainsKey(secondPlayer))
                    {
                        foreach (var position in database[firstPlayer])
                        {
                            if (database[secondPlayer].ContainsKey(position.Key))
                            {
                                int firstPlayerSkillPoints = database[firstPlayer][position.Key];
                                int secondPlayerSkillPoints = database[secondPlayer][position.Key];

                                if (firstPlayerSkillPoints > secondPlayerSkillPoints)
                                {
                                    removedPlayers.Add(secondPlayer);
                                }

                                else if (firstPlayerSkillPoints < secondPlayerSkillPoints)
                                {
                                    removedPlayers.Add(firstPlayer);
                                }
                            }
                        }
                    }
                }
            }

            foreach (var playerSkills in database.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                if (!removedPlayers.Contains(playerSkills.Key))
                {
                    Console.WriteLine($"{playerSkills.Key}: {playerSkills.Value.Values.Sum()} skill");

                    foreach (var positionAndSkill in playerSkills.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                    {
                        Console.WriteLine($"- {positionAndSkill.Key} <::> {positionAndSkill.Value}");
                    }
                }
            }
        }
    }
}
