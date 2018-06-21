namespace _6.MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            int[] numbersArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int currentStart = 0;
            int currentLength = 1;
            int maxStart = 0;
            int maxLength = 1;

            for (int i = 1; i < numbersArr.Length; i++)
            {
                if (numbersArr[i] == numbersArr[currentStart])
                {
                    currentLength++;
                }

                else
                {
                    currentStart = i;
                    currentLength = 1;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxStart = currentStart;
                }
            }

            for (int i = maxStart; i < maxLength + maxStart; i++)
            {
                Console.Write(numbersArr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
