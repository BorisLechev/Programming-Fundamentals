namespace _3.WordEncounter
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class WordEncounter
    {
        public static void Main()
        {
            string pattern = @"\w+";
            var validWords = new List<string>();

            string input = Console.ReadLine();

            char letter = input[0];
            int letterCount = int.Parse(input[1].ToString());

            string sentences = Console.ReadLine();

            while (sentences != "end")
            {
                string sentencePattern = @"^[A-Z].*[.!?]$";

                var validSentence = new Regex(sentencePattern);

                if (validSentence.IsMatch(sentences))
                {
                    MatchCollection matches = Regex.Matches(sentences, pattern);

                    foreach (Match match in matches)
                    {
                        int counter = 0;

                        foreach (var item in match.Value)
                        {
                            if (item == letter)
                            {
                                counter++;
                            }
                        }

                        if (counter >= letterCount)
                        {
                            validWords.Add(match.Value);
                        }
                    }
                }

                sentences = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", validWords));
        }
    }
}
