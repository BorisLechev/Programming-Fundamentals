namespace _2.MemoryView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MemoryView
    {
        public static void Main()   
        {
            string input = string.Empty;
            string result = string.Empty;

            while ((input = Console.ReadLine()) != "Visual Studio crash")
            {
                result += " " + input;
            }

            var numbers = result.Split(new string[] { " 0", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            while (numbers.Count != 0)
            {
                var wordInCode = new List<int>();

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == 32656)
                    {
                        var sizeOfTheList = numbers.Skip(3).Take(1).ToList();
                        int size = sizeOfTheList[0];
                        wordInCode = numbers.Skip(4).Take(size).ToList();

                        string word = MakeWord(wordInCode);

                        Console.WriteLine(word);

                        numbers = numbers.Skip(4 + size).ToList();
                        break;
                    }
                }
            }
        }

        public static string MakeWord(List<int> wordInCode)
        {
            string word = string.Empty;

            for (int i = 0; i < wordInCode.Count; i++)
            {
                word += (char)wordInCode[i];
            }

            return word;
        }
    }
}
