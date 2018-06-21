namespace Integer_to_Hex_and_Binary
{
    using System;

    public class Integer_to_Hex_and_Binary
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string hexadecimal = Convert.ToString(number, 16).ToUpper();

            Console.WriteLine(hexadecimal);

            string binary = Convert.ToString(number, 2);

            Console.WriteLine(binary);
        }
    }
}
