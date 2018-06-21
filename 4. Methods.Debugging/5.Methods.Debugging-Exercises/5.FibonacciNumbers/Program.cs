namespace _5.FibonacciNumbers
{
    using System;

    public class FibonacciNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Fibonacci(number);
        }

        public static void Fibonacci(int number)
        {
            int firstNumber = 0;
            int secondNumber = 1;

            for (int i = 0; i < number; i++)
            {
                int result = firstNumber;
                firstNumber = secondNumber;
                secondNumber = result + secondNumber;
            }

            Console.WriteLine(secondNumber);
        }
    }
}
