namespace _5.RoundingNumbersAwayFromZero
{
    using System;
    using System.Linq;

    public class RoundingNumbersAwayFromZero
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var roundedNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{nums[i]} => {roundedNums[i]}");
            }
        }
    }
}
