namespace _1.Hello__Name_
{
    using System;

    public class Hello__Name
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            Greeting(name);
        }

        public static void Greeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
