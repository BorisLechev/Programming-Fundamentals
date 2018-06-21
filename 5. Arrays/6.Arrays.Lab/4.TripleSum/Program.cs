namespace _4.TripleSum
{
    using System;
    using System.Linq;

    public class TripleSum
    {
        public static void Main()
        {
            var arrOfNumbers = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool isTriple = false;

            for (int index = 0; index < arrOfNumbers.Length; index++)
            {
                int a = arrOfNumbers[index];

                for (int index2 = index + 1; index2 < arrOfNumbers.Length; index2++)
                {
                    int b = arrOfNumbers[index2];
                    int sumOfTwoNumbers = a + b;

                    if (arrOfNumbers.Contains(sumOfTwoNumbers))
                    {
                        Console.WriteLine($"{a} + {b} = {sumOfTwoNumbers}");
                        isTriple = true;
                    }
                }
            }

            if (isTriple == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
