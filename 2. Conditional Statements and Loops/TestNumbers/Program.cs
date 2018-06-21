namespace TestNumbers
{
    using System;

    public class TestNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSumBoundary = int.Parse(Console.ReadLine());

            int combinations = 0;
            int sum = 0;

            for (int first = n; first >= 1; first--)
            {
                for (int second = 1; second <= m; second++)
                {
                    sum += 3 * (first * second);

                    combinations++;

                    if (sum >= maxSumBoundary)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSumBoundary}");
                        return;
                    }
                }
            }

            if (sum < maxSumBoundary)
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
