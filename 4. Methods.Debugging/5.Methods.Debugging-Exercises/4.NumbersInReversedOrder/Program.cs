namespace _4.NumbersInReversedOrder
{
    using System;

    public class NumbersInReversedOrder
    {
        public static void Main()
        {
            string number = Console.ReadLine();

            Console.WriteLine(Reverst(number));
        }

        public static string Reverst(string number)
        {
            string result = string.Empty;
            int counter = number.Length - 1;

            for (int i = counter; i >= 0; i--)
            {
                result += number[i];
            }

            return result;
        }
    }
}
