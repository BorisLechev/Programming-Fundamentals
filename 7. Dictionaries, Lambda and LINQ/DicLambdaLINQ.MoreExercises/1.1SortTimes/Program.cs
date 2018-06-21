namespace _1._1SortTimes
{
    using System;
    using System.Linq;

    public class SortTimes
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(", ", Console.ReadLine().Split().OrderBy(x => x).ToList()));
        }
    }
}
