namespace _4._1.FixEmails
{
    using System;
    using System.Collections.Generic;

    public class FixEmails
    {
        public static void Main()
        {
            var database = new Dictionary<string, string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "stop")
            {
                string person = input;
                string mail = Console.ReadLine();

                if (!mail.Contains(".us") && !mail.Contains(".uk"))
                {
                    if (!database.ContainsKey(person))
                    {
                        database.Add(person, mail);
                    }

                    database[person] = mail;
                }
            }

            foreach (var data in database)
            {
                Console.WriteLine($"{data.Key} -> {data.Value}");
            }
        }
    }
}
