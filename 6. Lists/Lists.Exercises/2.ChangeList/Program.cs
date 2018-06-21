namespace _2.ChangeList
{
    using System;
    using System.Linq;

    public class ChangeList
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var command = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            string action = command[0];

            while (action != "Even" && action != "Odd")
            {
                int numberInCommand = int.Parse(command[1]);

                if (action == "Delete")
                {
                    numbers.RemoveAll(item => item == numberInCommand);
                }

                else if (action == "Insert")
                {
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, numberInCommand);
                }

                command = Console.ReadLine().Split(' ');
                action = command[0];
            }

            foreach (var nums in numbers)
            {
                if (action == "Even")
                {
                    if (nums % 2 == 0)
                    {
                        Console.Write(nums + " ");
                    }
                }

                else if (action == "Odd")
                {
                    if (nums % 2 == 1)
                    {
                        Console.Write(nums + " ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
