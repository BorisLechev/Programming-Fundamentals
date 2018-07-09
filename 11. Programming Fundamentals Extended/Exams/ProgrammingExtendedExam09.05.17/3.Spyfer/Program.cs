namespace _3.Spyfer
{
    using System;
    using System.Linq;

    public class Spyfer
    {
        public static void Main()
        {
            var coordinates = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int i = 0; i < coordinates.Count; i++)
            {
                int currentNumber = coordinates[i];

                if (i != 0 && i != coordinates.Count - 1)
                {
                    int sumOfNeighbours = coordinates[i - 1] + coordinates[i + 1];

                    if (currentNumber == sumOfNeighbours)
                    {
                        coordinates.RemoveAt(i + 1);
                        coordinates.RemoveAt(i - 1);
                        i = 0;
                    }
                }

                else if (i == 0 && currentNumber == coordinates[i + 1])
                {
                    coordinates.RemoveAt(i + 1);
                    i = 0;
                }

                else if (i == coordinates.Count - 1 && currentNumber == coordinates[i - 1])
                {
                    coordinates.RemoveAt(i - 1);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", coordinates));
        }
    }
}
//var numbers = Console.ReadLine()
//               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

//int startingPosition = 1;

//            for (int i = 0; i<numbers.Count; i++)
//            {
//                if (numbers[startingPosition - 1] + numbers[startingPosition + 1] == numbers[startingPosition])
//                {
//                    numbers.RemoveAt(startingPosition + 1);
//                    numbers.RemoveAt(startingPosition - 1);

//                    i = 0;
//                    startingPosition = 1;
//                }

//                else
//                {
//                    startingPosition++;
//                }

//                if (numbers.Count == 1 || numbers.Count == 2)
//                {
//                    break;
//                }
//            }

//            Console.WriteLine(string.Join(" ", numbers));