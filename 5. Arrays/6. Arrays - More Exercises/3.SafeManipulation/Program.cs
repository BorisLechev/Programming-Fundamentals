namespace _3.SafeManipulation
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] arrOfStr = Console.ReadLine().Split(' ').ToArray();
            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "END")
            {
                string currentCommand = command[0];

                if (currentCommand == "Distinct")
                {
                    arrOfStr = arrOfStr.Distinct().ToArray();
                }

                else if (currentCommand == "Reverse")
                {
                    Array.Reverse(arrOfStr);
                }

                else if (currentCommand == "Replace")
                {
                    try
                    {
                        int index = int.Parse(command[1]);
                        string word = command[2];

                        arrOfStr[index] = word;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine(string.Join(", ", arrOfStr));
        }
    }
}
