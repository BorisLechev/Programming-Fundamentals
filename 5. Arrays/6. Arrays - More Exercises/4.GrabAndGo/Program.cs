namespace _4.GrabAndGo
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] arrOfNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int stopNumber = int.Parse(Console.ReadLine());
            bool isStopNumberFound = false;
            int sum = 0;

            for (int i = arrOfNums.Length - 1; i >= 0; i--)
            {
                if (arrOfNums[i] == stopNumber)
                {
                    isStopNumberFound = true;
                }

                if (isStopNumberFound)
                {
                    sum += arrOfNums[i];
                }
            }

            if (isStopNumberFound)
            {
                Console.WriteLine(sum - stopNumber);
            }

            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
