namespace _9.JumpAround
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxIndex = arr.Length - 1;
            int sum = 0;
            int index = 0;

            while (true)
            {
                sum += arr[index];

                int nextIndex = index + arr[index];

                if (nextIndex <= maxIndex)
                {
                    index = nextIndex;

                    continue;
                }

                nextIndex = index - arr[index];

                if (nextIndex >= 0)
                {
                    index = nextIndex;

                    continue;
                }

                break;
            }

            Console.WriteLine(sum);
        }
    }
}
