namespace _2.ExtractSentencesByKeyword
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ExtractSentencesByKeywordm
    {
        public static void Main()
        {
            string word = Console.ReadLine();

            var text = Console.ReadLine()
                .Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string pattern = $@"\b({word})\b";

            foreach (var sentences in text)
            {
                Match regex = Regex.Match(sentences, pattern);

                if (regex.Success)
                {
                    Console.WriteLine(sentences.Trim());
                }
            }
        }
    }
}
