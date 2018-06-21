namespace Boolean_Variable
{
    using System;

    public class Boolean_Variable
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            bool isBoolean = Convert.ToBoolean(input);

            Console.WriteLine(isBoolean == true ? "Yes" : "No");
        }
    }
}
