namespace _2._1.SoftUni_Karaoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var database = new Dictionary<string, List<string>>();

            var participants = Console.ReadLine().Split(new string[] { ", " },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            var availableSongs = Console.ReadLine().Split(new string[] { ", " },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "dawn")
            {
                var currentInput = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string performer = currentInput[0];
                string song = currentInput[1];
                string award = currentInput[2];

                if (participants.Any(x => x == performer) && availableSongs.Any(x => x == song))
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

            foreach (var item in database.OrderByDescending(x => x.Value.Distinct().ToList().Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Distinct().Count()} awards");

                foreach (var participant in item.Value.Distinct().ToList().OrderBy(x => x))
                {
                    Console.WriteLine($"--{participant}");
                }
            }
        }
    }
}
