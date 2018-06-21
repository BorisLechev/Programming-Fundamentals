namespace Debit_Card_Number
{
    using System;

    public class Debit_Card_Number
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            Console.Write($"{num1:d4} {num2:d4} {num3:d4} {num4:d4}");
            Console.WriteLine();
        }
    }
}
