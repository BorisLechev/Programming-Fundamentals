namespace IntervalOfNumbers
{
    using System;

    public class IntervalOfNumbers
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int startOfInterval = Math.Min(firstNumber, secondNumber);
            int endOfInterval = Math.Max(firstNumber, secondNumber);

            for (int i = startOfInterval; i <= endOfInterval; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
