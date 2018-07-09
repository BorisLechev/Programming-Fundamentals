namespace _8.Nilapdromes         //грешна
{
    using System;

    public class Nilapdromes
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string frontBorder = string.Empty;
                string core = string.Empty;
                string backBorder = string.Empty;

                for (int i = 0; i < input.Length / 2; i++)
                {
                    backBorder += input[i];

                    if (input.LastIndexOf(frontBorder) + frontBorder.Length == input.Length)
                    {
                        backBorder = frontBorder;
                        core = input.Remove(0, backBorder.Length);
                        core = input.Remove(core.Length - backBorder.Length, backBorder.Length);
                    }
                }

                if (backBorder.Length > 0 && core.Length > 0)
                {
                    Console.WriteLine(core + backBorder + core);
                }

                input = Console.ReadLine();
            }
        }
    }
}
