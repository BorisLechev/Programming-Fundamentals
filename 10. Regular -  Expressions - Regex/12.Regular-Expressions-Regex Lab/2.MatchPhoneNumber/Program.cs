namespace _2.MatchPhoneNumber
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class MatchPhoneNumber
    {
        public static void Main()
        {
            string pattern = @"\+359(-| )2(\1)[0-9]{3}(\1)[0-9]{4}\b";
            string phones = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phones, pattern);

            var matchedPhones = phoneMatches.Cast<Match>().Select(x => x.Value.Trim()).ToList();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
