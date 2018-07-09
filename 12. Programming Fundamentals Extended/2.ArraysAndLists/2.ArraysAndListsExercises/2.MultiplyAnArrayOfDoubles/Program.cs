namespace _2.MultiplyAnArrayOfDoubles
{
    using System;
    using System.Linq;

    public class MultiplyAnArrayOfDoubles
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            double multiply = double.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= multiply;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
