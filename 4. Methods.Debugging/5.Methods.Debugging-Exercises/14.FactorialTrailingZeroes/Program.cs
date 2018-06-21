namespace _14.FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    public class FactorialTrailingZeroes
    {
        public static void Main()
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger factorial = FactorialValue(number);

            Console.WriteLine(GetTrailingZeroes(factorial));
        }

        public static BigInteger FactorialValue(BigInteger number)
        {
            BigInteger factorial = 1;

            do
            {
                factorial = factorial * number;
                number--;
            } while (number > 1);

            return factorial;
        }

        public static BigInteger GetTrailingZeroes(BigInteger number)
        {
            int timesZero = 0;

            while (number % 10 == 0)
            {
                number = number / 10;
                timesZero++;
            }

            return timesZero;
        }
    }
}
