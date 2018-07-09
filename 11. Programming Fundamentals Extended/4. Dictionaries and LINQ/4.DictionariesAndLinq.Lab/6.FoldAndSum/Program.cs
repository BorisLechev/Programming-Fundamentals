namespace _6.FoldAndSum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int k = numbers.Count / 4;

            var leftPart = numbers.Take(k).Reverse().ToList();
            var middlePart = numbers.Skip(k).Take(k * 2).ToList();
            var rightPart = numbers.Skip(k * 3).Take(k).Reverse().ToList();

            var rightLeft = leftPart.Concat(rightPart);
            var sum = rightLeft.Select((x, index) => x + middlePart[index]);

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
