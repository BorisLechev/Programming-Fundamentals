namespace _4.ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ForceBook
    {
        public static void Main()
        {
            var forces = new Dictionary<string, List<string>>();
            var userByForces = new Dictionary<string, string>();

            string input = string.Empty;
            string firstPattern = @"(.*)\s\|\s(.*)";  //(.+?) (\|) (.+)
            string secondPattern = @"(.*)\s\->\s(.*)";  //(.+?) (\->) (.+)
            var firstRegex = new Regex(firstPattern);
            var secondRegex = new Regex(secondPattern);

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (firstRegex.IsMatch(input))
                {
                    var firstMatch = firstRegex.Matches(input);

                    foreach (Match match in firstMatch)
                    {
                        string forceSide = match.Groups[1].Value;
                        string forceUser = match.Groups[2].Value;

                        if (!userByForces.ContainsKey(forceUser))
                        {
                            userByForces.Add(forceUser, forceSide);

                            if (!forces.ContainsKey(forceSide))
                            {
                                forces.Add(forceSide, new List<string>());
                            }

                            forces[forceSide].Add(forceUser);
                        }
                    }
                }

                else if (secondRegex.IsMatch(input))
                {
                    var secondMatch = secondRegex.Matches(input);

                    foreach (Match match in secondMatch)
                    {
                        string forceUser = match.Groups[1].Value;
                        string forceSide = match.Groups[2].Value;

                        if (!userByForces.ContainsKey(forceUser))
                        {
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");

                            userByForces.Add(forceUser, forceSide);

                            if (!forces.ContainsKey(forceSide))
                            {
                                forces.Add(forceSide, new List<string>());
                            }

                            forces[forceSide].Add(forceUser);
                        }

                        else
                        {
                            string oldSide = userByForces[forceUser];

                            if (oldSide != forceSide)
                            {
                                forces[userByForces[forceUser]].Remove(forceUser);

                                if (!forces.ContainsKey(forceSide))
                                {
                                    forces.Add(forceSide, new List<string>());
                                }

                                forces[forceSide].Add(forceUser);
                                userByForces[forceUser] = forceSide;
                                Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                            }
                        }
                    }
                }
            }

            foreach (var force in forces.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (force.Value.Any())
                {
                    Console.WriteLine($"Side: {force.Key}, Members: {force.Value.Count}");

                    foreach (var user in force.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
