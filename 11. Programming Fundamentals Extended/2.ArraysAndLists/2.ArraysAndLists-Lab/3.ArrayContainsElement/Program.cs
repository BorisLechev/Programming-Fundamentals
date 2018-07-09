namespace _3.ArrayContainsElement
{
    using System;
    using System.Linq;

    public class ArrayContainsElement
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int checkIfListCountainIt = int.Parse(Console.ReadLine());

            Console.WriteLine(nums.Contains(checkIfListCountainIt) ? "yes" : "no");
        }
    }
}
