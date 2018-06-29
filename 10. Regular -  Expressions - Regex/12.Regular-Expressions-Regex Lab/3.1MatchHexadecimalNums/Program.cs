namespace _3._1MatchHexadecimalNums
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchHexadecimalNums
    {
        public static void Main()
        {
            string pattern = @"\b(0x)?[0-9A-F]+\b";
            string input = Console.ReadLine();

            MatchCollection matchHexNums = Regex.Matches(input, pattern);

            foreach (Match match in matchHexNums)
            {
                Console.Write(match + " ");
            }

            Console.WriteLine();
        }
    }
}
