namespace _2.ReverseAnArrayOfIntegers
{
    using System;

    public class ReverseAnArrayOfIntegers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var arrayOfNumbers = new int[number];

            for (int i = 0; i < number; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = number - 1; i >= 0; i--)
            {
                Console.WriteLine(arrayOfNumbers[i] + " ");
            }
        }
    }
}
