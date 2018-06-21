namespace _6.SumBigNumbers
{
    using System;
    using System.Text;

    public class SumBigNumbers
    {
        public static void Main()
        {
            string first = Console.ReadLine().TrimStart('0');
            string second = Console.ReadLine().TrimStart('0');

            int length = Math.Max(first.Length, second.Length);

            StringBuilder result = new StringBuilder(length + 1);

            first = first.PadLeft(length, '0');
            second = second.PadLeft(length, '0');

            int reminder = 0;

            for (int i = length - 1; i >= 0; i--)
            {
                int firstNumber = int.Parse(first[i].ToString());
                int secondNumber = int.Parse(second[i].ToString());

                int sum = firstNumber + secondNumber + reminder;

                int lastDigit = sum % 10;

                result.Append(lastDigit);

                reminder = sum / 10;
            }

            if (reminder > 0)
            {
                result.Append(reminder);
            }

            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }

            Console.WriteLine();
        }
    }
}
