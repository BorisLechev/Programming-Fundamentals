namespace _5.UserLogins
{
    using System;
    using System.Collections.Generic;

    public class UserLogins
    {
        public static void Main()
        {
            var database = new Dictionary<string, string>();
            var input = Console.ReadLine().
                Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "login")
            {
                var username = input[0];
                var password = input[1];

                if (!database.ContainsKey(username))
                {
                    database[username] = password;
                }

                database[username] = password;

                input = Console.ReadLine().
                Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            input = Console.ReadLine().
                Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            int unsuccessfulLogins = 0;

            while (input[0] != "end")
            {
                var username = input[0];
                var password = input[1];

                if (database.ContainsKey(username) && database.ContainsValue(password))
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }

                else
                {
                    Console.WriteLine($"{username}: login failed");
                    unsuccessfulLogins++;
                }

                input = Console.ReadLine().
                Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            if (unsuccessfulLogins > 0)
            {
                Console.WriteLine($"unsuccessful login attempts: {unsuccessfulLogins}");
            }
        }
    }
}
