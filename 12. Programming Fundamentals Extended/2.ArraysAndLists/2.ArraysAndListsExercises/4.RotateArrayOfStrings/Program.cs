namespace _4.RotateArrayOfStrings
{
    using System;
    using System.Linq;

    public class RotateArrayOfStrings
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var result = new string[arr.Length];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                result[i + 1] = arr[i];
            }

            string lastNum = arr.Last();
            result[0] = lastNum;

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
