namespace _2.MaxMethod
{
    using System;

    public class MaxMethod
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = GetMax(a, b);
            max = GetMax(max, c);

            Console.WriteLine(max);
        }

        public static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            else
            {
                return b;
            }
        }
    }
}
