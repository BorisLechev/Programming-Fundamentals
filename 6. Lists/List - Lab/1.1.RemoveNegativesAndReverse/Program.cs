namespace _1._1.RemoveNegativesAndReverse
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

            var result = new List<int>();

            foreach (var item in nums)
            {
                if (item > 0)
                {
                    result.Add(item);
                }
            }

            if (result.Count() == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            result.Reverse();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
