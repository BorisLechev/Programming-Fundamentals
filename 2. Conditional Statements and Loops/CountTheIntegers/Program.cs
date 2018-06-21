namespace CountTheIntegers
{
    using System;

    public class CountTheIntegers
    {
        public static void Main()
        {
            int counter = 0;

            try
            {
                while (true)
                {
                    int integer = int.Parse(Console.ReadLine());
                    counter++;
                }
            }

            catch (Exception)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
