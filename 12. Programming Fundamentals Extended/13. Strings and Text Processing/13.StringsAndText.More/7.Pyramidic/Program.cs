namespace _7.Pyramidic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pyramidic
    {
        public static void Main()
        {
            var inputList = new List<string>();
            var outputList = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                inputList.Add(input);
            }

            for (int i = 0; i < inputList.Count; i++)
            {
                string currentRow = inputList[i];

                for (int j = 0; j < currentRow.Length; j++)
                {
                    char currentCharacter = currentRow[j];
                    int layer = 1;
                    string pyramid = string.Empty;

                    for (int k = i; k < inputList.Count; k++)
                    {
                        string currentLayer = new string(currentCharacter, layer);

                        if (inputList[k].Contains(currentLayer))
                        {
                            pyramid += currentLayer + Environment.NewLine;
                        }

                        else
                        {
                            break;
                        }

                        layer += 2;
                    }

                    outputList.Add(pyramid);
                }
            }

            Console.WriteLine(outputList.OrderByDescending(x => x.Length).First());
        }
    }
}
