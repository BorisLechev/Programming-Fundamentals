using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Concatenation // !!!!!!!!!!!!!?????????????????
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimeter = char.Parse(Console.ReadLine());
            string evenOrOddPositions = Console.ReadLine();
            byte n = byte.Parse(Console.ReadLine());
            string result = string.Empty;
            int wordsCounter = 0;
            bool isEven = evenOrOddPositions == "even" ? true : false;
            for (int i = 1; i <= n; i++)
            {
                string currentWord = Console.ReadLine();
                if (isEven && i % 2 == 0)
                {
                    wordsCounter++;
                    result += wordsCounter == 1 ? currentWord : delimeter + currentWord;
                }
                else if (!isEven && i % 2 == 1)
                {
                    wordsCounter++;
                    result += wordsCounter == 1 ? currentWord : delimeter + currentWord;
                }
            }
            Console.WriteLine(result);
        }
    }
}
