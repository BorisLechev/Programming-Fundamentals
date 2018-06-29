namespace _4._1.ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ForceBook
    {
        public static void Main()
        {
            var forces = new Dictionary<string, List<string>>();
            var userByForces = new Dictionary<string, string>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                var currentInput = input.Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (input.Contains("|"))
                {
                    string forceSide = currentInput[0];
                    string forceUser = currentInput[1];

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

                else if (input.Contains("->"))
                {
                    string forceUser = currentInput[0];
                    string forceSide = currentInput[1];

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
                        if (userByForces[forceUser] != forceSide)
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

            foreach (var forceSide in forces.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (forceSide.Value.Any())
                {
                    Console.WriteLine($"Side: {forceSide.Key}, Members: {forceSide.Value.Count}");

                    foreach (var forceUser in forceSide.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {forceUser}");
                    }
                }
            }
        }
    }
}
