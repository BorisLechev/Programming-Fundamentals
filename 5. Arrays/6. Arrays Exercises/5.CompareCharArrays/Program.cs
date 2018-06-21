namespace _5.CompareCharArrays
{
    using System;
    using System.Linq;

    public class CompareCharArrays
    {
        public static void Main()
        {
            char[] firstArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            if (firstArr.Length == secondArr.Length)
            {
                if (firstArr[0] > secondArr[0])
                {
                    Console.WriteLine(secondArr);
                    Console.WriteLine(firstArr);
                }

                else
                {
                    Console.WriteLine(firstArr);
                    Console.WriteLine(secondArr);
                }
            }

            else if (firstArr.Length > secondArr.Length)
            {
                Console.WriteLine(secondArr);
                Console.WriteLine(firstArr);
            }

            else if (firstArr.Length < secondArr.Length)
            {
                Console.WriteLine(firstArr);
                Console.WriteLine(secondArr);
            }
        }
    }
}
