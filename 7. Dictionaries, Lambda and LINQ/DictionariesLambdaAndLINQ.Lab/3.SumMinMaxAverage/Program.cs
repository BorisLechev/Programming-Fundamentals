namespace _3.SumMinMaxAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumMinMaxAverage
    {
        public static void Main()
        {
            int numbersToEnter = int.Parse(Console.ReadLine());
            var nums = new List<int>(numbersToEnter);

            for (int i = 0; i < numbersToEnter; i++)
            {
                nums.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"Sum = {nums.Sum()}");
            Console.WriteLine($"Min = {nums.Min()}");
            Console.WriteLine($"Max = {nums.Max()}");
            Console.WriteLine($"Average = {nums.Average()}");
        }
    }
}
