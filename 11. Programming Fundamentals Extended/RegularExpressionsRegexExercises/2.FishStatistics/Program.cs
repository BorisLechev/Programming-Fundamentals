namespace _2.FishStatistics
{
    using System;
    using System.Text.RegularExpressions;

    public class FishStatistics
    {
        public static void Main()
        {
            string pattern = @"([>]*)<([(]+)(['\-x]{1})([>])";

            string input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);

            if (matches.Count == 0)
            {
                Console.WriteLine("No fish found.");
                return;
            }

            int count = 0;

            foreach (Match fish in matches)
            {
                count++;
                string tail = fish.Groups[1].Value;
                string body = fish.Groups[2].Value;
                string status = fish.Groups[3].Value;

                string tailType = string.Empty;
                string bodyType = string.Empty;
                string statusType = string.Empty;

                if (tail.Length == 0)
                {
                    tailType = "  Tail type: None ";
                }

                else if (tail.Length == 1)
                {
                    tailType = "  Tail type: Short (2 cm)";
                }

                else if (tail.Length > 1 && tail.Length <= 5)
                {
                    tailType = $"  Tail type: Medium ({tail.Length * 2} cm)";
                }

                else if (tail.Length > 5)
                {
                    tailType = $"  Tail type: Long ({tail.Length * 2} cm)";
                }

                if (body.Length <= 5)
                {
                    bodyType = $"  Body type: Short ({body.Length * 2} cm)";
                }

                else if (body.Length > 5 && body.Length <= 10)
                {
                    bodyType = $"  Body type: Medium ({body.Length * 2} cm)";
                }

                else if (body.Length > 10)
                {
                    bodyType = $"  Body type: Long ({body.Length * 2} cm)";
                }

                switch (status)
                {
                    case "'":
                        statusType = "  Status: Awake";
                        break;
                    case "-":
                        statusType = "  Status: Asleep";
                        break;
                    case "x":
                        statusType = "  Status: Dead";
                        break;
                }

                Console.WriteLine($"Fish {count}: {fish.Value}");
                Console.WriteLine(tailType);
                Console.WriteLine(bodyType);
                Console.WriteLine(statusType);
            }
        }
    }
}
