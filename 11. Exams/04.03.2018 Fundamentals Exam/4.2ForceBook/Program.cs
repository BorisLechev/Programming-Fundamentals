namespace _4._2ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ForceBook
    {
        public static void Main()
        {
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Lumpawaroo")
                {
                    break;
                }

                if (line.Contains("|"))
                {
                    string[] tokens = line.Split(" | ");
                    string side = tokens[0];
                    string user = tokens[1];

                    if (!sides.ContainsKey(side))
                    {
                        sides.Add(side, new List<string>());
                    }

                    if (!sides.Values.Any(x => x.Contains(user)))
                    {
                        sides[side].Add(user);
                    }
                }

                else
                {
                    string[] tokens = line.Split(" -> ");
                    string side = tokens[1];
                    string user = tokens[0];

                    if (sides.Values.Any(x => x.Contains(user)))
                    {
                        sides.Values.First(x => x.Contains(user)).Remove(user);

                        if (!sides.ContainsKey(side))
                        {
                            sides.Add(side, new List<string>());
                        }

                        sides[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }

                    else
                    {
                        if (!sides.ContainsKey(side))
                        {
                            sides.Add(side, new List<string>());
                        }

                        sides[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
            }

            foreach (var kvp in sides.OrderByDescending(kvp => kvp.Value.Count).ThenBy(kvp => kvp.Key))
            {
                if (kvp.Value.Count != 0)
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                    foreach (string user in kvp.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
