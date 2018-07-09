namespace _1.RotateArrayOfStrings
{
    using System;
    using System.Linq;

    public class RotateArrayOfStrings
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var arr2 = new string[arr.Length];

            arr2[0] = arr[arr.Length - 1];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr2[i + 1] = arr[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
