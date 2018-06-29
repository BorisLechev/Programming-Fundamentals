namespace _7.QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class QueryMess
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(?<field>[^?&]+)=(?<value>[^?&]+)";

            while (input != "END")
            {
                var database = new Dictionary<string, List<string>>();

                MatchCollection matchCollection = Regex.Matches(input, pattern);

                foreach (Match match in matchCollection)
                {
                    string field = match.Groups["field"]
                        .Value.Replace("%20", " ").Replace("+", " ").Trim();

                    string value = match.Groups["value"]
                        .Value.Replace("%20", " ").Replace("+", " ").Trim();

                    field = Regex.Replace(field, @"\s+", " ");
                    value = Regex.Replace(value, @"\s+", " ");

                    if (!database.ContainsKey(field))
                    {
                        database.Add(field, new List<string>());
                    }

                    database[field].Add(value);
                }

                foreach (var item in database)
                {
                    string field = item.Key;
                    var values = item.Value;

                    Console.Write($"{field}=[{string.Join(", ", values)}]");
                }

                Console.WriteLine();

                input = Console.ReadLine();
            }
        }
    }
}
