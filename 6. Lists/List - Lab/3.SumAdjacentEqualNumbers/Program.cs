namespace _3.SumAdjacentEqualNumbers
{
    using System;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse).ToList();

            bool hasSum = true;

            while (hasSum)
            {
                hasSum = false;
                decimal sum = 0;
                int index = 0;

                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] == numbers[i - 1])
                    {
                        index = i - 1;
                        sum = numbers[i] + numbers[i - 1];
                        hasSum = true;

                        break;
                    }
                }

                if (hasSum)
                {
                    numbers.RemoveRange(index, 2);
                    numbers.Insert(index, sum);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
