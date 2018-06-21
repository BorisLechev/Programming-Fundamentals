namespace Strings_and_Objects
{
    using System;

    public class Strings_and_Objects
    {
        public static void Main()
        {
            string firstWord = "Hello";
            string secondWord = "World";
            object sum = firstWord + " " + secondWord;
            string result = sum.ToString();

            Console.WriteLine(result);
        }
    }
}
