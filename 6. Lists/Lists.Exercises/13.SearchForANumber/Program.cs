namespace _13.SearchForANumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SearchForANumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            var result = new List<int>();

            var threeNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int numberToTake = threeNumbers[0];
            int numberToDelete = threeNumbers[1];
            int searchNumber = threeNumbers[2];

            for (int i = 0; i < numberToTake; i++)
            {
                result.Add(numbers[i]);
            }

            result.RemoveRange(0, numberToDelete);

            foreach (var nums in result)
            {
                if (nums == searchNumber)
                {
                    Console.WriteLine("YES!");
                    return;
                }
            }

            Console.WriteLine("NO!");
        }
    }
}
