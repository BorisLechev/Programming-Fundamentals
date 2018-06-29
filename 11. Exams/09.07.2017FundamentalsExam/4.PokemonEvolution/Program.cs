namespace _4.PokemonEvolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PokemonEvolution
    {
        public static void Main()
        {
            var database = new Dictionary<string, List<string>>();

            var input = string.Empty;

            while ((input = Console.ReadLine()) != "wubbalubbadubdub")
            {
                var currentInput = input
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string pokemonName = currentInput[0];

                if (currentInput.Count > 1)
                {
                    if (!database.ContainsKey(pokemonName))
                    {
                        database[pokemonName] = new List<string>();
                    }

                    string points = currentInput[1] + " <-> " + int.Parse(currentInput[2]);

                    database[pokemonName].Add(points);
                }

                else
                {
                    if (database.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");

                        foreach (var item in database[pokemonName])
                        {
                            Console.WriteLine($"{item}");
                        }
                    }
                }
            }

            foreach (var evolutionType in database)
            {
                Console.WriteLine($"# {evolutionType.Key}");

                foreach (var evolutionIndex in evolutionType
                    .Value.OrderByDescending(x => int.Parse(x.Split(new string[] { " <-> " },
                    StringSplitOptions.RemoveEmptyEntries).Last())))
                {
                    Console.WriteLine(evolutionIndex);
                }
            }
        }
    }
}
