namespace _2.KaminoFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KaminoFactory                   
    {
        public static void Main()
        {
            int lengthOfTheSequence = int.Parse(Console.ReadLine());

            string input = string.Empty;

            int biggestLength = -1;
            int leftIndex = 0;
            int sampleIndex = 0;
            var bestDna = new List<int>();
            int biggestSampleIndex = 0;
            int biggestSum = 0;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                var currentInput = input
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                int currentLength = 0;
                int currentMaxLength = 0;
                int biggestStartIndex = 0;

                int currentSum = currentInput.Sum();

                for (int i = 0; i < currentInput.Count; i++)
                {
                    if (currentInput[i] == 1)
                    {
                        currentLength++;

                        if (currentLength > currentMaxLength)
                        {
                            currentMaxLength = currentLength;
                            biggestStartIndex = i - currentLength + 1;
                        }
                    }

                    else
                    {
                        currentLength = 0;
                    }
                }

                bool isCurrentBiggest = false;

                if (currentMaxLength > biggestLength)
                {
                    isCurrentBiggest = true;
                }

                else if (currentMaxLength == biggestLength)
                {
                    if (biggestStartIndex < leftIndex)
                    {
                        isCurrentBiggest = true;
                    }

                    else if (biggestStartIndex == leftIndex)
                    {
                        if (currentSum > biggestSum)
                        {
                            isCurrentBiggest = true;
                        }
                    }
                }

                sampleIndex++;

                if (isCurrentBiggest)
                {
                    bestDna = currentInput;
                    biggestLength = currentMaxLength;
                    leftIndex = biggestStartIndex;
                    biggestSampleIndex = sampleIndex;
                    biggestSum = currentSum;
                }
            }

            Console.WriteLine($"Best DNA sample {biggestSampleIndex} with sum: {biggestSum}.");
            Console.WriteLine($"{string.Join(" ", bestDna)}");
        }
    }
}
