namespace _2.OddNumbersAtOddPositions
{
    using System;
    using System.Linq;

    public class OddNumbersAtOddPositions
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Split(new char[] { ' ' }).Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int index = i;

                if (Math.Abs(arr[i] % 2) == 1 && index % 2 == 1)
                {
                    Console.WriteLine($"Index {index} -> {arr[i]}");
                }
            }
        }
    }
}
