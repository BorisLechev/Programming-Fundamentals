namespace _1.ArrayStatistics
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arrOfNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine($"Min = {arrOfNums.Min()}");
            Console.WriteLine($"Max = {arrOfNums.Max()}");
            Console.WriteLine($"Sum = {arrOfNums.Sum()}");
            Console.WriteLine($"Average = {arrOfNums.Average()}");
        }
    }
}
