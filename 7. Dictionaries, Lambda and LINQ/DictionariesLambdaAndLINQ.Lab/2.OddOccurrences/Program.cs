namespace _2.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurrences
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var counts = new Dictionary<string, int>();

            foreach (var words in input)
            {
                if (counts.ContainsKey(words))
                {
                    counts[words]++;
                }

                else
                {
                    counts[words] = 1;
                }
            }

            var result = new List<string>();

            foreach (var item in counts)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
