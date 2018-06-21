namespace _1.CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToList(); 

            var counts = new SortedDictionary<double, int>();

            foreach (var nums in numbers)
            {
                if (counts.ContainsKey(nums))
                {
                    counts[nums]++;
                }

                else
                {
                    counts[nums] = 1;
                }
            }

            foreach (var nums in counts.Keys)
            {
                Console.WriteLine($"{nums} -> {counts[nums]}");
            }
        }
    }
}
