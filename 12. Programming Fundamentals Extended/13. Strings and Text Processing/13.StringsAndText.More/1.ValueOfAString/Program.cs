namespace _1.ValueOfAString
{
    using System;

    public class ValueOfAString
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string twoPossibleInputs = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (twoPossibleInputs == "LOWERCASE")
                {
                    if (char.IsLower(input[i]))
                    {
                        sum += (int)input[i];
                    }
                }

                else if (twoPossibleInputs == "UPPERCASE")
                {
                    if (char.IsUpper(input[i]))
                    {
                        sum += (int)input[i];
                    }
                }
            }

            Console.WriteLine($"The total sum is: {sum}");
        }
    }
}
