namespace _3.FirstAlbum                       
{
    using System;
    using System.Text.RegularExpressions;

    public class FirstAlbum
    {
        public static void Main()
        {
            string input = string.Empty;

            string namePattern = @"\[([^\s\-][a-zA-Z-\s]+[^\s\-])\]";
            string lyricsPattern = @"\""([a-zA-Z\s]+)\""";
            string lengthPattern = @"(\d+:\d+)m|(\d+)s";

            int validSongs = 0;

            while ((input = Console.ReadLine()) != "Rock on!" && validSongs < 4)
            {
                var nameMatch = Regex.Match(input, namePattern);
                var lyricsMatch = Regex.Match(input, lyricsPattern);
                var lengthMatch = Regex.Match(input, lengthPattern);

                if (nameMatch.Success && lyricsMatch.Success && lengthMatch.Success)
                {
                    string name = nameMatch.Groups[1].Value;
                    string lyrics = lyricsMatch.Groups[1].Value;
                    string length = lengthMatch.Value;

                    string output = string.Empty;

                    if (length.Contains("m"))
                    {
                        length = length.Remove(length.Length - 1);
                        output = $"{name} -> {length} => {lyrics}";

                        Console.WriteLine(output);
                        validSongs++;
                    }

                    else
                    {
                        length = length.Remove(length.Length - 1);
                        int totalSeconds = int.Parse(length);

                        var time = TimeSpan.FromSeconds(totalSeconds);

                        output = $"{name} -> {time.Minutes:d2}:{time.Seconds:d2} => {lyrics}";

                        Console.WriteLine(output);
                        validSongs++;
                    }
                }
            }
        }
    }
}
