namespace _2.SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var participantsThatAppliedForPerformance = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var availableSongs = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var database = new Dictionary<string, List<string>>();

            var input = Console.ReadLine();

            while (input != "dawn")
            {
                var stagePerformance = input
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string name = stagePerformance[0];
                string song = stagePerformance[1];
                string award = stagePerformance[2];

                if (!participantsThatAppliedForPerformance.Any(x => x == name)
                    || !availableSongs.Any(x => x == song))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (!database.ContainsKey(name))
                {
                    database.Add(name, new List<string>());
                }

                database[name].Add(award);

                input = Console.ReadLine();
            }

            if (database.Count == 0)
            {
                Console.WriteLine("No awards");
            }

            foreach (var person in database
                .OrderByDescending(x => x.Value.Distinct().ToList().Count).ThenBy(x => x.Key))
            {
                var awardsList = person.Value.Distinct().ToList();

                Console.WriteLine($"{person.Key}: {awardsList.Count} awards");

                foreach (var item in awardsList.OrderBy(x => x))
                {
                    Console.WriteLine($"--{item}");
                }
            }
        }
    }
}
