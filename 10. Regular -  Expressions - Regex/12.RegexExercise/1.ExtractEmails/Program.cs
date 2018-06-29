namespace _1.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()   //75
        {
            string pattern = @"(?<= |^)[A-Za-z0-9]+[A-Za-z0-9.-_]*@[A-Za-z]+[A-Za-z-]*\.[A-Za-z]+(\.[A-Za-z]+)*";
            var mails = Console.ReadLine();

            MatchCollection regex = Regex.Matches(mails, pattern);

            foreach (var item in regex)
            {
                Console.WriteLine(item);
            }
        }
    }
}
