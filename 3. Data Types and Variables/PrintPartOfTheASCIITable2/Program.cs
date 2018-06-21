namespace PrintPartOfTheASCIITable2
{
    using System;

    public class PrintPartOfTheASCIITable2
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n; i <= n2; i++)
            {
                char result = Convert.ToChar(i);
                Console.Write(result + " ");
            }

            Console.WriteLine();
        }
    }
}
