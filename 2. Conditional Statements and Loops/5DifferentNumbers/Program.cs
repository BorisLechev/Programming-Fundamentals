namespace _5DifferentNumbers
{
    using System;

    public class FiveDifferentNumbers
    {
        public static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (number2 - number1 < 4)
            {
                Console.WriteLine("No");
            }

            for (int first = number1; first <= number2; first++)
            {
                for (int second = number1; second <= number2; second++)
                {
                    for (int third = number1; third <= number2; third++)
                    {
                        for (int fourth = number1; fourth <= number2; fourth++)
                        {
                            for (int fifth = number1; fifth <= number2; fifth++)
                            {
                                if (first < second && second < third && third < fourth && fourth < fifth)
                                {
                                    Console.WriteLine($"{first} {second} {third} {fourth} {fifth}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
