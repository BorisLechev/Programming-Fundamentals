namespace _8.LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LogsAggregator
    {
        public static void Main()
        {
            var database = new SortedDictionary<string, SortedDictionary<string, int>>();
            int logs = int.Parse(Console.ReadLine());

            for (int i = 0; i < logs; i++)
            {
                var userData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var ipAddress = userData[0];
                var username = userData[1];
                int duration = int.Parse(userData[2]);

                if (!database.ContainsKey(username))
                {
                    database[username] = new SortedDictionary<string, int>();
                }

                if (!database[username].ContainsKey(ipAddress))
                {
                    database[username][ipAddress] = 0;
                }

                database[username][ipAddress] += duration;
            }

            foreach (var currentUser in database)
            {
                Console.WriteLine($"{currentUser.Key}: {currentUser.Value.Values.Sum()} [{string.Join(", ", currentUser.Value.Keys)}]");
            }
        }
    }
}
