namespace _6.UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogs
    {
        public static void Main()
        {
            var userLogs = new SortedDictionary<string, Dictionary<string, int>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                var inputArg = input.Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string ip = inputArg[1];
                string user = inputArg[5];
                int counter = 1;

                if (!userLogs.ContainsKey(user))
                {
                    userLogs.Add(user, new Dictionary<string, int>());
                }

                if (!userLogs[user].ContainsKey(ip))
                {
                    userLogs[user].Add(ip, counter);
                }

                else
                {
                    userLogs[user][ip]++;
                }
            }

            foreach (var user in userLogs)
            {
                Console.WriteLine($"{user.Key}: ");

                foreach (var log in user.Value)
                {
                    if (log.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{log.Key} => {log.Value}, ");
                    }

                    else
                    {
                        Console.WriteLine($"{log.Key} => {log.Value}.");
                    }
                }
            }
        }
    }
}
