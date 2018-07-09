namespace _3.Trainegram
{
    using System;
    using System.Text.RegularExpressions;

    public class Trainegram
    {
        public static void Main()
        {
            string input = string.Empty;
            string pattern = @"^(\<\[[^a-zA-Z\d]*\]\.{1})(\.{1}\[[a-zA-Z\d]*\]\.{1})*$"; //* -> {0,}

            while ((input = Console.ReadLine()) != "Traincode!")
            {
                var train = Regex.Match(input, pattern);

                if (train.Success)
                {
                    Console.WriteLine(input);
                }
            }
        }
    }
}
