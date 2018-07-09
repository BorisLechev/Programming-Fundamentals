namespace _4.SortNumbers
{
    using System;
    using System.Linq;

    public class SortNumbers
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse).ToList();

            nums.Sort();

            Console.WriteLine(string.Join(" <= ", nums));
        }
    }
}
