namespace _2.ManipulateArray
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] arrOfStr = Console.ReadLine().Split(' ').ToArray();
            int numOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
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
                    int index = int.Parse(command[1]);
                    string word = command[2];

                    arrOfStr[index] = word;
                }
            }

            Console.WriteLine(string.Join(", ", arrOfStr));
        }
    }
}
