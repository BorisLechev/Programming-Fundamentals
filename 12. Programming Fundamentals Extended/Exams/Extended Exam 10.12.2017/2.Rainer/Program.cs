namespace _2.Rainer
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Rainer
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int currentIndex = input.Last();
            input = input.Take(input.Count - 1).ToList();

            bool hasGottenWet = false;
            int stepsCounter = 0;
            var originalValues = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                originalValues.Add(input[i]);
            }

            while (!hasGottenWet)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    input[i]--;
                }

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] == 0 && i == currentIndex)
                    {
                        hasGottenWet = true;
                        break;
                    }
                }

                if (hasGottenWet)
                {
                    break;
                }

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] == 0 && i != currentIndex)
                    {
                        input[i] = originalValues[i];
                    }
                }

                currentIndex = int.Parse(Console.ReadLine());
                stepsCounter++;
            }

            Console.WriteLine(string.Join(" ", input));
            Console.WriteLine(stepsCounter);
        }
    }
}
