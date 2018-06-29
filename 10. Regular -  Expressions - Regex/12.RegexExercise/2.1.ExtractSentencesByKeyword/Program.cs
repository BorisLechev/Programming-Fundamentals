namespace _2._1.ExtractSentencesByKeyword
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            string pattern = $@"\b[^!.?]+\b({word})\b[^!.?]+";
            var regex = new Regex(pattern);
            var match = regex.Matches(text);

            foreach (Match item in match)
            {
                Console.WriteLine(item);
            }
        }
    }
}
