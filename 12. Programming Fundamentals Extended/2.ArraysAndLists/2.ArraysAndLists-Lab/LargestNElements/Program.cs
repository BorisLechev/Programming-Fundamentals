namespace LargestNElements
{
    using System;
    using System.Linq;

    public class LargestNElements
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            nums.Sort();

            nums.Reverse();

            for (int i = 0; i < n; i++)
            {
                Console.Write(nums[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
