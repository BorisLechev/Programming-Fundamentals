namespace _11.EqualSums
{
    using System;
    using System.Linq;

    public class EqualSums
    {
        public static void Main()
        {
            int[] numbersArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool foundEqualSums = false;

            for (int i = 0; i < numbersArr.Length; i++)
            {
                int[] leftSide = numbersArr.Take(i).ToArray();
                int[] rightSide = numbersArr.Skip(i + 1).ToArray();
                                                                    
                if (leftSide.Sum() == rightSide.Sum())
                {
                    Console.WriteLine(i);
                    foundEqualSums = true;

                    break;
                }
            }

            if (!foundEqualSums)
            {
                Console.WriteLine("no");
            }
        }
    }
}
