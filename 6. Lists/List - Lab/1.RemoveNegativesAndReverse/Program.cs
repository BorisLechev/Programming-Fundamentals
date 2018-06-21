namespace _1.RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            var result = new List<int>(nums);

            foreach (var numbers in nums)
            {
                if (numbers < 0)
                {
                    result.Remove(numbers);
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            else
            {
                result.Reverse();
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
