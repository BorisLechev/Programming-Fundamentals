namespace _5.MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;

    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string firstWord = input[0];
            string secondWord = input[1];

            bool result = CheckIfReplaceble(firstWord, secondWord);
            Console.WriteLine(result.ToString().ToLower());
        }

        public static bool CheckIfReplaceble(string firstWord, string secondWord)
        {
            var first = new HashSet<char>();
            var second = new HashSet<char>();

            foreach (var item in firstWord)
            {
                first.Add(item);
            }

            foreach (var item in secondWord)
            {
                second.Add(item);
            }

            if (first.Count == second.Count)
            {
                return true;
            }

            return false;
        }
    }
}
