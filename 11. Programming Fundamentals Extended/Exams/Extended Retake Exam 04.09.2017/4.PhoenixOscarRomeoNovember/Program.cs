namespace _4.PhoenixOscarRomeoNovember
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PhoenixOscarRomeoNovember
    {
        public static void Main()
        {
            var database = new Dictionary<string, List<string>>();
            var input = string.Empty;

            while ((input = Console.ReadLine()) != "Blaze it!")
            {
                var dataAboutFireCreatures = input.Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                string creature = dataAboutFireCreatures[0];
                string squadMate = dataAboutFireCreatures[1];

                if (!database.ContainsKey(creature))
                {
                    database.Add(creature, new List<string>());
                }

                if (creature != squadMate)
                {
                    database[creature].Add(squadMate);
                }
            }

            var result = new Dictionary<string, List<string>>();

            foreach (var item in database)
            {
                result.Add(item.Key, new List<string>());

                foreach (var squadMate in item.Value)
                {
                    if (database.ContainsKey(squadMate) && database[squadMate].Contains(item.Key))
                    {
                        continue;
                    }

                    else
                    {
                        result[item.Key].Add(squadMate);
                    }
                }
            }

            foreach (var item in result.OrderByDescending(x => x.Value.Distinct().ToList().Count))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Distinct().ToList().Count}");
            }
        }
    }
}
