namespace _6.ValidUsernames
{
    using System;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            string pattern = @"\b[a-zA-Z][a-zA-Z\d_]{2,24}\b";

            MatchCollection regex = Regex.Matches(input, pattern);

            int sum = 0;
            int biggestSum = 0;
            string firstUser = string.Empty;
            string secondUser = string.Empty;

            for (int i = 0; i < regex.Count - 1; i++)
            {
                sum = regex[i].Length + regex[i + 1].Length;

                if (sum > biggestSum)
                {
                    biggestSum = sum;
                    firstUser = regex[i].ToString();
                    secondUser = regex[i + 1].ToString();
                }
            }

            Console.WriteLine(firstUser);
            Console.WriteLine(secondUser);
        }
    }
}
