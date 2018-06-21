namespace _4.SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByWordCasing
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new char[] {',', ';', ':', '.', '!', '(',
            ')', '"', '\'', '\\', '/', '[', ']', ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

            var lowerCaseWords = new List<string>();
            var upperCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();

            foreach (var words in text)
            {
                bool isLowerCase = true;
                bool isUpperCase = true;

                for (int i = 0; i < words.Length; i++)
                {
                    if (char.IsLower(words[i]))
                    {
                        isUpperCase = false;
                    }

                    else if (char.IsUpper(words[i]))
                    {
                        isLowerCase = false;
                    }

                    else
                    {
                        isLowerCase = false;
                        isUpperCase = false;
                    }
                }

                if (isLowerCase)
                {
                    lowerCaseWords.Add(words);
                }

                else if (isUpperCase)
                {
                    upperCaseWords.Add(words);
                }

                else
                {
                    mixedCaseWords.Add(words);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
        }
    }
}
