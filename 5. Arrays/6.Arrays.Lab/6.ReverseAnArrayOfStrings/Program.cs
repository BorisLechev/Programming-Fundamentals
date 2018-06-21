namespace _6.ReverseAnArrayOfStrings
{
    using System;
    using System.Linq;

    public class ReverseAnArrayOfStrings
    {
        public static void Main()
        {
            string[] arrOfStrings = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            Console.WriteLine(string.Join(" ", arrOfStrings.Reverse()));
        }
    }
}
