namespace _1.LargestCommonEnd
{
    using System;
    using System.Linq;

    public class LargestCommonEnd
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();

            int smallerArrayLength = Math.Min(firstArray.Length, secondArray.Length);
            int leftCounter = CheckArrays(smallerArrayLength, firstArray, secondArray);

            Array.Reverse(firstArray);
            Array.Reverse(secondArray);

            int rightCounter = CheckArrays(smallerArrayLength, firstArray, secondArray);
            Console.WriteLine(leftCounter > rightCounter ? leftCounter : rightCounter);
        }

        public static int CheckArrays(int smallerArrayLength, string[] firstArray, string[] secondArray)
        {
            int counter = 0;

            for (int i = 0; i < smallerArrayLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
