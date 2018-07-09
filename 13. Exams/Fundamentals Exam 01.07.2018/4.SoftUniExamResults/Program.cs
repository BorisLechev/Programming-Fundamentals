using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)   //100
        {
            var databaseWithValues = new Dictionary<string, int>();
            var databaseCount = new Dictionary<string, int>();

            string input = string.Empty;

            var removed = new List<string>();

            while ((input = Console.ReadLine()) != "exam finished")
            {
                var currentInput = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string username = currentInput[0];
                string language = currentInput[1];


                if (currentInput[1] != "banned")
                {
                    int points = int.Parse(currentInput[2]);

                    if (!databaseCount.ContainsKey(language))
                    {
                        databaseCount.Add(language, 1);
                    }

                    else
                    {
                        databaseCount[language]++;
                    }


                    if (!databaseWithValues.ContainsKey(username))
                    {
                        databaseWithValues.Add(username, points);
                    }


                    if (databaseWithValues[username] < points)
                    {
                        databaseWithValues[username] = points;
                    }
                }

                else
                {
                    removed.Add(username);
                    databaseWithValues.Remove(username);
                }
            }

            Console.WriteLine("Results:");

            foreach (var user in databaseWithValues.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value}");

            }

            Console.WriteLine("Submissions:");

            foreach (var item in databaseCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }

    }
}