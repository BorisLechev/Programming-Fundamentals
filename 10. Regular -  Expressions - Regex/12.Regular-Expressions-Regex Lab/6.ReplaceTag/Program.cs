namespace _6.ReplaceTag
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ReplaceTag
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var database = new List<string>();

            while (input != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*)<\/a>";
                string replacement = @"[URL href=$1]$2[/URL]";

                string replaced = Regex.Replace(input, pattern, replacement);

                database.Add(replaced);
                input = Console.ReadLine();
            }

            foreach (string tag in database)
            {
                Console.WriteLine(tag);
            }

        }
    }
}
