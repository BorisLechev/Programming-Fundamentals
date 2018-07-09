namespace _4.JSONParse
{
    using System;

    public class JSONParse
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var input = text.Trim('[')
                .Split(new string[] { "},{" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                string student = input[i];

                student = student
                    .Replace(":[]", ":[None]")
                    .Replace("{", string.Empty)
                    .Replace("}", string.Empty)
                    .Replace("name:", string.Empty)
                    .Replace(",age:", " : ")
                    .Replace(",grades:", " -> ")
                    .Replace("[", string.Empty)
                    .Replace("]", string.Empty)
                    .Replace("\"", string.Empty);

                Console.WriteLine(student);
            }
        }
    }
}
