namespace _4._1.Winning_Ticket
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Winning_Ticket
    {
        public static void Main()
        {
            StringBuilder result = new StringBuilder();

            var tickets = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string winningSymbolsPattern = @"(\@{6,}|\#{6,}|\${6,}|\^{6,})";
            var winningSymbolsRegex = new Regex(winningSymbolsPattern);

            foreach (var ticket in tickets)
            {
                if (ticket.Count() != 20)
                {
                    result.Append($"invalid ticket{Environment.NewLine}");
                    continue;
                }

                var leftMatch = winningSymbolsRegex.Match(ticket.Substring(0, 10));
                var rightMatch = winningSymbolsRegex.Match(ticket.Substring(10));
                int minLength = Math.Min(leftMatch.Length, rightMatch.Length);

                if (!leftMatch.Success || !rightMatch.Success)
                {
                    result.Append($"ticket \"{ticket}\" - no match{Environment.NewLine}");
                    continue;
                }

                string leftPart = leftMatch.Value.Substring(0, minLength);
                string rightPart = rightMatch.Value.Substring(0, minLength);

                if (leftPart.Equals(rightPart))
                {
                    if (leftPart.Length == 10)
                    {
                        result.Append($"ticket \"{ ticket}\" - {minLength}" +
                            $"{leftPart.Substring(0, 1)} Jackpot!{Environment.NewLine}");
                    }

                    else
                    {
                        result.Append($"ticket \"{ ticket}\" - {minLength}" +
                            $"{leftPart.Substring(0, 1)}{Environment.NewLine}"); // or leftPart[0]
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
