namespace Variable_in_Hexadecimal_Format
{
    using System;

    public class Variable_in_Hexadecimal_Format
    {
        public static void Main()
        {
            string symbol = Console.ReadLine();
            decimal convertedSymbolToDecimal = Convert.ToInt32(symbol, 16);

            Console.WriteLine(convertedSymbolToDecimal);
        }
    }
}
