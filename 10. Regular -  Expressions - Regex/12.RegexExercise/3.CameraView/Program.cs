namespace _3.CameraView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class CameraView
    {
        public static void Main()
        {
            var inputIndexes = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int skipElements = inputIndexes[0];
            int takeElements = inputIndexes[1];

            var input = Console.ReadLine();

            string pattern = @"\|<(\w{" + skipElements + "})(\\w{0," + takeElements + "})";

            MatchCollection regex = Regex.Matches(input, pattern);

            var result = new List<string>();

            foreach (Match item in regex)
            {
                result.Add(item.Groups[2].Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
