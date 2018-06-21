namespace Print_Part_of_the_ASCII_Table 
{
    using System;

    public class Print_Part_of_the_ASCII_Table
    {
        public static void Main()
        {
            byte startIndex = byte.Parse(Console.ReadLine());
            byte endIndex = byte.Parse(Console.ReadLine());

            for (int index = startIndex; index <= endIndex; index++)
            {
                Console.Write((char)index + " ");
            }
        }
    }
}
