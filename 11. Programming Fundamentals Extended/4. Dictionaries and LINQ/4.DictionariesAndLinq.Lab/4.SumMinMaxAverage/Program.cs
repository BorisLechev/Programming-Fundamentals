namespace _4.SumMinMaxAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumMinMaxAverage
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var num = new List<int>(n);

            for (int i = 0; i < n; i++)
            {
                num.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"Sum = {num.Sum()}");
            Console.WriteLine($"Min = {num.Min()}");
            Console.WriteLine($"Max = {num.Max()}");
            Console.WriteLine($"Average = {num.Average()}");
        }
    }
}
