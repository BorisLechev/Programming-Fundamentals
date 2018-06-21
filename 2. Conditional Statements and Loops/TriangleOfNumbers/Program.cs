namespace TriangleOfNumber
{
    using System;

    public class TriangleOfNumber
    {
        public static void Main()
        {
            byte rows = byte.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
