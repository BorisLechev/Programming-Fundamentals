namespace _7.BombNumbers
{
    using System;
    using System.Linq;

    public class BombNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int bomb = input[0];
            int power = input[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int leftIndex = Math.Max(i - power, 0);
                    int rightIndex = Math.Min(i + power, numbers.Count - 1);
                    int length = rightIndex - leftIndex + 1;

                    numbers.RemoveRange(leftIndex, length);
                    i--;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
