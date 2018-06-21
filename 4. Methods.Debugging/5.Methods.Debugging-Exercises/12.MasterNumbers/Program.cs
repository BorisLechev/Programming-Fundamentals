namespace _12.MasterNumbers
{
    using System;

    public class MasterNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (IsSymetric(i))
                {
                    if (EvenDigitAndDivisible(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        public static bool IsSymetric(int number)
        {
            string str = number.ToString();
            int length = number.ToString().Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool EvenDigitAndDivisible(int number)
        {
            int digit = 0;
            int sum = 0;
            bool divisible = false;
            bool evenDigit = false;
            int length = number.ToString().Length;

            for (int i = 0; i < length; i++)
            {
                digit = number % 10;

                if (digit % 2 == 0)
                {
                    evenDigit = true;
                }

                number /= 10;
                sum += digit;
            }

            if (sum % 7 == 0)
            {
                divisible = true;
            }

            if (divisible && evenDigit)
            {
                return true;
            }

            return false;
        }
    }
}
