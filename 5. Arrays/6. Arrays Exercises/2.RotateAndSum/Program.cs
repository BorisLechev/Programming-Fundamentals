namespace _2.RotateAndSum
{
    using System;
    using System.Linq;

    public class RotateAndSum
    {
        public static void Main()
        {
            int[] arrOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[arrOfNumbers.Length];

            for (int i = 0; i < k; i++)
            {
                int lastNumber = arrOfNumbers[arrOfNumbers.Length - 1];

                for (int j = arrOfNumbers.Length - 1; j > 0; j--)
                {
                    arrOfNumbers[j] = arrOfNumbers[j - 1];
                    sum[j] += arrOfNumbers[j];
                }

                arrOfNumbers[0] = lastNumber;
                sum[0] += arrOfNumbers[0];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
