namespace _3.Raincast
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Raincast
    {
        public static void Main()
        {
            string input = string.Empty;

            string typePattern = @"^Type: (Normal|Warning|Danger)$";
            string sourcePattern = @"^Source: (\w+)$";
            string forecastPattern = @"^Forecast: ([^!\,\.\?]+)$";

            var rainCast = new List<string>();
            string currentLine = "type";
            string currentRainCast = string.Empty;

            while ((input = Console.ReadLine()) != "Davai Emo")
            {
                switch (currentLine)
                {
                    case "type":

                        if (Regex.IsMatch(input, typePattern))
                        {
                            currentRainCast = $"({Regex.Match(input, typePattern).Groups[1].Value})";

                            currentLine = "source";
                        }
                        break;

                    case "source":

                        if (Regex.IsMatch(input, sourcePattern))
                        {
                            currentRainCast += " " + "***" + " ~ " +
                                $"{Regex.Match(input, sourcePattern).Groups[1].Value}";

                            currentLine = "forecast";
                        }
                        break;

                    case "forecast":

                        if (Regex.IsMatch(input, forecastPattern))
                        {
                            currentRainCast = 
                                currentRainCast.Replace("***", Regex.Match(input, forecastPattern).Groups[1].Value);

                            rainCast.Add(currentRainCast);
                            currentLine = "type";
                        }
                        break;
                }
            }

            foreach (var item in rainCast)
            {
                Console.WriteLine(item);
            }
        }
    }
}
