namespace _1.ConvertFromBase10ToBaseN
{
    using System;
    using System.Numerics;

    public class ConvertFromBase10ToBaseN
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            BigInteger baseN = BigInteger.Parse(input[0]);
            BigInteger baseTen = BigInteger.Parse(input[1]);

            var result = ConvertToBaseN(baseN, baseTen);

            Console.WriteLine(result);
        }

        public static string ConvertToBaseN(BigInteger baseN, BigInteger baseTen)
        {
            string result = string.Empty;

            while (baseTen > 0)
            {
                var reminder = baseTen % baseN;
                result = reminder + result;
                baseTen /= baseN;
            }

            return result;
        }
    }
}
