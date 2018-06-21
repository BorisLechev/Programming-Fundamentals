namespace _10.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegendaryFarming
    {
        public static void Main()
        {
            var junkItems = new Dictionary<string, int>();
            var possibleItems = new Dictionary<string, int>();

            possibleItems.Add("motes", 0);
            possibleItems.Add("shards", 0);
            possibleItems.Add("fragments", 0);

            bool currentInput = true;
            string legendaryItem = string.Empty;

            while (currentInput)
            {
                var input = Console.ReadLine().ToLower().Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int i = 0; i < input.Count; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        possibleItems[material] += quantity;
                    }

                    else
                    {
                        if (!junkItems.ContainsKey(material))
                        {
                            junkItems[material] = quantity;
                        }

                        else
                        {
                            junkItems[material] += quantity;
                        }
                    }

                    if (possibleItems.ContainsKey(material) && possibleItems[material] >= 250)
                    {
                        possibleItems[material] -= 250;
                        legendaryItem = material;
                        currentInput = false;
                        break;
                    }
                }
            }

            switch (legendaryItem)
            {
                case "shards":
                    Console.WriteLine("Shadowmourne obtained!");
                    break;

                case "fragments":
                    Console.WriteLine("Valanyr obtained!");
                    break;

                case "motes":
                    Console.WriteLine("Dragonwrath obtained!");
                    break;
            }

            foreach (var searchedItem in possibleItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{searchedItem.Key}: {searchedItem.Value}");
            }

            foreach (var junk in junkItems.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}
