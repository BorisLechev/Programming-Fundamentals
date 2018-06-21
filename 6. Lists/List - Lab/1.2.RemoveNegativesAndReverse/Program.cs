namespace _1._2.RemoveNegativesAndReverse
{
    using System;
    using System.Linq;

    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            input.Reverse();

            Console.WriteLine(input.All(x => x < 0) ? "empty" : string.Join(" ", input.Where(x => x > 0)));
        }
    }
}
