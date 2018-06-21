namespace _7.SumArrays
{
    using System;
    using System.Linq;

    public class SumArrays
    {
        public static void Main()
        {
            var firstArray = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var secondArray = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var sumOfArrays = new int[Math.Max(firstArray.Length, secondArray.Length)];

            for (int i = 0; i < sumOfArrays.Length; i++)
            {
                sumOfArrays[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
            }

            Console.WriteLine(string.Join(" ", sumOfArrays));
        }
    }
}
