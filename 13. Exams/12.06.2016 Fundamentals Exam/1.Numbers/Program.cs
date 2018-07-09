namespace _1.Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var average = numbers.Average();
            var numbersGreaterThanTheAverage = new List<int>();
           
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    numbersGreaterThanTheAverage.Add(numbers[i]);
                }
            }

            if (numbersGreaterThanTheAverage.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            Console.WriteLine(string.Join(" ", numbersGreaterThanTheAverage.OrderByDescending(x => x).Take(5)));
        }
    }
}
