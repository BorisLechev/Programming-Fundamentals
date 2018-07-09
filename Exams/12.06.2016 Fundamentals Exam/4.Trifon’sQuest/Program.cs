namespace _4.Trifon_sQuest
{
    using System;
    using System.Linq;

    public class Trifon_sQuest
    {
        public static void Main()
        {
            long healthTrifon = long.Parse(Console.ReadLine());

            var dimensionsOfTheMap = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            long row = dimensionsOfTheMap[0];
            long columns = dimensionsOfTheMap[1];

            var matrixLetters = new char[row][];

            BuildTheMap(matrixLetters, row);

            long col = 0;
            long rows = 0;
            long turns = 0;
            long endOfQuesting = rows * columns;

            while (turns < endOfQuesting)
            {
                if (matrixLetters[row][col] == 'F')
                {
                    healthTrifon -= turns / 2;
                }

                else if (matrixLetters[row][col] == 'H')
                {
                    healthTrifon += turns / 3;
                }

                else if (matrixLetters[row][col] == 'T')
                {
                    turns += 2;
                    endOfQuesting += 2;
                }

                if (healthTrifon <= 0)
                {
                    Console.WriteLine($"Died at: [{row}, {col}]");
                    break;
                }

                if (col % 2 == 1)
                {
                    row--;
                }

                if (row == rows - 1 || (row == -1 && col % 2 == 1))
                {
                    col++;
                }

                if (col % 2 == 0)
                {
                    row++;
                }

                turns++;
            }

            if (healthTrifon > 0)
            {
                Console.WriteLine("Quest completed!");
                Console.WriteLine($"Health: {healthTrifon}");
                Console.WriteLine($"Turns: {turns}");
            }
        }

        public static void BuildTheMap(char[][] matrixLetters, long row)
        {
            var rowLettersArray = new string[row];

            for (int i = 0; i < row; i++)
            {
                rowLettersArray[row] = Console.ReadLine();
            }

            for (int i = 0; i < row; i++)
            {
                matrixLetters[row] = rowLettersArray[row].ToCharArray();
            }
        }
    }
}
