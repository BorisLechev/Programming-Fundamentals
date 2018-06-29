namespace _2.Snowmen
{
    using System;
    using System.Linq;

    public class Snowmen       
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' },
                  StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (input.Count > 1)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input.Count(x => x != -1) == 1)
                    {
                        break;
                    }

                    if (input[i] == -1)
                    {
                        continue;
                    }

                    int attacker = i;
                    int target = input[i] % input.Count;
                    int difference = Math.Abs(attacker - target);

                    if (attacker == target) // suicide
                    {
                        input[attacker] = -1;
                        Console.WriteLine($"{attacker} performed harakiri");
                    }

                    else if (difference % 2 == 0) // attacker wins
                    {
                        input[target] = -1;
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                    }

                    else // target wins
                    {
                        input[attacker] = -1;
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                    }
                }

                input = input.Where(x => x != -1).ToList();
            }
        }
    }
}
