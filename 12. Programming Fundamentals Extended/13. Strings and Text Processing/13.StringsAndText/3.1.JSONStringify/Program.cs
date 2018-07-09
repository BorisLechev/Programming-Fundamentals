namespace _3._1.JSONStringify
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class JSONStringify
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', ':', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var students = new List<string>();

            while (input[0] != "stringify")
            {
                var name = input[0];
                var age = input[1];
                var grades = input.Skip(2).Select(int.Parse).ToList();

                string output =
                    "{name:\"" + name + "\",age:" + age + ",grades:[" + string.Join(", ", grades) + "]}";

                students.Add(output);

                input = Console.ReadLine()
                .Split(new char[] { ' ', ':', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine("[" + string.Join(", ", students) + "]");
        }
    }
}
