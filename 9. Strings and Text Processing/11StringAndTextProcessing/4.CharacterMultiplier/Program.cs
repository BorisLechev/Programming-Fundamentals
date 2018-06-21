namespace _4.CharacterMultiplier
{
    using System;
    using System.Collections.Generic;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string first = input[0];
            string second = input[1];

            Console.WriteLine(SumOfCharacters(first, second));
        }

        public static int SumOfCharacters(string first, string second)
        {
            int result = 0;

            var firstAsInt = new List<int>();
            var secondAsInt = new List<int>();

            foreach (var item in first)
            {
                firstAsInt.Add((int)item);
            }

            foreach (var item in second)
            {
                secondAsInt.Add((int)item);
            }

            for (int i = 0; i < Math.Min(firstAsInt.Count, secondAsInt.Count); i++)
            {
                result += firstAsInt[i] * secondAsInt[i];
            }

            if (firstAsInt.Count != secondAsInt.Count)
            {
                if (firstAsInt.Count > secondAsInt.Count)
                {
                    for (int i = firstAsInt.Count - 1; i >= secondAsInt.Count; i--)
                    {
                        result += (int)firstAsInt[i];
                    }
                }

                else
                {
                    for (int i = secondAsInt.Count - 1; i >= firstAsInt.Count; i--)
                    {
                        result += (int)secondAsInt[i];
                    }
                }
            }

            return result;
        }
    }
}
