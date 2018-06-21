namespace WordInPlural
{
    using System;

    public class WordInPlural
    {
        public static void Main()
        {
            string noun = Console.ReadLine();

            if (noun[noun.Length - 1] == 'y')
            {
                noun = noun.Remove(noun.Length - 1, 1);
                noun += "ies";
            }

            else if (noun[noun.Length - 1] == 'o' || noun[noun.Length - 1] == 'h' ||
                noun[noun.Length - 1] == 's' || noun[noun.Length - 1] == 'x' ||
                noun[noun.Length - 1] == 'z')
            {
                noun += "es";
            }

            else
            {
                noun += "s";
            }

            Console.WriteLine(noun);
        }
    }
}
