namespace _1.Cards
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Cards
    {
        public static void Main()
        {
            string pattern = @"([1]?[0-9JQKA])([SHDC])";
            string input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);

            var matchList = AddToList(matches);

            Console.WriteLine(string.Join(", ", matchList));
        }

        public static List<Match> AddToList(MatchCollection matches)
        {
            var matchList = new List<Match>();

            foreach (Match item in matches)
            {
                int power = 0;

                if (int.TryParse(item.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }

                matchList.Add(item);
            }

            return matchList;
        }
    }
}
