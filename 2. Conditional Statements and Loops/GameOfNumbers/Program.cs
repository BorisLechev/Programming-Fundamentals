namespace GameOfNumbers
{
    using System;

    public class GameOfNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            int combinations = 0;

            for (int first = n; first <= m; first++)
            {
                for (int second = n; second <= m; second++)
                {
                    combinations++;
                    sum = first + second;

                    if (sum == magicalNumber)
                    {
                        Console.WriteLine($"Number found! {second} + {first} = {magicalNumber}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{combinations} combinations - neither equals {magicalNumber}");
        }
    }
}
