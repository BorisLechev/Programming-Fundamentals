namespace _5.StringCommander
{
    using System;

    public class StringCommander
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var commandInput = Console.ReadLine();

            while (commandInput != "end")
            {
                var command = commandInput.Split(' ');

                if (command[0] == "Left")
                {
                    int leftCount = int.Parse(command[1]);
                    leftCount = leftCount % input.Length;
                    input = input.Substring(leftCount) + input.Substring(0, leftCount);
                }

                if (command[0] == "Right")
                {
                    int rightCount = int.Parse(command[1]);
                    rightCount = rightCount % input.Length;
                    input = input.
                        Substring(input.Length - rightCount)
                        + input.Substring(0, input.Length - rightCount);
                }

                if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string toInsert = command[2];
                    input = input.Insert(index, toInsert);
                }

                if (command[0] == "Delete")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    input = input.Remove(startIndex, endIndex - startIndex + 1);
                }

                commandInput = Console.ReadLine();
            }

            Console.WriteLine(input);
        }
    }
}
