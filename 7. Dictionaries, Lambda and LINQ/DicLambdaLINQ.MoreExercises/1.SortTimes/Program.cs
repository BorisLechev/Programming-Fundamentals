namespace _1.SortTimes
{
    using System;
    using System.Linq;

    public class SortTimes
    {
        public static void Main()
        {
            var hours = Console.ReadLine().Split(' ').ToList();

            hours.Sort();

            Console.WriteLine(string.Join(", ", hours));
        }
    }
}
