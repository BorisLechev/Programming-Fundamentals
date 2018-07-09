namespace _2._2SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var database = new Dictionary<string, List<string>>();

            var participants = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var availableSongs = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "dawn")
            {
                var stagePerformance = input
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string performer = stagePerformance[0];
                string song = stagePerformance[1];
                string award = stagePerformance[2];

                if (participants.Contains(performer) && availableSongs.Contains(song))
                {
                    if (!database.ContainsKey(performer))
                    {
                        database.Add(performer, new List<string>());
                    }

                    database[performer].Add(award);
                }
            }

            if (!database.Any())
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var participant in database.OrderByDescending(x => x.Value.Distinct().Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Distinct().Count()} awards");

                foreach (var item in participant.Value.Distinct().OrderBy(x => x))
                {
                    Console.WriteLine($"--{item}");
                }
            }
        }
    }
}
