namespace _8.MostFrequentNumber
{
    using System;
    using System.Linq;

    public class MostFrequentNumber
    {
        public static void Main()
        {
            int[] numbersArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxCounter = 0;
            int mostFrequentNumber = 0;

            for (int i = 0; i < numbersArr.Length; i++)
            {
                int counter = 0;

                for (int j = 0; j < numbersArr.Length; j++)
                {
                    if (numbersArr[j] == numbersArr[i])
                    {
                        counter++;
                    }
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    mostFrequentNumber = numbersArr[i];
                }
            }

            Console.WriteLine(mostFrequentNumber);
        }
    }
}
