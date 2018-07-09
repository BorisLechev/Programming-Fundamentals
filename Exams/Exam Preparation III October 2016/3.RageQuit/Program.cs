namespace _3.RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class RageQuit
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToUpper();

            string pattern = @"([a-zA-Z\W_]+)(\d+)";

            StringBuilder rageQuitMessage = new StringBuilder();

            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                string characterToBeRepeated = match.Groups[1].Value;
                int howManyTimesToBeRepeated = int.Parse(match.Groups[2].Value);

                rageQuitMessage.Append(RepeatCharacters(characterToBeRepeated, howManyTimesToBeRepeated));
            }

            int uniqueSymbols = rageQuitMessage.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine($"{rageQuitMessage}");
        }

        public static string RepeatCharacters(string characterToBeRepeated, int howManyTimesToBeRepeated)
        {
            StringBuilder container = new StringBuilder();

            for (int i = 0; i < howManyTimesToBeRepeated; i++)
            {
                container.Append(characterToBeRepeated);
            }

            return container.ToString();
        }
    }
}
