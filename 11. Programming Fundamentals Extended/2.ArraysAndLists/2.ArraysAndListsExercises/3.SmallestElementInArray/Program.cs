namespace _3.SmallestElementInArray
{
    using System;
    using System.Linq;

    public class SmallestElementInArray
    {
        public static void Main()
        {
            var numsArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Console.WriteLine(numsArr.Min());
        }
    }
}
