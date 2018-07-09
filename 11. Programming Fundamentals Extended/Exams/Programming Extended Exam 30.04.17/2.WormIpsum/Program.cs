namespace _2.WormIpsum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WormIpsum
    {
        public static void Main()
        {
            string input = string.Empty;
            string pattern = @"([A-Z])(.*?)([.])";   //([A-Z]{1}(.*?)\.{1})

            while ((input = Console.ReadLine()) != "Worm Ipsum")
            {
                var match = Regex.Matches(input, pattern);

                if (match.Count > 1)
                {
                    continue;
                }

                string newSentence = ProcessAndValidate(input);

                Console.WriteLine(newSentence + ".");
            }
        }

        public static string FindMostOccurendLetter(string word)
        {
            var database = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                char currentSymbol = word[i];

                if (!database.ContainsKey(currentSymbol))
                {
                    database[currentSymbol] = 0;
                }

                database[currentSymbol]++;
            }

            char returnedWord = database.OrderByDescending(x => x.Value).First().Key;
            int value = database.OrderByDescending(x => x.Value).First().Value;

            if (value >= 2)
            {
                string newWord = string.Empty;

                foreach (var symbol in word)
                {
                    if (symbol == '\'')
                    {
                        newWord += symbol;
                    }

                    else if (symbol == ',')
                    {
                        newWord += symbol;
                    }

                    else
                    {
                        newWord += returnedWord;
                    }
                }

                return newWord;
            }

            return word;
        }

        public static string ProcessAndValidate(string input)
        {
            string returnedSentence = string.Empty;
            var words = input.TrimEnd('.').Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            bool isFirst = true;

            foreach (var word in words)
            {
                string currentWord = FindMostOccurendLetter(word);

                if (isFirst)
                {
                    returnedSentence += currentWord;
                    isFirst = false;
                    continue;
                }

                returnedSentence += $" {currentWord}";
            }

            return returnedSentence;
        }
    }
}
