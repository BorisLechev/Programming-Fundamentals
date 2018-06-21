using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int greater = GetMax(firstNumber, secondNumber);
                Console.WriteLine(greater);
            }

            else if (type == "string")
            {
                string firstStr = Console.ReadLine();
                string secondStr = Console.ReadLine();
                string greater = GetMax(firstStr, secondStr);
                Console.WriteLine(greater);
            }

            else if (type == "char")
            {
                char firstLetter = char.Parse(Console.ReadLine());
                char secondLetter = char.Parse(Console.ReadLine());
                char greater = GetMax(firstLetter, secondLetter);
                Console.WriteLine(greater);
            }

            else
            {
                Console.WriteLine("The type must be int, string or char. Try again!");
            }
        }

        public static int GetMax(int firstNumber, int secondNumber)
        {
            int greater;

            if (firstNumber > secondNumber)
            {
                greater = firstNumber;
            }

            else
            {
                greater = secondNumber;
            }

            return greater;
        }

        public static char GetMax(char firstSymbol, char secondSymbol)
        {
            char greater;

            if (firstSymbol > secondSymbol)
            {
                greater = firstSymbol;
            }

            else
            {
                greater = secondSymbol;
            }

            return greater;
        }

        public static string GetMax(string firstStr, string secondStr)
        {
            string greater;

            if (firstStr.CompareTo(secondStr) >= 0)
            {
                greater = firstStr;
            }

            else
            {
                greater = secondStr;
            }

            return greater;
        }
    }
}
