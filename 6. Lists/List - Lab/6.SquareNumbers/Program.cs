namespace _6.SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }).Select(int.Parse).ToList();
           
            var sqrtNumbers = new List<int>();

            foreach (var num in numbers)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    sqrtNumbers.Add(num);
                }
            }

            sqrtNumbers.Sort();
            sqrtNumbers.Reverse();

            Console.WriteLine(string.Join(" ", sqrtNumbers));
        }
    }
}
