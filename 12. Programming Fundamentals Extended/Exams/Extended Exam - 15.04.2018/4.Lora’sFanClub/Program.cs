namespace _4.Lora_sFanClub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Lora_sFanClub             
    {
        public static void Main()
        {
            var database = new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Make a decision already!")
            {
                var currentInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string name = currentInput[0];

                if (!currentInput[currentInput.Count - 1].Contains("!"))
                {
                    string trait = currentInput[1];
                    int traitValue = int.Parse(currentInput[2]);

                    if (!database.ContainsKey(name))
                    {
                        database.Add(name, new Dictionary<string, int>());
                    }

                    if (database[name].ContainsKey(trait))
                    {
                        if (database[name][trait] < MultiplyTheValue(trait, traitValue))
                        {
                            database[name][trait] = MultiplyTheValue(trait, traitValue);
                        }
                    }

                    else
                    {
                        database[name].Add(trait, MultiplyTheValue(trait, traitValue));
                    }
                }

                else
                {
                    if (database.ContainsKey(name))
                    {
                        var traitsToRemove = new List<string>();

                        foreach (var currentTrait in database[name].Keys)
                        {
                            if (database[name][currentTrait] > 0)
                            {
                                traitsToRemove.Add(currentTrait);
                            }
                        }

                        foreach (var item in traitsToRemove)
                        {
                            database[name].Remove(item);
                        }
                    }
                }
            }

            foreach (var boy in database.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"# {boy.Key}: {boy.Value.Values.Sum()}");

                foreach (var trait in boy.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"!!! {trait.Key} -> {trait.Value}");
                }
            }
        }

        public static int MultiplyTheValue(string trait, int traitValue)
        {
            if (trait == "Greedy" || trait == "Rude" || trait == "Dumb")
            {
                traitValue *= -1;
            }

            else if (trait == "Kind")
            {
                traitValue *= 2;
            }

            else if (trait == "Handsome")
            {
                traitValue *= 3;
            }

            else if (trait == "Smart")
            {
                traitValue *= 5;
            }

            else
            {
                return traitValue;
            }

            return traitValue;
        }
    }
}
