namespace _1.MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main()
        {
            string pattern = @"\b[A-Z][a-z]+\ [A-Z][a-z]+\b";
            string names = Console.ReadLine();

            MatchCollection matchNames = Regex.Matches(names, pattern);

            foreach (var match in matchNames)
            {
                Console.Write(match + " ");
            }

            Console.WriteLine();
        }
    }
}
