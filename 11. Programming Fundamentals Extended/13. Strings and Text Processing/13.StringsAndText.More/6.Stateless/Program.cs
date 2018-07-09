namespace _6.Stateless
{
    using System;

    public class Stateless
    {
        public static void Main()
        {
            string state = Console.ReadLine();

            while (state != "collapse")
            {
                string fiction = Console.ReadLine();

                while (fiction.Length > 0)
                {
                    state = state.Replace(fiction, string.Empty);

                    fiction = fiction.Remove(0, 1);

                    if (fiction.Length > 0)
                    {
                        fiction = fiction.Remove(fiction.Length - 1, 1);
                    }
                }

                if (state.Length == 0)
                {
                    Console.WriteLine("(void)");
                }

                else
                {
                    Console.WriteLine(state);
                }

                state = Console.ReadLine();
            }
        }
    }
}
