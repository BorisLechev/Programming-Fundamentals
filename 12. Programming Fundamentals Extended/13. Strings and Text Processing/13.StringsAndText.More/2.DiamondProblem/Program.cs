namespace _2.DiamondProblem
{
    using System;

    public class DiamondProblem
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            int leftIndex = -1;
            int rightIndex = -1;
            bool isDiamond = false;

            while ((leftIndex = input.IndexOf('<', leftIndex + 1)) > -1 && (rightIndex = input.IndexOf('>', leftIndex + 1)) > -1)
            {
                string diamondContent = input.Substring(leftIndex + 1, rightIndex - leftIndex - 1);

                int sum = 0;

                foreach (var item in diamondContent)
                {
                    if (char.IsDigit(item))
                    {
                        sum += int.Parse(item.ToString());
                    }
                }

                isDiamond = true;
                Console.WriteLine($"Found {sum} carat diamond");
            }

            if (!isDiamond)
            {
                Console.WriteLine($"Better luck next time");
            }
        }
    }
}
