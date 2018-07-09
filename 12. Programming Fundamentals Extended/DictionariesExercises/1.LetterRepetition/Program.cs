namespace _1.LetterRepetition
{
    using System;
    using System.Collections.Generic;

    public class LetterRepetition
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var counter = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (!counter.ContainsKey(letter))
                {
                    counter[letter] = 1;
                }

                else
                {
                    counter[letter]++;
                }
            }

            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
