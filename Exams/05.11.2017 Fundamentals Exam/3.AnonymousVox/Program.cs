namespace _3.AnonymousVox
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class AnonymousVox
    {
        public static void Main()
        {
            string encodedText = Console.ReadLine();

            var placeholder = Console.ReadLine().Split(new char[] { '{', '}' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            string pattern = @"([a-zA-Z]+)(.*)(\1)";  //([A-Za-z]+)(.+)(\1)

            var matches = Regex.Matches(encodedText, pattern);

            //We'll need to follow the placeholders with some index
            int placeholderIndex = 0;

            foreach (Match match in matches)
            {
                //If the placeholders are more than the values, then we break.
                if (placeholderIndex > placeholder.Count)
                {
                    break;
                }

                //If not, we REPLACE FIRST, wait ... Why first. Because we need to replace ONLY ONE PLACEHOLDER WITH ONE VALUE.
                encodedText = ReplaceFirst(encodedText, match.Groups[2].Value, placeholder[placeholderIndex++]);
            }

            Console.WriteLine(encodedText);
        }

        //A method for replacing first, works like string.Replace.. But only replaces the first result.
        public static string ReplaceFirst(string encodedText, string oldValue, string newValue)
        {
            string substringWithOldValue = encodedText.Substring(0, encodedText.IndexOf(oldValue) + oldValue.Length);

            string substringWithNewValue = substringWithOldValue.Replace(oldValue, newValue);

            return substringWithNewValue + encodedText.Substring(substringWithOldValue.Length);
        }
    }
}
