namespace Fast_Prime_Checker___Refactor
{
    using System;

    public class Fast_Prime_Checker___Refactor
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                bool check = true;

                for (int start = 2; start <= Math.Sqrt(i); start++)
                {
                    if (i % start == 0)
                    {
                        check = false; break;
                    }
                }

                Console.WriteLine($"{i} -> {check}");
            }
        }
    }
}
