namespace _3.Snowflake
{
    using System;
    using System.Text.RegularExpressions;

    public class Snowflake
    {
        public static void Main()
        {
            int coreLength = 0;

            for (int i = 1; i <= 5; i++)
            {
                string input = Console.ReadLine();

                if (!IsElementValid(input, i))
                {
                    Console.WriteLine("Invalid");
                    return;
                }

                if (i == 3)
                {
                    coreLength = GetCoreLength(input);
                }
            }

            Console.WriteLine("Valid");
            Console.WriteLine(coreLength);
        }

        public static bool IsElementValid(string element, int index)
        {
            switch (index)
            {
                case 1:
                case 5:
                    string surfacePattern = @"^([^a-zA-Z\d]+)$";
                    return Regex.IsMatch(element, surfacePattern);

                case 2:
                case 4:
                    string mantlePattern = @"^([\d_]+)$";
                    return Regex.IsMatch(element, mantlePattern);

                default:
                    string corePattern = @"^([^a-zA-Z\d]+)([\d_]+)([a-zA-Z]+)([\d_]+)([^a-zA-Z\d]+)$";
                    return Regex.IsMatch(element, corePattern);
            }
        }

        public static int GetCoreLength(string element)
        {
            string corePattern = @"^([^a-zA-Z\d]+)([\d_]+)([a-zA-Z]+)([\d_]+)([^a-zA-Z\d]+)$";

            var match = Regex.Match(element, corePattern);

            string core = match.Groups[3].Value;

            return core.Length;
        }
    }
}
