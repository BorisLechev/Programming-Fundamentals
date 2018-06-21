namespace _6.ByteFlip
{
    using System;
    using System.Linq;

    public class ByteFlip
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length == 2).Reverse().ToList();

            for (int i = 0; i < input.Count; i++)
            {
                var charList = input[i].ToCharArray();
                Array.Reverse(charList);
                Console.Write(System.Convert.ToChar(System.Convert.ToUInt32(new string(charList), 16)));
            }

            Console.WriteLine();
        }
    }
}
