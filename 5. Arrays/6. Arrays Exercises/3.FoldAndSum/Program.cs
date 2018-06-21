namespace _3.FoldAndSum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            int[] arrOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arrOfNumbers.Length / 4;

            int[] leftArr = arrOfNumbers.Take(k).ToArray();
            int[] middleArr = arrOfNumbers.Skip(k).Take(k * 2).ToArray();
            int[] rightArr = arrOfNumbers.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(leftArr);
            Array.Reverse(rightArr);

            int[] result = leftArr.Concat(rightArr).ToArray();

            for (int i = 0; i < k * 2; i++)
            {
                result[i] = middleArr[i] + result[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
