namespace _5.KeyReplacer
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class KeyReplacer
    {
        public static void Main()
        {
            var splitKey = new Regex(@"[<\\|]+");

            var firstLineInput = splitKey.Split(Console.ReadLine());

            string startKey = firstLineInput[0];
            string endKey = firstLineInput.Last();

            var text = Console.ReadLine();

            var pattern = $@"{startKey}(.*?){endKey}";
            MatchCollection regex = Regex.Matches(text, pattern);

            string result = string.Empty;

            foreach (Match match in regex)
            {
                result += match.Groups[1];
            }

            Console.WriteLine(result.Length > 0 ? result : "Empty result");
        }
    }
}
