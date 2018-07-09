namespace _7.apitalizeWords
{
    using System;
    using System.Collections.Generic;

    public class CapitalizeWords
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var sentence = input.ToLower()
                    .Split(new char[] { ' ', ',', '.', '!', '?', ':', ';',
                        '\n', '\t', '[', ']', '\\', '/', '%', '$', '#', '|',
                        '{', '}', '<', '>', '+', '-', '*', '=', '&', '^', '@', '~', '_', '"' },
                        StringSplitOptions.RemoveEmptyEntries);

                var newSentence = new List<string>();

                foreach (var item in sentence)
                {
                    string newWord = string.Empty;

                    for (int i = 0; i < item.Length; i++)
                    {
                        string currentChar = item[i].ToString();

                        if (i == 0)
                        {
                            currentChar = currentChar.ToUpper();
                        }

                        newWord += currentChar;
                    }

                    newSentence.Add(newWord);
                }

                Console.WriteLine(string.Join(", ", newSentence));

                input = Console.ReadLine();
            }
        }
    }
}
