namespace _4._1.MatchDates
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchDates
    {
        public static void Main()
        {
            string pattern = @"\b(?<day>\d{2})([-.\/])([A-Z]{1}[a-z]{2})\1(\d{4})\b";
            var datesAsString = Console.ReadLine();

            var matchTheDates = Regex.Matches(datesAsString, pattern);

            foreach (Match date in matchTheDates)
            {
                var day = date.Groups["day"].Value; //named captured "day"
                var month = date.Groups[2].Value; //second captured group "()" "\1" for separators
                var year = date.Groups[3].Value; // third captured group "()"

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
