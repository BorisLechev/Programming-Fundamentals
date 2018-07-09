namespace _1._1.ValueOfAString
{
    using System;

    public class ValueOfAString
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string twoPossibleInputs = Console.ReadLine();

            int sum = 0;

            foreach (var letter in input)
            {
                if (twoPossibleInputs == "LOWERCASE")
                {
                    if (letter > 96 && letter < 123)
                    {
                        sum += (int)letter;
                    }
                }

                else if (twoPossibleInputs == "UPPERCASE")
                {
                    if (letter > 64 && letter < 91)
                    {
                        sum += (int)letter;
                    }
                }
            }

            Console.WriteLine($"The total sum is: {sum}");
        }
    }
}
