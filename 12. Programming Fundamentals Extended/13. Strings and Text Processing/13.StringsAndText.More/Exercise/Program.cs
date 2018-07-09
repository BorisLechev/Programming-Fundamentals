using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var commandInput = Console.ReadLine().Split(' ');

            while (commandInput[0] != "end")
            {
                if (commandInput[0] == "Delete")
                {
                    int startIndex = int.Parse(commandInput[1]);
                    int endIndex = int.Parse(commandInput[2]);

                    input.Remove(startIndex, endIndex - startIndex + 1);
                }

                else if (commandInput[0] == "Insert")
                {
                    int index = int.Parse(commandInput[1]);
                    string newWord = commandInput[2];

                    input.Insert(index, newWord);
                }

                else if (commandInput[0] == "Left")
                {
                    int count = int.Parse(commandInput[1]);
                    count = count % input.Length;
                    input = input.Substring(count) + input.Substring(0, count);
                }

                else if (commandInput[0] == "Right")
                {
                    int count = int.Parse(commandInput[1]);
                    count = count % input.Length;
                    input = input.Substring(input.Length - count) + input.Substring(0, input.Length - count);
                }
                commandInput = Console.ReadLine().Split(' ');

            }
            Console.WriteLine(input);

        }

    }
}
