namespace _1.SumArrayElements
{
    using System;
    using System.Linq;

    public class SumArrayElements
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(arr.Sum());
        }
    }
}
