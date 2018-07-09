namespace _3.Regexmon
{
    using System;
    using System.Text.RegularExpressions;

    public class Regexmon
    {
        public static void Main()
        {
            var didimonPattern = @"([^a-zA-Z-]+)";
            var bojomonPattern = @"([a-zA-Z]+-[a-zA-Z]+)";

            string input = Console.ReadLine();

            while (true)
            {
                var didimonMatch = Regex.Match(input, didimonPattern);

                if (!didimonMatch.Success)
                {
                    break;
                }

                Console.WriteLine(didimonMatch);

                int firstSymbolDidi = didimonMatch.Index;
                input = input.Substring(firstSymbolDidi + didimonMatch.Length);

                var bojomonMatch = Regex.Match(input, bojomonPattern);

                if (!bojomonMatch.Success)
                {
                    break;
                }

                Console.WriteLine(bojomonMatch);

                int firstSymbolBojo = bojomonMatch.Index;
                input = input.Substring(firstSymbolBojo + bojomonMatch.Length);
            }
        }
    }
}
