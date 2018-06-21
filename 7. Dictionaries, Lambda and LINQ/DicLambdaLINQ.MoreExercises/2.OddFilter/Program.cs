namespace _2.OddFilter
{
    using System;
    using System.Linq;

    public class OddFilter
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            nums.RemoveAll(x => x % 2 == 1);

            double average = nums.Average();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > average)
                {
                    nums[i] += 1;
                }

                else
                {
                    nums[i] -= 1;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
