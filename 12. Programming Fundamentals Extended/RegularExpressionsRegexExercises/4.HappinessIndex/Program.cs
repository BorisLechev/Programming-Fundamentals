namespace _4.HappinessIndex
{
    using System;
    using System.Text.RegularExpressions;

    public class HappinessIndex
    {
        public static void Main()
        {
            string happyPattern = @":\)|:D|;\)|:\*|:]|;]|;}|;}|\(:|\*:|c:|\[:|\[;";
            string sadPattern = @":\(|D:|;\(|:\[|;\[|:{|;{|\):|:c|]:|];";

            string input = Console.ReadLine();

            var happyEmoticons = Regex.Matches(input, happyPattern);
            var sadEmoticons = Regex.Matches(input, sadPattern);

            double happyCount = happyEmoticons.Count;
            double sadCount = sadEmoticons.Count;
            double happyIndex = happyCount / sadCount;

            string emoticonScore = EmoticonScore(happyIndex);

            PrintResult(happyCount, sadCount, happyIndex, emoticonScore);
        }

        public static string EmoticonScore(double happyIndex)
        {
            string emoticonScore = string.Empty;

            if (happyIndex >= 2)
            {
                emoticonScore = ":D";
            }

            else if (happyIndex > 1)
            {
                emoticonScore = ":)";
            }

            else if (happyIndex == 1)
            {
                emoticonScore = ":|";
            }

            else if (happyIndex < 1)
            {
                emoticonScore = ":(";
            }

            return emoticonScore;
        }

        public static void PrintResult(double happyCount, double sadCount, double happyIndex, string emoticonScore)
        {
            Console.WriteLine($"Happiness index: {happyIndex:f2} {emoticonScore}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
        }
    }
}
