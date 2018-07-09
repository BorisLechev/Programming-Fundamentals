namespace _5.CountOfOddNumbersInArray
{
    using System;
    using System.Linq;

    public class CountOfOddNumbersInArray
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i] % 2) == 1)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
