namespace _6.FoldAndSum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int k = arr.Length / 4;

            var leftSide = arr.Take(k).Reverse().ToArray();
            var rightSide = arr.Reverse().Take(k).ToArray();
            var middleSide = arr.Skip(k).Take(k * 2).ToArray();
            var firstRow = leftSide.Concat(rightSide).ToArray();
            var secondRow = middleSide;

            var sum = firstRow.Select((x, index) => x + secondRow[index]);

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
